
namespace chatUygulamasi
{
    partial class ozelMesaj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ozelMesaj));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.girisYapanKullaniciAdiLabel = new System.Windows.Forms.Label();
            this.mesajTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.mesajGonderBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.mesajlarList = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kayitliKullanicilarList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.girisYapanKullaniciAdiLabel);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(26, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 234);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Bilgileri";
            // 
            // girisYapanKullaniciAdiLabel
            // 
            this.girisYapanKullaniciAdiLabel.AutoSize = true;
            this.girisYapanKullaniciAdiLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.girisYapanKullaniciAdiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisYapanKullaniciAdiLabel.ForeColor = System.Drawing.Color.White;
            this.girisYapanKullaniciAdiLabel.Location = new System.Drawing.Point(3, 206);
            this.girisYapanKullaniciAdiLabel.Name = "girisYapanKullaniciAdiLabel";
            this.girisYapanKullaniciAdiLabel.Size = new System.Drawing.Size(93, 25);
            this.girisYapanKullaniciAdiLabel.TabIndex = 1;
            this.girisYapanKullaniciAdiLabel.Text = "Kullanıcı";
            // 
            // mesajTxt
            // 
            this.mesajTxt.BorderColorFocused = System.Drawing.Color.Gray;
            this.mesajTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mesajTxt.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.mesajTxt.BorderThickness = 3;
            this.mesajTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mesajTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mesajTxt.ForeColor = System.Drawing.Color.White;
            this.mesajTxt.isPassword = false;
            this.mesajTxt.Location = new System.Drawing.Point(359, 575);
            this.mesajTxt.Margin = new System.Windows.Forms.Padding(4);
            this.mesajTxt.Name = "mesajTxt";
            this.mesajTxt.Size = new System.Drawing.Size(851, 150);
            this.mesajTxt.TabIndex = 14;
            this.mesajTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // mesajGonderBtn
            // 
            this.mesajGonderBtn.ActiveBorderThickness = 1;
            this.mesajGonderBtn.ActiveCornerRadius = 20;
            this.mesajGonderBtn.ActiveFillColor = System.Drawing.Color.Transparent;
            this.mesajGonderBtn.ActiveForecolor = System.Drawing.Color.White;
            this.mesajGonderBtn.ActiveLineColor = System.Drawing.Color.White;
            this.mesajGonderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.mesajGonderBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mesajGonderBtn.BackgroundImage")));
            this.mesajGonderBtn.ButtonText = "Gönder";
            this.mesajGonderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mesajGonderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mesajGonderBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.mesajGonderBtn.IdleBorderThickness = 1;
            this.mesajGonderBtn.IdleCornerRadius = 20;
            this.mesajGonderBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.mesajGonderBtn.IdleForecolor = System.Drawing.Color.DarkGray;
            this.mesajGonderBtn.IdleLineColor = System.Drawing.Color.DarkGray;
            this.mesajGonderBtn.Location = new System.Drawing.Point(1229, 575);
            this.mesajGonderBtn.Margin = new System.Windows.Forms.Padding(5);
            this.mesajGonderBtn.Name = "mesajGonderBtn";
            this.mesajGonderBtn.Size = new System.Drawing.Size(152, 150);
            this.mesajGonderBtn.TabIndex = 13;
            this.mesajGonderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mesajGonderBtn.Click += new System.EventHandler(this.mesajGonderBtn_Click);
            // 
            // mesajlarList
            // 
            this.mesajlarList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.mesajlarList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mesajlarList.ForeColor = System.Drawing.Color.White;
            this.mesajlarList.FormattingEnabled = true;
            this.mesajlarList.ItemHeight = 24;
            this.mesajlarList.Location = new System.Drawing.Point(359, 12);
            this.mesajlarList.Name = "mesajlarList";
            this.mesajlarList.Size = new System.Drawing.Size(1022, 532);
            this.mesajlarList.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kayitliKullanicilarList);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(26, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 474);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıtlı Kullanıcılar";
            // 
            // kayitliKullanicilarList
            // 
            this.kayitliKullanicilarList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.kayitliKullanicilarList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kayitliKullanicilarList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitliKullanicilarList.ForeColor = System.Drawing.Color.White;
            this.kayitliKullanicilarList.FormattingEnabled = true;
            this.kayitliKullanicilarList.ItemHeight = 25;
            this.kayitliKullanicilarList.Location = new System.Drawing.Point(6, 30);
            this.kayitliKullanicilarList.Name = "kayitliKullanicilarList";
            this.kayitliKullanicilarList.Size = new System.Drawing.Size(236, 450);
            this.kayitliKullanicilarList.TabIndex = 0;
            this.kayitliKullanicilarList.SelectedValueChanged += new System.EventHandler(this.kayitliKullanicilarList_SelectedValueChanged);
            // 
            // ozelMesaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1406, 742);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mesajTxt);
            this.Controls.Add(this.mesajGonderBtn);
            this.Controls.Add(this.mesajlarList);
            this.Controls.Add(this.groupBox2);
            this.Name = "ozelMesaj";
            this.Text = "ozelMesaj";
            this.Load += new System.EventHandler(this.ozelMesaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label girisYapanKullaniciAdiLabel;
        private Bunifu.Framework.UI.BunifuMetroTextbox mesajTxt;
        private Bunifu.Framework.UI.BunifuThinButton2 mesajGonderBtn;
        private System.Windows.Forms.ListBox mesajlarList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox kayitliKullanicilarList;
    }
}