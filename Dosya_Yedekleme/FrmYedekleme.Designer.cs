
namespace Dosya_Yedekleme
{
    partial class FrmYedekleme
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYedekleme));
            this.btnKaynak = new System.Windows.Forms.Button();
            this.btnHedef = new System.Windows.Forms.Button();
            this.btnYedekle = new System.Windows.Forms.Button();
            this.textBoxKaynak = new System.Windows.Forms.TextBox();
            this.textBoxHedef = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblSilinen = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBoxSil = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.listBoxSilinenler = new System.Windows.Forms.ListBox();
            this.contextMenuStripGeriAl = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.geriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnZiple = new System.Windows.Forms.Button();
            this.tmrZamanKontrol = new System.Windows.Forms.Timer(this.components);
            this.comboBoxSaat = new System.Windows.Forms.ComboBox();
            this.textBoxYedekMiktar = new System.Windows.Forms.TextBox();
            this.comboBoxDakika = new System.Windows.Forms.ComboBox();
            this.tabControlDosyalar = new System.Windows.Forms.TabControl();
            this.tabPageZip = new System.Windows.Forms.TabPage();
            this.listBoxZip = new System.Windows.Forms.ListBox();
            this.tabPageTxt = new System.Windows.Forms.TabPage();
            this.listBoxTxt = new System.Windows.Forms.ListBox();
            this.tabPageKlasor = new System.Windows.Forms.TabPage();
            this.listBoxKlasor = new System.Windows.Forms.ListBox();
            this.tabPageTumDosyalar = new System.Windows.Forms.TabPage();
            this.listBoxDosyalar = new System.Windows.Forms.ListBox();
            this.imageListLogo = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStripGeriAl.SuspendLayout();
            this.tabControlDosyalar.SuspendLayout();
            this.tabPageZip.SuspendLayout();
            this.tabPageTxt.SuspendLayout();
            this.tabPageKlasor.SuspendLayout();
            this.tabPageTumDosyalar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKaynak
            // 
            this.btnKaynak.Location = new System.Drawing.Point(63, 139);
            this.btnKaynak.Name = "btnKaynak";
            this.btnKaynak.Size = new System.Drawing.Size(75, 23);
            this.btnKaynak.TabIndex = 0;
            this.btnKaynak.Text = "Dosya Seç";
            this.btnKaynak.UseVisualStyleBackColor = true;
            this.btnKaynak.Click += new System.EventHandler(this.btnKaynak_Click);
            // 
            // btnHedef
            // 
            this.btnHedef.Location = new System.Drawing.Point(63, 288);
            this.btnHedef.Name = "btnHedef";
            this.btnHedef.Size = new System.Drawing.Size(75, 23);
            this.btnHedef.TabIndex = 1;
            this.btnHedef.Text = "Dosya Seç";
            this.btnHedef.UseVisualStyleBackColor = true;
            this.btnHedef.Click += new System.EventHandler(this.btnHedef_Click);
            // 
            // btnYedekle
            // 
            this.btnYedekle.Location = new System.Drawing.Point(997, 601);
            this.btnYedekle.Name = "btnYedekle";
            this.btnYedekle.Size = new System.Drawing.Size(65, 23);
            this.btnYedekle.TabIndex = 2;
            this.btnYedekle.Text = "Yedekle";
            this.btnYedekle.UseVisualStyleBackColor = true;
            this.btnYedekle.Click += new System.EventHandler(this.btnYedekle_Click);
            // 
            // textBoxKaynak
            // 
            this.textBoxKaynak.Location = new System.Drawing.Point(63, 101);
            this.textBoxKaynak.Name = "textBoxKaynak";
            this.textBoxKaynak.Size = new System.Drawing.Size(302, 23);
            this.textBoxKaynak.TabIndex = 3;
            // 
            // textBoxHedef
            // 
            this.textBoxHedef.Location = new System.Drawing.Point(63, 249);
            this.textBoxHedef.Name = "textBoxHedef";
            this.textBoxHedef.Size = new System.Drawing.Size(302, 23);
            this.textBoxHedef.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblSilinen
            // 
            this.lblSilinen.AutoSize = true;
            this.lblSilinen.Location = new System.Drawing.Point(72, 675);
            this.lblSilinen.Name = "lblSilinen";
            this.lblSilinen.Size = new System.Drawing.Size(0, 15);
            this.lblSilinen.TabIndex = 8;
            this.lblSilinen.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1139, 601);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(24, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // textBoxSil
            // 
            this.textBoxSil.Location = new System.Drawing.Point(6, 42);
            this.textBoxSil.Name = "textBoxSil";
            this.textBoxSil.Size = new System.Drawing.Size(215, 23);
            this.textBoxSil.TabIndex = 10;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(233, 41);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // listBoxSilinenler
            // 
            this.listBoxSilinenler.ContextMenuStrip = this.contextMenuStripGeriAl;
            this.listBoxSilinenler.FormattingEnabled = true;
            this.listBoxSilinenler.ItemHeight = 15;
            this.listBoxSilinenler.Location = new System.Drawing.Point(6, 67);
            this.listBoxSilinenler.Name = "listBoxSilinenler";
            this.listBoxSilinenler.ScrollAlwaysVisible = true;
            this.listBoxSilinenler.Size = new System.Drawing.Size(302, 424);
            this.listBoxSilinenler.TabIndex = 12;
            // 
            // contextMenuStripGeriAl
            // 
            this.contextMenuStripGeriAl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geriAlToolStripMenuItem});
            this.contextMenuStripGeriAl.Name = "contextMenuStripGeriAl";
            this.contextMenuStripGeriAl.Size = new System.Drawing.Size(110, 26);
            // 
            // geriAlToolStripMenuItem
            // 
            this.geriAlToolStripMenuItem.Name = "geriAlToolStripMenuItem";
            this.geriAlToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.geriAlToolStripMenuItem.Text = "Geri Al";
            this.geriAlToolStripMenuItem.Click += new System.EventHandler(this.geriAlToolStripMenuItem_Click);
            // 
            // btnZiple
            // 
            this.btnZiple.Location = new System.Drawing.Point(1068, 601);
            this.btnZiple.Name = "btnZiple";
            this.btnZiple.Size = new System.Drawing.Size(65, 23);
            this.btnZiple.TabIndex = 13;
            this.btnZiple.Text = "Ziple";
            this.btnZiple.UseVisualStyleBackColor = true;
            this.btnZiple.Click += new System.EventHandler(this.btnZiple_Click);
            // 
            // tmrZamanKontrol
            // 
            this.tmrZamanKontrol.Interval = 60000;
            this.tmrZamanKontrol.Tick += new System.EventHandler(this.tmrZamanKontrol_Tick);
            // 
            // comboBoxSaat
            // 
            this.comboBoxSaat.FormattingEnabled = true;
            this.comboBoxSaat.Location = new System.Drawing.Point(8, 67);
            this.comboBoxSaat.Name = "comboBoxSaat";
            this.comboBoxSaat.Size = new System.Drawing.Size(52, 23);
            this.comboBoxSaat.TabIndex = 15;
            // 
            // textBoxYedekMiktar
            // 
            this.textBoxYedekMiktar.Location = new System.Drawing.Point(26, 46);
            this.textBoxYedekMiktar.Name = "textBoxYedekMiktar";
            this.textBoxYedekMiktar.Size = new System.Drawing.Size(67, 23);
            this.textBoxYedekMiktar.TabIndex = 19;
            // 
            // comboBoxDakika
            // 
            this.comboBoxDakika.FormattingEnabled = true;
            this.comboBoxDakika.Location = new System.Drawing.Point(73, 67);
            this.comboBoxDakika.Name = "comboBoxDakika";
            this.comboBoxDakika.Size = new System.Drawing.Size(52, 23);
            this.comboBoxDakika.TabIndex = 22;
            // 
            // tabControlDosyalar
            // 
            this.tabControlDosyalar.Controls.Add(this.tabPageZip);
            this.tabControlDosyalar.Controls.Add(this.tabPageTxt);
            this.tabControlDosyalar.Controls.Add(this.tabPageKlasor);
            this.tabControlDosyalar.Controls.Add(this.tabPageTumDosyalar);
            this.tabControlDosyalar.ImageList = this.imageListLogo;
            this.tabControlDosyalar.Location = new System.Drawing.Point(6, 38);
            this.tabControlDosyalar.Name = "tabControlDosyalar";
            this.tabControlDosyalar.SelectedIndex = 0;
            this.tabControlDosyalar.Size = new System.Drawing.Size(402, 451);
            this.tabControlDosyalar.TabIndex = 24;
            // 
            // tabPageZip
            // 
            this.tabPageZip.Controls.Add(this.listBoxZip);
            this.tabPageZip.ImageIndex = 2;
            this.tabPageZip.Location = new System.Drawing.Point(4, 24);
            this.tabPageZip.Name = "tabPageZip";
            this.tabPageZip.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageZip.Size = new System.Drawing.Size(394, 423);
            this.tabPageZip.TabIndex = 0;
            this.tabPageZip.Text = "Zip Dosyaları";
            this.tabPageZip.UseVisualStyleBackColor = true;
            // 
            // listBoxZip
            // 
            this.listBoxZip.FormattingEnabled = true;
            this.listBoxZip.ItemHeight = 15;
            this.listBoxZip.Location = new System.Drawing.Point(-4, 0);
            this.listBoxZip.Name = "listBoxZip";
            this.listBoxZip.ScrollAlwaysVisible = true;
            this.listBoxZip.Size = new System.Drawing.Size(402, 424);
            this.listBoxZip.TabIndex = 6;
            // 
            // tabPageTxt
            // 
            this.tabPageTxt.Controls.Add(this.listBoxTxt);
            this.tabPageTxt.ImageIndex = 0;
            this.tabPageTxt.Location = new System.Drawing.Point(4, 24);
            this.tabPageTxt.Name = "tabPageTxt";
            this.tabPageTxt.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTxt.Size = new System.Drawing.Size(394, 423);
            this.tabPageTxt.TabIndex = 1;
            this.tabPageTxt.Text = "Txt Dosyaları";
            this.tabPageTxt.UseVisualStyleBackColor = true;
            // 
            // listBoxTxt
            // 
            this.listBoxTxt.FormattingEnabled = true;
            this.listBoxTxt.ItemHeight = 15;
            this.listBoxTxt.Location = new System.Drawing.Point(-4, 0);
            this.listBoxTxt.Name = "listBoxTxt";
            this.listBoxTxt.ScrollAlwaysVisible = true;
            this.listBoxTxt.Size = new System.Drawing.Size(402, 424);
            this.listBoxTxt.TabIndex = 7;
            // 
            // tabPageKlasor
            // 
            this.tabPageKlasor.Controls.Add(this.listBoxKlasor);
            this.tabPageKlasor.ImageIndex = 1;
            this.tabPageKlasor.Location = new System.Drawing.Point(4, 24);
            this.tabPageKlasor.Name = "tabPageKlasor";
            this.tabPageKlasor.Size = new System.Drawing.Size(394, 423);
            this.tabPageKlasor.TabIndex = 2;
            this.tabPageKlasor.Text = "Klasorler";
            this.tabPageKlasor.UseVisualStyleBackColor = true;
            // 
            // listBoxKlasor
            // 
            this.listBoxKlasor.FormattingEnabled = true;
            this.listBoxKlasor.ItemHeight = 15;
            this.listBoxKlasor.Location = new System.Drawing.Point(-4, 0);
            this.listBoxKlasor.Name = "listBoxKlasor";
            this.listBoxKlasor.ScrollAlwaysVisible = true;
            this.listBoxKlasor.Size = new System.Drawing.Size(402, 424);
            this.listBoxKlasor.TabIndex = 7;
            // 
            // tabPageTumDosyalar
            // 
            this.tabPageTumDosyalar.Controls.Add(this.listBoxDosyalar);
            this.tabPageTumDosyalar.Location = new System.Drawing.Point(4, 24);
            this.tabPageTumDosyalar.Name = "tabPageTumDosyalar";
            this.tabPageTumDosyalar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTumDosyalar.Size = new System.Drawing.Size(394, 423);
            this.tabPageTumDosyalar.TabIndex = 3;
            this.tabPageTumDosyalar.Text = "Tüm Dosyalar";
            this.tabPageTumDosyalar.UseVisualStyleBackColor = true;
            // 
            // listBoxDosyalar
            // 
            this.listBoxDosyalar.FormattingEnabled = true;
            this.listBoxDosyalar.ItemHeight = 15;
            this.listBoxDosyalar.Location = new System.Drawing.Point(-4, 0);
            this.listBoxDosyalar.Name = "listBoxDosyalar";
            this.listBoxDosyalar.ScrollAlwaysVisible = true;
            this.listBoxDosyalar.Size = new System.Drawing.Size(402, 424);
            this.listBoxDosyalar.TabIndex = 6;
            // 
            // imageListLogo
            // 
            this.imageListLogo.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListLogo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLogo.ImageStream")));
            this.imageListLogo.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLogo.Images.SetKeyName(0, "txt.png");
            this.imageListLogo.Images.SetKeyName(1, "klasor.png");
            this.imageListLogo.Images.SetKeyName(2, "zip.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxSilinenler);
            this.groupBox1.Controls.Add(this.textBoxSil);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Location = new System.Drawing.Point(855, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 495);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yedeklenmeyecekler Dosyalar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControlDosyalar);
            this.groupBox2.Location = new System.Drawing.Point(404, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 495);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yedeklenecek Dosyalar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Yedek Alınacak Dosya";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Yedek Dosyanın Tutulacağı Yer";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxYedekMiktar);
            this.groupBox3.Location = new System.Drawing.Point(63, 364);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(123, 103);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yedekleme Miktarı";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.comboBoxSaat);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.comboBoxDakika);
            this.groupBox4.Location = new System.Drawing.Point(215, 364);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(150, 103);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Yedeklenecek Saat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 32;
            this.label5.Text = "Dakika";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "Saat";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 26);
            // 
            // FrmYedekleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 656);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnZiple);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblSilinen);
            this.Controls.Add(this.textBoxHedef);
            this.Controls.Add(this.textBoxKaynak);
            this.Controls.Add(this.btnYedekle);
            this.Controls.Add(this.btnHedef);
            this.Controls.Add(this.btnKaynak);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmYedekleme";
            this.Text = "Dosya Yedekle";
            this.Load += new System.EventHandler(this.FrmYedekleme_Load);
            this.contextMenuStripGeriAl.ResumeLayout(false);
            this.tabControlDosyalar.ResumeLayout(false);
            this.tabPageZip.ResumeLayout(false);
            this.tabPageTxt.ResumeLayout(false);
            this.tabPageKlasor.ResumeLayout(false);
            this.tabPageTumDosyalar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaynak;
        private System.Windows.Forms.Button btnHedef;
        private System.Windows.Forms.Button btnYedekle;
        private System.Windows.Forms.TextBox textBoxKaynak;
        private System.Windows.Forms.TextBox textBoxHedef;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox listBoxDosyalar;
        private System.Windows.Forms.Label lblSilinen;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBoxSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox listBoxSilinenler;
        private System.Windows.Forms.Button btnZiple;
        private System.Windows.Forms.Timer tmrZamanKontrol;
        private System.Windows.Forms.ComboBox comboBoxSaat;
        private System.Windows.Forms.TextBox textBoxYedekMiktar;
        private System.Windows.Forms.ComboBox comboBoxDakika;
        private System.Windows.Forms.TabControl tabControlDosyalar;
        private System.Windows.Forms.TabPage tabPageZip;
        private System.Windows.Forms.TabPage tabPageTxt;
        private System.Windows.Forms.TabPage tabPageKlasor;
        private System.Windows.Forms.ImageList imageListLogo;
        private System.Windows.Forms.ListBox listBoxZip;
        private System.Windows.Forms.ListBox listBoxTxt;
        private System.Windows.Forms.ListBox listBoxKlasor;
        private System.Windows.Forms.TabPage tabPageTumDosyalar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripGeriAl;
        private System.Windows.Forms.ToolStripMenuItem geriAlToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

