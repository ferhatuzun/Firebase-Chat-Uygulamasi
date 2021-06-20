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
    public partial class odaMesajlasma : Form
    {
        static public string girisYapilanKullaniciAdi;
        static public string odaAdi;
        IFirebaseClient client;
        public odaMesajlasma()
        {
            InitializeComponent();
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "MAHEWWzvefDPAikuwG6AWqdx8JMdlQbNQ18Dw5sz",
                BasePath = "https://chat-uygulamasi-22-default-rtdb.firebaseio.com/"
            };
            client = new FirebaseClient(config);
            girisYapanKullaniciAdiLabel.Text = girisYapilanKullaniciAdi;
        }
        private async void odaMesajlasma_Load(object sender, EventArgs e)
        {
            //kayıtlı kullanıcıların listbox'a yazırılması
            FirebaseResponse kullaniciCek = await client.GetAsync("Oda Kullanicilar/"+odaAdi);
            var kullaniciCekAlt = kullaniciCek.Body;
            var kullaniciCekGelenKayitlar = JsonConvert.DeserializeObject<Dictionary<string, odaOlusturSinif>>(kullaniciCekAlt);


            foreach (var item in kullaniciCekGelenKayitlar)
            {
                odaOlusturSinif kullanicilar = item.Value;
                if (kullanicilar.kayitliKullanici == girisYapilanKullaniciAdi)
                {
                    continue;
                }
                kayitliKullanicilarList.Items.Add(kullanicilar.kayitliKullanici);
            }
            //mesajları listbox'a yükleme

            timer1.Start();
            FirebaseResponse mesajCek = await client.GetAsync("Oda Mesajlari/"+odaAdi);
            var mesajCekAlt = mesajCek.Body;
            var mesajCekGelenKayitlar = JsonConvert.DeserializeObject<Dictionary<string, Mesajlar>>(mesajCekAlt);

            if (mesajCekGelenKayitlar != null)
            {
                foreach (var item in mesajCekGelenKayitlar)
                {
                    Mesajlar mesajlar = item.Value;
                    mesajlarList.Items.Add(mesajlar.gonderen + " ( " + mesajlar.tarih + " ) --> " + mesajlar.mesaj);
                }

                mesajlarList.SelectedIndex = mesajlarList.Items.Count - 1;
            }
        }
        private async void mesajGonderBtn_Click(object sender, EventArgs e)
        {
            if (mesajTxt.Text != "")
            {
                var yeniMesaj = new Mesajlar
                {
                    gonderen = girisYapilanKullaniciAdi,
                    mesaj = mesajTxt.Text,
                    tarih = DateTime.Now.ToString(),
                };
                PushResponse response = await client.PushAsync("Oda Mesajlari/" + odaAdi, yeniMesaj);
                mesajTxt.Text = "";
            }
            else
            {
                MessageBox.Show("Boş mesaj Gönderilemez.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            FirebaseResponse mesajCek = await client.GetAsync("Oda Mesajlari/"+odaAdi);
            var mesajCekAlt = mesajCek.Body;
            var mesajCekGelenKayitlar = JsonConvert.DeserializeObject<Dictionary<string, Mesajlar>>(mesajCekAlt);

            if (mesajCekGelenKayitlar != null && mesajCekGelenKayitlar.Count > mesajlarList.Items.Count)
            {
                Mesajlar m = mesajCekGelenKayitlar.Last().Value;
                mesajlarList.Items.Add(m.gonderen + " (" + m.tarih + ") " + " --> " + m.mesaj);
                //mesajlarList.SelectedIndex = mesajCekGelenKayitlar.Count - 1;

            }
        }

        private void odaMesajlasma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
