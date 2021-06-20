
namespace chatUygulamasi
{
    partial class odayaKatil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(odayaKatil));
            this.odayaKatilBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.odaSifreTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.odaAdiTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // odayaKatilBtn
            // 
            this.odayaKatilBtn.ActiveBorderThickness = 1;
            this.odayaKatilBtn.ActiveCornerRadius = 20;
            this.odayaKatilBtn.ActiveFillColor = System.Drawing.Color.Black;
            this.odayaKatilBtn.ActiveForecolor = System.Drawing.Color.White;
            this.odayaKatilBtn.ActiveLineColor = System.Drawing.Color.White;
            this.odayaKatilBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.odayaKatilBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("odayaKatilBtn.BackgroundImage")));
            this.odayaKatilBtn.ButtonText = "Odaya Katıl";
            this.odayaKatilBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.odayaKatilBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odayaKatilBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.odayaKatilBtn.IdleBorderThickness = 1;
            this.odayaKatilBtn.IdleCornerRadius = 20;
            this.odayaKatilBtn.IdleFillColor = System.Drawing.Color.Lime;
            this.odayaKatilBtn.IdleForecolor = System.Drawing.Color.Black;
            this.odayaKatilBtn.IdleLineColor = System.Drawing.Color.Black;
            this.odayaKatilBtn.Location = new System.Drawing.Point(71, 249);
            this.odayaKatilBtn.Margin = new System.Windows.Forms.Padding(5);
            this.odayaKatilBtn.Name = "odayaKatilBtn";
            this.odayaKatilBtn.Size = new System.Drawing.Size(253, 56);
            this.odayaKatilBtn.TabIndex = 17;
            this.odayaKatilBtn.TabStop = false;
            this.odayaKatilBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.odayaKatilBtn.Click += new System.EventHandler(this.odayaKatilBtn_Click);
            // 
            // odaSifreTxt
            // 
            this.odaSifreTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.odaSifreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.odaSifreTxt.ForeColor = System.Drawing.Color.White;
            this.odaSifreTxt.HintForeColor = System.Drawing.Color.White;
            this.odaSifreTxt.HintText = "";
            this.odaSifreTxt.isPassword = false;
            this.odaSifreTxt.LineFocusedColor = System.Drawing.Color.White;
            this.odaSifreTxt.LineIdleColor = System.Drawing.Color.White;
            this.odaSifreTxt.LineMouseHoverColor = System.Drawing.Color.White;
            this.odaSifreTxt.LineThickness = 3;
            this.odaSifreTxt.Location = new System.Drawing.Point(71, 181);
            this.odaSifreTxt.Margin = new System.Windows.Forms.Padding(4);
            this.odaSifreTxt.Name = "odaSifreTxt";
            this.odaSifreTxt.Size = new System.Drawing.Size(253, 33);
            this.odaSifreTxt.TabIndex = 16;
            this.odaSifreTxt.TabStop = false;
            this.odaSifreTxt.Text = "Şifre Giriniz";
            this.odaSifreTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.odaSifreTxt.MouseEnter += new System.EventHandler(this.odaSifreTxt_MouseEnter);
            // 
            // odaAdiTxt
            // 
            this.odaAdiTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.odaAdiTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.odaAdiTxt.ForeColor = System.Drawing.Color.White;
            this.odaAdiTxt.HintForeColor = System.Drawing.Color.White;
            this.odaAdiTxt.HintText = "";
            this.odaAdiTxt.isPassword = false;
            this.odaAdiTxt.LineFocusedColor = System.Drawing.Color.White;
            this.odaAdiTxt.LineIdleColor = System.Drawing.Color.White;
            this.odaAdiTxt.LineMouseHoverColor = System.Drawing.Color.White;
            this.odaAdiTxt.LineThickness = 3;
            this.odaAdiTxt.Location = new System.Drawing.Point(71, 130);
            this.odaAdiTxt.Margin = new System.Windows.Forms.Padding(4);
            this.odaAdiTxt.Name = "odaAdiTxt";
            this.odaAdiTxt.Size = new System.Drawing.Size(253, 33);
            this.odaAdiTxt.TabIndex = 15;
            this.odaAdiTxt.TabStop = false;
            this.odaAdiTxt.Text = "Oda Adı Giriniz";
            this.odaAdiTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.odaAdiTxt.MouseEnter += new System.EventHandler(this.odaAdiTxt_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(70, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 55);
            this.label1.TabIndex = 14;
            this.label1.Text = "Odaya Katil";
            // 
            // odayaKatil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(395, 367);
            this.Controls.Add(this.odayaKatilBtn);
            this.Controls.Add(this.odaSifreTxt);
            this.Controls.Add(this.odaAdiTxt);
            this.Controls.Add(this.label1);
            this.Name = "odayaKatil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "odayaKatil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 odayaKatilBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox odaSifreTxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox odaAdiTxt;
        private System.Windows.Forms.Label label1;
    }
}