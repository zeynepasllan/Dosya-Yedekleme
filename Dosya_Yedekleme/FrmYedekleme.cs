using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dosya_Yedekleme
{
    public partial class FrmYedekleme : Form
    {
        public FrmYedekleme()
        {
            InitializeComponent();
        }

        private void FrmYedekleme_Load(object sender, EventArgs e)
        {
            textBoxKaynak.Enabled = false;
            textBoxHedef.Enabled = false;
            for (int i = 1; i <= 23; i++)
            {
                if (i <= 9)
                {
                    comboBoxSaat.Items.Add("0" + i);
                }
                else
                {
                    comboBoxSaat.Items.Add(i);
                }
            }
            comboBoxSaat.Items.Add("00");
            for (int i = 1; i <= 59; i++)
            {
                if (i <= 9)
                {
                    comboBoxDakika.Items.Add("0" + i);
                }
                else
                {
                    comboBoxDakika.Items.Add(i);
                }
            }
            comboBoxDakika.Items.Add("00");
        }

        private void btnKaynak_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Yedeklenecek klasörü seçiniz.";
            openFileDialog1.FileName = "";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                kaynakKlasor = folderBrowserDialog1.SelectedPath.ToString();
                textBoxKaynak.Text = kaynakKlasor;
                listBoxDosyalar.Items.Clear();
                var dosyalar = new DirectoryInfo(kaynakKlasor).GetFiles("*.*");
                foreach (FileInfo dosya in dosyalar)
                {
                    listBoxDosyalar.Items.Add(dosya.Name);
                    if (tabControlDosyalar.SelectedIndex == 0 && dosya.Name.EndsWith(".zip"))
                    {
                        listBoxZip.Items.Add(dosya.Name);
                    }
                    else if(dosya.Name.EndsWith(".txt"))
                    {
                        listBoxTxt.Items.Add(dosya.Name);
                    }
                }
                DirectoryInfo DrInf = new DirectoryInfo(kaynakKlasor);
                DirectoryInfo[] DrInfLst = DrInf.GetDirectories();
                foreach (DirectoryInfo klasor in DrInfLst)
                {
                    listBoxDosyalar.Items.Add(klasor.Name);
                    listBoxKlasor.Items.Add(klasor.Name);
                }
              }
            else
            {
                MessageBox.Show("Klasör Seçmediniz.");
            }
        }

        private void btnHedef_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                hedefKlasor = folderBrowserDialog1.SelectedPath.ToString();
                textBoxHedef.Text = hedefKlasor;
            }
            else
            {
                MessageBox.Show("Hedef klasörü seçmediniz.");
            }
        }

        private void btnYedekle_Click(object sender, EventArgs e)
        {
            if (hedefKlasor != "" && kaynakKlasor != "")
            {
                int sayac = 0;
                foreach (string item in listBoxDosyalar.Items)
                {
                    var dosyaAdi = item.Substring(0, item.LastIndexOf(".") + 1);

                    if (!File.Exists(hedefKlasor + "\\" + item) && dosyaAdi != "")
                    {
                        File.Copy(kaynakKlasor + "\\" + item, hedefKlasor + "\\" + item);
                        sayac++;
                    }
                    else if (dosyaAdi == "")

                    {
                        Kopyala(textBoxKaynak.Text, textBoxHedef.Text, true);
                        sayac++;
                    }
                }
                MessageBox.Show($"{sayac} Adet Dosya Yedekleme İşlemi Başarılı");
            }
        }

        private void Zip_SaveProgress(object sender, Ionic.Zip.SaveProgressEventArgs e)
        {
            if (e.EventType == Ionic.Zip.ZipProgressEventType.Saving_BeforeWriteEntry)
            {
                progressBar1.Invoke(new MethodInvoker(delegate
                {
                    progressBar1.Maximum = e.EntriesTotal;
                    progressBar1.Value = e.EntriesSaved + 1;
                    progressBar1.Update();
                }));
            }
        }

        string kaynakKlasor = "", hedefKlasor = "";

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string metin = textBoxSil.Text;
            var dosyalar = new DirectoryInfo(kaynakKlasor).GetFiles("*.*");           
            DirectoryInfo DrInf = new DirectoryInfo(kaynakKlasor);
            DirectoryInfo[] DrInfLst = DrInf.GetDirectories();
            if (metin != string.Empty)
            {
                foreach (FileInfo dosya in dosyalar)
                {
                    string ilkHarf = metin.Substring(0, 1);
                    string sonMetin = dosya.Name.Substring(dosya.Name.Length - 3, 3);
                    if (metin == dosya.Name)
                    {
                        listBoxSilinenler.Items.Add(metin);
                        textBoxSil.Text = "";
                        lblSilinen.Text = metin;
                        listBoxDosyalar.Items.Remove(dosya.Name);
                        if (metin.EndsWith(".zip"))
                        {
                            listBoxZip.Items.Remove(dosya.Name);
                        }
                        if (metin.EndsWith(".txt"))
                        {
                            listBoxTxt.Items.Remove(dosya.Name);
                        }
                    }
                    else if (metin.Substring(metin.Length - 3, 3) == sonMetin && ilkHarf == "*")
                    {
                        listBoxSilinenler.Items.Add(dosya.Name);
                        listBoxDosyalar.Items.Remove(dosya.Name);
                    }                   
                }
                
                foreach (DirectoryInfo klasor in DrInfLst)
                {
                    if (metin == klasor.Name)
                    {
                        listBoxSilinenler.Items.Add(metin);
                        textBoxSil.Text = "";
                        lblSilinen.Text = metin;
                        listBoxDosyalar.Items.Remove(klasor.Name);
                        listBoxKlasor.Items.Remove(klasor.Name);
                    }
                } 
            }            
        }

        private void btnZiple_Click(object sender, EventArgs e)
        {
            var ziplenecekKlasor = textBoxHedef.Text;
            var ziplenecekKlasor2 = textBoxHedef.Text + ("\\");
            var ziplemeKonumu = ziplenecekKlasor2.Substring(0, ziplenecekKlasor2.LastIndexOf("\\") + 1);
            var tarihBilgi = DateTime.Now.ToShortDateString().Replace(".", "-") + " " + DateTime.Now.Hour.ToString() + "." + DateTime.Now.Minute.ToString();
            var klasorAdi = tarihBilgi + " " + ziplenecekKlasor.Substring(ziplenecekKlasor.LastIndexOf("\\") + 1);
            if(comboBoxSaat.Text == "" && comboBoxDakika.Text == "" && textBoxYedekMiktar.Text != "")
            {                
                int miktar = int.Parse(textBoxYedekMiktar.Text);
                int sayac = 0;
                for (var i = 1; i <= miktar; i++)
                    {
                        sayac++;
                        KlasorZipleme(ziplenecekKlasor, ziplemeKonumu + klasorAdi + sayac + ".zip", klasorAdi, tarihBilgi);
                    }
                
            }
            else if(comboBoxSaat.Text != "" && comboBoxDakika.Text != "" && textBoxYedekMiktar.Text != "")
            {  
                tmrZamanKontrol.Start();
            }
            else if (comboBoxSaat.Text != "" && comboBoxDakika.Text != "" && textBoxYedekMiktar.Text == "")
            {
                tmrZamanKontrol.Start();
            }
            else
            {
                KlasorZipleme(ziplenecekKlasor, ziplemeKonumu + klasorAdi + ".zip", klasorAdi, tarihBilgi);
            }
        }

        private void KlasorZipleme(string kaynakKlasor, string ziplemeKonumu, string klasorAdi, string tarihBilgi)
        {
            if (string.IsNullOrEmpty(textBoxHedef.Text))
            {
                MessageBox.Show("Please select your folder", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxHedef.Focus();
                return;
            }
            string path = textBoxHedef.Text;
            Thread thread = new Thread(t =>
            {
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                using (Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile())
                {
                    zip.AddDirectory(kaynakKlasor);
                    zip.SaveProgress += Zip_SaveProgress;
                    zip.Save(ziplemeKonumu);
                }

                var dosyalar = new DirectoryInfo(hedefKlasor).GetFiles("*.*");
                foreach (FileInfo dosya in dosyalar)
                {
                    var varolanZip = dosya.Name.Substring(1, dosya.Name.IndexOf("-") + 1);
                    if (dosya.Name != klasorAdi + ".zip" && varolanZip == "")
                    {
                        dosya.Delete();
                    }
                }

                DirectoryInfo DrInf = new DirectoryInfo(kaynakKlasor);
                DirectoryInfo[] DrInfLst = DrInf.GetDirectories();
                foreach (DirectoryInfo klasor in DrInfLst)
                {
                    if (klasor.Name != klasorAdi + ".zip")
                    {
                        klasor.Delete();
                    }
                }
            })

            { IsBackground = true };
            thread.Start();
        }

        private void tmrZamanKontrol_Tick(object sender, EventArgs e)
        {            
            int sayac = 0;
            var saat = DateTime.Now.Hour.ToString();
            var dakika = DateTime.Now.Minute.ToString();
            var ziplenecekKlasor = textBoxHedef.Text;
            var ziplenecekKlasor2 = textBoxHedef.Text + ("\\");
            var ziplemeKonumu = ziplenecekKlasor2.Substring(0, ziplenecekKlasor2.LastIndexOf("\\") + 1);
            var tarihBilgi = DateTime.Now.ToShortDateString().Replace(".", "-") + " " + DateTime.Now.Hour.ToString() + "." + DateTime.Now.Minute.ToString();
            var klasorAdi = tarihBilgi + " " + ziplenecekKlasor.Substring(ziplenecekKlasor.LastIndexOf("\\") + 1);

            if(saat.Length == 1)
            {
                saat = "0" + saat;
            }

            if(dakika.Length == 1)
            {
                dakika = "0" + dakika;
            }

            if (saat == comboBoxSaat.Text && dakika == comboBoxDakika.Text && textBoxYedekMiktar.Text != "")
            {
                int miktar = int.Parse(textBoxYedekMiktar.Text);
                for (var i = 1; i <= miktar; i++)
                {
                    sayac++;
                    KlasorZipleme(ziplenecekKlasor, ziplemeKonumu + klasorAdi + sayac + ".zip", klasorAdi, tarihBilgi);
                }
            }
            else
            {
                KlasorZipleme(ziplenecekKlasor, ziplemeKonumu + klasorAdi + ".zip", klasorAdi, tarihBilgi);
            }
        }

        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
                string geriAl = lblSilinen.Text;
                listBoxDosyalar.Items.Add(geriAl);
                listBoxSilinenler.Items.Remove(geriAl);
                lblSilinen.Text = string.Empty;
            if(geriAl.EndsWith(".zip"))
            {
                listBoxZip.Items.Add(geriAl);
            }
            else if (geriAl.EndsWith(".txt"))
            {
                listBoxTxt.Items.Add(geriAl);
            }
            else
            {
                listBoxKlasor.Items.Add(geriAl);
            }

        }

        protected void Kopyala(string Prmt1, string prmt2, bool prmt3)
        {
            DirectoryInfo DrInf = new DirectoryInfo(Prmt1);
            DirectoryInfo[] DrInfLst = DrInf.GetDirectories();
            if (!Directory.Exists(prmt2))
            {
                Directory.CreateDirectory(prmt2);
            }

            string path1 = "";

            if (true)
            {
                foreach (DirectoryInfo klasor in DrInfLst)
                {
                    path1 = Path.Combine(prmt2, klasor.Name);
                    Kopyala(klasor.FullName, path1, true);
                }
            }
        }
    }
 }
