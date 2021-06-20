
namespace chatUygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.gKullaniciAdiTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gSifreTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.katilBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(61, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chat - Katıl";
            // 
            // gKullaniciAdiTxt
            // 
            this.gKullaniciAdiTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gKullaniciAdiTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.gKullaniciAdiTxt.ForeColor = System.Drawing.Color.White;
            this.gKullaniciAdiTxt.HintForeColor = System.Drawing.Color.White;
            this.gKullaniciAdiTxt.HintText = "";
            this.gKullaniciAdiTxt.isPassword = false;
            this.gKullaniciAdiTxt.LineFocusedColor = System.Drawing.Color.White;
            this.gKullaniciAdiTxt.LineIdleColor = System.Drawing.Color.White;
            this.gKullaniciAdiTxt.LineMouseHoverColor = System.Drawing.Color.White;
            this.gKullaniciAdiTxt.LineThickness = 3;
            this.gKullaniciAdiTxt.Location = new System.Drawing.Point(71, 147);
            this.gKullaniciAdiTxt.Margin = new System.Windows.Forms.Padding(4);
            this.gKullaniciAdiTxt.Name = "gKullaniciAdiTxt";
            this.gKullaniciAdiTxt.Size = new System.Drawing.Size(253, 33);
            this.gKullaniciAdiTxt.TabIndex = 10;
            this.gKullaniciAdiTxt.TabStop = false;
            this.gKullaniciAdiTxt.Text = "Kullanıcı Adı Giriniz";
            this.gKullaniciAdiTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gKullaniciAdiTxt.MouseEnter += new System.EventHandler(this.gKullaniciAdiTxt_MouseEnter);
            // 
            // gSifreTxt
            // 
            this.gSifreTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gSifreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.gSifreTxt.ForeColor = System.Drawing.Color.White;
            this.gSifreTxt.HintForeColor = System.Drawing.Color.White;
            this.gSifreTxt.HintText = "";
            this.gSifreTxt.isPassword = false;
            this.gSifreTxt.LineFocusedColor = System.Drawing.Color.White;
            this.gSifreTxt.LineIdleColor = System.Drawing.Color.White;
            this.gSifreTxt.LineMouseHoverColor = System.Drawing.Color.White;
            this.gSifreTxt.LineThickness = 3;
            this.gSifreTxt.Location = new System.Drawing.Point(71, 218);
            this.gSifreTxt.Margin = new System.Windows.Forms.Padding(4);
            this.gSifreTxt.Name = "gSifreTxt";
            this.gSifreTxt.Size = new System.Drawing.Size(253, 33);
            this.gSifreTxt.TabIndex = 11;
            this.gSifreTxt.TabStop = false;
            this.gSifreTxt.Text = "Şifre Giriniz";
            this.gSifreTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gSifreTxt.MouseEnter += new System.EventHandler(this.gSifreTxt_MouseEnter);
            // 
            // katilBtn
            // 
            this.katilBtn.ActiveBorderThickness = 1;
            this.katilBtn.ActiveCornerRadius = 20;
            this.katilBtn.ActiveFillColor = System.Drawing.Color.Black;
            this.katilBtn.ActiveForecolor = System.Drawing.Color.White;
            this.katilBtn.ActiveLineColor = System.Drawing.Color.White;
            this.katilBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.katilBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("katilBtn.BackgroundImage")));
            this.katilBtn.ButtonText = "Katıl";
            this.katilBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.katilBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.katilBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.katilBtn.IdleBorderThickness = 1;
            this.katilBtn.IdleCornerRadius = 20;
            this.katilBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.katilBtn.IdleForecolor = System.Drawing.Color.White;
            this.katilBtn.IdleLineColor = System.Drawing.Color.Black;
            this.katilBtn.Location = new System.Drawing.Point(71, 277);
            this.katilBtn.Margin = new System.Windows.Forms.Padding(5);
            this.katilBtn.Name = "katilBtn";
            this.katilBtn.Size = new System.Drawing.Size(253, 56);
            this.katilBtn.TabIndex = 3;
            this.katilBtn.TabStop = false;
            this.katilBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.katilBtn.Click += new System.EventHandler(this.katilBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(386, 414);
            this.Controls.Add(this.katilBtn);
            this.Controls.Add(this.gSifreTxt);
            this.Controls.Add(this.gKullaniciAdiTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat - Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox gKullaniciAdiTxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox gSifreTxt;
        private Bunifu.Framework.UI.BunifuThinButton2 katilBtn;
    }
}

