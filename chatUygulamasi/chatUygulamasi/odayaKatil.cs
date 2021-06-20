using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chatUygulamasi
{
    public partial class odayaKatil : Form
    {
        IFirebaseClient client;
        static public string girisYapilanKullaniciAdi;
        public odayaKatil()
        {
            InitializeComponent();

            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "MAHEWWzvefDPAikuwG6AWqdx8JMdlQbNQ18Dw5sz",
                BasePath = "https://chat-uygulamasi-22-default-rtdb.firebaseio.com/"
            };
            client = new FirebaseClient(config);
        }

        private async void odayaKatilBtn_Click(object sender, EventArgs e)
        {
            FirebaseResponse sor = await client.GetAsync("Odalar/"+odaAdiTxt.Text);
            odaOlusturSinif cevap = sor.ResultAs<odaOlusturSinif>();

            if (cevap == null)
            {
                MessageBox.Show("Oda Bulunamadı.","HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(cevap.odaAdi==odaAdiTxt.Text && cevap.odaSifre == odaSifreTxt.Text)
            {
                var odaKullaniciKayit = new odaOlusturSinif
                {
                    kayitliKullanici=girisYapilanKullaniciAdi,
                };
                SetResponse response = await client.SetAsync("Oda Kullanicilar/"+odaAdiTxt.Text+"/"+girisYapilanKullaniciAdi, odaKullaniciKayit);

                odaMesajlasma.odaAdi = odaAdiTxt.Text;
                Form odaMesajlasmaForm = new odaMesajlasma();
                this.Hide();
                odaMesajlasmaForm.Show();
            }
            else
            {
                MessageBox.Show("Oda adı veya şifre hatalı.", "HATA", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void odaAdiTxt_MouseEnter(object sender, EventArgs e)
        {
            if (odaAdiTxt.Text == "Oda Adı Giriniz")
            {
                odaAdiTxt.Text = "";
            }
        }

        private void odaSifreTxt_MouseEnter(object sender, EventArgs e)
        {
            if (odaSifreTxt.Text == "Şifre Giriniz")
            {
                odaSifreTxt.Text = "";
                odaSifreTxt.isPassword = true;
            }
        }
    }
}
