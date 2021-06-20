using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
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
    public partial class odaOlustur : Form
    {
        IFirebaseClient client;
        static public string girisYapilanKullaniciAdi;
        public odaOlustur()
        {
            InitializeComponent();
            
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "MAHEWWzvefDPAikuwG6AWqdx8JMdlQbNQ18Dw5sz",
                BasePath = "https://chat-uygulamasi-22-default-rtdb.firebaseio.com/"
            };
            client = new FirebaseClient(config);

            odaGizlilikSelect.Items.Add("Açık");
            odaGizlilikSelect.Items.Add("Kapalı");
        }

        private void odaAdiBtn_MouseEnter(object sender, EventArgs e)
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

        private async void odaOlusturBtn_Click(object sender, EventArgs e)
        {
            FirebaseResponse sor = await client.GetAsync("Odalar/"+odaAdiTxt.Text);
            odaOlusturSinif cevap = sor.ResultAs<odaOlusturSinif>();

            if (cevap == null)
            {
                if (odaAdiTxt.Text != "" && odaSifreTxt.Text != "")
                {

                    var odaEkle = new odaOlusturSinif
                    {
                        odaAdi = odaAdiTxt.Text,
                        odaSifre = odaSifreTxt.Text,
                        odaSahibi = girisYapilanKullaniciAdi,
                        odaGizlilik = odaGizlilikSelect.SelectedItem.ToString(),

                    };
                    SetResponse response = await client.SetAsync("Odalar/" + odaAdiTxt.Text, odaEkle);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Oda adı ve şifre boş bırakılamaz.","HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Oda adı kullanılmaktadır.","HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
                
            
                
            

        }
    }
}
