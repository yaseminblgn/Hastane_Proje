﻿
namespace Hastane_Proje
{
    partial class FrmHastaKayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayit));
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.msktelefon = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbcinsiyet = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnkayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(201, 105);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(218, 36);
            this.txtsoyad.TabIndex = 2;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(201, 177);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(218, 36);
            this.msktc.TabIndex = 3;
            this.msktc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "TC Kimlik No:";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(201, 33);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(218, 36);
            this.txtad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Soyad:";
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(201, 304);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(218, 36);
            this.txtsifre.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Telefon:";
            // 
            // msktelefon
            // 
            this.msktelefon.Location = new System.Drawing.Point(201, 238);
            this.msktelefon.Mask = "(999) 000-0000";
            this.msktelefon.Name = "msktelefon";
            this.msktelefon.Size = new System.Drawing.Size(218, 36);
            this.msktelefon.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 29);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cinsiyet:";
            // 
            // cmbcinsiyet
            // 
            this.cmbcinsiyet.FormattingEnabled = true;
            this.cmbcinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cmbcinsiyet.Location = new System.Drawing.Point(201, 368);
            this.cmbcinsiyet.Name = "cmbcinsiyet";
            this.cmbcinsiyet.Size = new System.Drawing.Size(218, 36);
            this.cmbcinsiyet.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "Şifre:";
            // 
            // btnkayit
            // 
            this.btnkayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnkayit.Location = new System.Drawing.Point(224, 420);
            this.btnkayit.Name = "btnkayit";
            this.btnkayit.Size = new System.Drawing.Size(166, 55);
            this.btnkayit.TabIndex = 20;
            this.btnkayit.Text = "Kayıt Yap";
            this.btnkayit.UseVisualStyleBackColor = false;
            this.btnkayit.Click += new System.EventHandler(this.btnkayit_Click);
            // 
            // FrmHastaKayit
            // 
            this.AcceptButton = this.btnkayit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(512, 508);
            this.Controls.Add(this.btnkayit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbcinsiyet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.msktelefon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaKayit";
            this.Text = "Hasta Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox msktelefon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbcinsiyet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnkayit;
    }
}