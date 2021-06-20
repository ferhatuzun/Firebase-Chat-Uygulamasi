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
    public partial class ozelMesaj : Form
    {
        IFirebaseClient client;
        static public string girisYapilanKullaniciAdi;
        public ozelMesaj()
        {
            InitializeComponent();
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "MAHEWWzvefDPAikuwG6AWqdx8JMdlQbNQ18Dw5sz",
                BasePath = "https://chat-uygulamasi-22-default-rtdb.firebaseio.com/"
            };
            client = new FirebaseClient(config);
        }

        private async void ozelMesaj_Load(object sender, EventArgs e)
        {
            
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
            kayitliKullanicilarList.SelectedIndex = 0;
            //mesajları listbox'a yükleme



           
        }

        private  void kayitliKullanicilarList_SelectedValueChanged(object sender, EventArgs e)
        {
            VeriCek();
           
        }
        private async void VeriCek() {
            mesajlarList.Items.Clear();
            FirebaseResponse mesajCek = await client.GetAsync("Ozel Mesajlar");
            var mesajCekGelenKayitlar = JsonConvert.DeserializeObject<Dictionary<string, ozelMesajSinif>>(mesajCek.Body);

            if (mesajCekGelenKayitlar != null)
            {
                foreach (var item in mesajCekGelenKayitlar)
                {
                    ozelMesajSinif mesajlar = item.Value;

                    if (girisYapilanKullaniciAdi == mesajlar.gonderen && kayitliKullanicilarList.SelectedItem.ToString() == mesajlar.alici || girisYapilanKullaniciAdi == mesajlar.alici && kayitliKullanicilarList.SelectedItem.ToString() == mesajlar.gonderen)
                    {
                        mesajlarList.Items.Add(mesajlar.gonderen + " ( " + mesajlar.tarih + " ) --> " + mesajlar.mesaj);
                    }
                }
            }
        }
        private async void mesajGonderBtn_Click(object sender, EventArgs e)
        {
            var yeniMesaj = new ozelMesajSinif
            {
                gonderen = girisYapilanKullaniciAdi,
                alici = kayitliKullanicilarList.SelectedItem.ToString(),
                tarih = DateTime.Now.ToString(),
                mesaj = mesajTxt.Text
            };
            PushResponse response = await client.PushAsync("Ozel Mesajlar", yeniMesaj);
            VeriCek();
            mesajTxt.Text = "";
        }

       
    }
}
