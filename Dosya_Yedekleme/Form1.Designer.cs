
namespace Dosya_Yedekleme
{
    partial class Form1
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
            this.btnKaynak = new System.Windows.Forms.Button();
            this.btnHedef = new System.Windows.Forms.Button();
            this.btnYedekle = new System.Windows.Forms.Button();
            this.textBoxKaynak = new System.Windows.Forms.TextBox();
            this.textBoxHedef = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.listBoxDosyalar = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1_Sil_GeriAl = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriAlStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSilinen = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBoxSil = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.listBoxSilinenler = new System.Windows.Forms.ListBox();
            this.btnZiple = new System.Windows.Forms.Button();
            this.contextMenuStrip1_Sil_GeriAl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKaynak
            // 
            this.btnKaynak.Location = new System.Drawing.Point(87, 64);
            this.btnKaynak.Name = "btnKaynak";
            this.btnKaynak.Size = new System.Drawing.Size(75, 23);
            this.btnKaynak.TabIndex = 0;
            this.btnKaynak.Text = "Kaynak";
            this.btnKaynak.UseVisualStyleBackColor = true;
            this.btnKaynak.Click += new System.EventHandler(this.btnKaynak_Click);
            // 
            // btnHedef
            // 
            this.btnHedef.Location = new System.Drawing.Point(87, 114);
            this.btnHedef.Name = "btnHedef";
            this.btnHedef.Size = new System.Drawing.Size(75, 23);
            this.btnHedef.TabIndex = 1;
            this.btnHedef.Text = "Hedef";
            this.btnHedef.UseVisualStyleBackColor = true;
            this.btnHedef.Click += new System.EventHandler(this.btnHedef_Click);
            // 
            // btnYedekle
            // 
            this.btnYedekle.Location = new System.Drawing.Point(409, 567);
            this.btnYedekle.Name = "btnYedekle";
            this.btnYedekle.Size = new System.Drawing.Size(118, 23);
            this.btnYedekle.TabIndex = 2;
            this.btnYedekle.Text = "Yedekle";
            this.btnYedekle.UseVisualStyleBackColor = true;
            this.btnYedekle.Click += new System.EventHandler(this.btnYedekle_Click);
            // 
            // textBoxKaynak
            // 
            this.textBoxKaynak.Location = new System.Drawing.Point(208, 64);
            this.textBoxKaynak.Name = "textBoxKaynak";
            this.textBoxKaynak.Size = new System.Drawing.Size(302, 23);
            this.textBoxKaynak.TabIndex = 3;
            // 
            // textBoxHedef
            // 
            this.textBoxHedef.Location = new System.Drawing.Point(208, 115);
            this.textBoxHedef.Name = "textBoxHedef";
            this.textBoxHedef.Size = new System.Drawing.Size(302, 23);
            this.textBoxHedef.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBoxDosyalar
            // 
            this.listBoxDosyalar.ContextMenuStrip = this.contextMenuStrip1_Sil_GeriAl;
            this.listBoxDosyalar.FormattingEnabled = true;
            this.listBoxDosyalar.ItemHeight = 15;
            this.listBoxDosyalar.Location = new System.Drawing.Point(382, 275);
            this.listBoxDosyalar.Name = "listBoxDosyalar";
            this.listBoxDosyalar.ScrollAlwaysVisible = true;
            this.listBoxDosyalar.Size = new System.Drawing.Size(297, 274);
            this.listBoxDosyalar.TabIndex = 5;
            // 
            // contextMenuStrip1_Sil_GeriAl
            // 
            this.contextMenuStrip1_Sil_GeriAl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.geriAlStripMenuItem1});
            this.contextMenuStrip1_Sil_GeriAl.Name = "contextMenuStrip1";
            this.contextMenuStrip1_Sil_GeriAl.Size = new System.Drawing.Size(110, 48);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // geriAlStripMenuItem1
            // 
            this.geriAlStripMenuItem1.Name = "geriAlStripMenuItem1";
            this.geriAlStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.geriAlStripMenuItem1.Text = "Geri Al";
            this.geriAlStripMenuItem1.Click += new System.EventHandler(this.geriAlStripMenuItem1_Click);
            // 
            // lblSilinen
            // 
            this.lblSilinen.AutoSize = true;
            this.lblSilinen.Location = new System.Drawing.Point(41, 272);
            this.lblSilinen.Name = "lblSilinen";
            this.lblSilinen.Size = new System.Drawing.Size(0, 15);
            this.lblSilinen.TabIndex = 8;
            this.lblSilinen.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(655, 567);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(24, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // textBoxSil
            // 
            this.textBoxSil.Location = new System.Drawing.Point(47, 234);
            this.textBoxSil.Name = "textBoxSil";
            this.textBoxSil.Size = new System.Drawing.Size(215, 23);
            this.textBoxSil.TabIndex = 10;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(268, 234);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // listBoxSilinenler
            // 
            this.listBoxSilinenler.FormattingEnabled = true;
            this.listBoxSilinenler.ItemHeight = 15;
            this.listBoxSilinenler.Location = new System.Drawing.Point(41, 275);
            this.listBoxSilinenler.Name = "listBoxSilinenler";
            this.listBoxSilinenler.ScrollAlwaysVisible = true;
            this.listBoxSilinenler.Size = new System.Drawing.Size(302, 274);
            this.listBoxSilinenler.TabIndex = 12;
            // 
            // btnZiple
            // 
            this.btnZiple.Location = new System.Drawing.Point(531, 567);
            this.btnZiple.Name = "btnZiple";
            this.btnZiple.Size = new System.Drawing.Size(118, 23);
            this.btnZiple.TabIndex = 13;
            this.btnZiple.Text = "Ziple";
            this.btnZiple.UseVisualStyleBackColor = true;
            this.btnZiple.Click += new System.EventHandler(this.btnZiple_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 624);
            this.Controls.Add(this.btnZiple);
            this.Controls.Add(this.listBoxSilinenler);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.textBoxSil);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblSilinen);
            this.Controls.Add(this.listBoxDosyalar);
            this.Controls.Add(this.textBoxHedef);
            this.Controls.Add(this.textBoxKaynak);
            this.Controls.Add(this.btnYedekle);
            this.Controls.Add(this.btnHedef);
            this.Controls.Add(this.btnKaynak);
            this.Name = "Form1";
            this.Text = "Dosya Yedekle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1_Sil_GeriAl.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1_Sil_GeriAl;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriAlStripMenuItem1;
        private System.Windows.Forms.Label lblSilinen;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBoxSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox listBoxSilinenler;
        private System.Windows.Forms.Button btnZiple;
    }
}

