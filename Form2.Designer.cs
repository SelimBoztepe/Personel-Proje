
namespace personelkayit
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtGirisAd = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGirisSifre = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // txtGirisAd
            // 
            this.txtGirisAd.Location = new System.Drawing.Point(155, 69);
            this.txtGirisAd.Name = "txtGirisAd";
            this.txtGirisAd.Size = new System.Drawing.Size(122, 20);
            this.txtGirisAd.TabIndex = 2;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(156, 190);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(106, 39);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şifre:";
            // 
            // txtGirisSifre
            // 
            this.txtGirisSifre.Location = new System.Drawing.Point(156, 121);
            this.txtGirisSifre.Name = "txtGirisSifre";
            this.txtGirisSifre.PasswordChar = '*';
            this.txtGirisSifre.Size = new System.Drawing.Size(121, 20);
            this.txtGirisSifre.TabIndex = 6;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(156, 148);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(87, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifremi Unuttum?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtGirisSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtGirisAd);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Giris Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGirisAd;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGirisSifre;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}