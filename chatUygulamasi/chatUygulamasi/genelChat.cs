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
    public partial class genelChat : Form
    {
        public genelChat()
        {
            InitializeComponent();
        }
        IFirebaseClient client;
        //form1 den kullanıcı adı çekme
        static public string girisYapilanKullaniciAdi;

        private async void Form2_Load(object sender, EventArgs e)
        {
           
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "MAHEWWzvefDPAikuwG6AWqdx8JMdlQbNQ18Dw5sz",
                BasePath = "https://chat-uygulamasi-22-default-rtdb.firebaseio.com/"
            };
            client = new FirebaseClient(config);

            //giris yapılan hesabın kullanıcı adını yazdırma
            girisYapanKullaniciAdiLabel.Text = girisYapilanKullaniciAdi;

            //kayıtlı kullanıcıların listbox'a yazırılması
            FirebaseResponse kullaniciCek = await client.GetAsync("Kullanicilar");
            var kullaniciCekAlt = kullaniciCek.Body;
            var kullaniciCekGelenKayitlar = JsonConvert.DeserializeObject<Dictionary<string, Kullanicilar>>(kullaniciCekAlt);

            
            foreach (var item in kullaniciCekGelenKayitlar)
            {
                Kullanicilar kullanicilar = item.Value;
                if (kullanicilar.kullaniciAdi == girisYapilanKullaniciAdi)
                {
                    continue;
                }
                kayitliKullanicilarList.Items.Add(kullanicilar.kullaniciAdi);
            }

            //mesajları listbox'a yükleme

            timer1.Start();
            FirebaseResponse mesajCek = await client.GetAsync("Mesajlar");
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
            var yeniMesaj = new Mesajlar
            {
                gonderen = girisYapilanKullaniciAdi,
                mesaj = mesajTxt.Text,
                tarih = DateTime.Now.ToString()
            };
            PushResponse yeniMesajEkle = await client.PushAsync("Mesajlar/", yeniMesaj);
            mesajTxt.Text = "";
        }

        //yeni mesajları listbox'a ekleme
        private async void timer1_Tick(object sender, EventArgs e)
        {
            FirebaseResponse mesajCek = await client.GetAsync("Mesajlar");
            var mesajCekAlt = mesajCek.Body;
            var mesajCekGelenKayitlar = JsonConvert.DeserializeObject<Dictionary<string, Mesajlar>>(mesajCekAlt);

            if (mesajCekGelenKayitlar!= null &&  mesajCekGelenKayitlar.Count> mesajlarList.Items.Count)
            {
                Mesajlar m = mesajCekGelenKayitlar.Last().Value;
                mesajlarList.Items.Add(m.gonderen + " (" + m.tarih + ") " + " --> " + m.mesaj);
                mesajlarList.SelectedIndex = mesajCekGelenKayitlar.Count - 1;
                
            }


        }



    }
}
