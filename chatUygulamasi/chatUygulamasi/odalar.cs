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
    public partial class odalar : Form
    {
        IFirebaseClient client;
        static public string girisYapilanKullaniciAdi;
        public odalar()
        {
            InitializeComponent();
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "MAHEWWzvefDPAikuwG6AWqdx8JMdlQbNQ18Dw5sz",
                BasePath = "https://chat-uygulamasi-22-default-rtdb.firebaseio.com/"
            };
            client = new FirebaseClient(config);
        }

        private async void odalar_Load(object sender, EventArgs e)
        {
            //odaların listboxa yazırılması
            FirebaseResponse odaCek = await client.GetAsync("Odalar");
            var odaCekAlt = odaCek.Body;
            var odaCekGelenKayitlar = JsonConvert.DeserializeObject<Dictionary<string, odaOlusturSinif>>(odaCekAlt);


            foreach (var item in odaCekGelenKayitlar)
            {
                odaOlusturSinif odalar = item.Value;
                if (odalar.odaGizlilik == "Açık")
                {
                    odalarList.Items.Add(odalar.odaAdi);
                }
            }
        }

        private async void odaKatilBtn_Click(object sender, EventArgs e)
        {
            var odaKullaniciKayit = new odaOlusturSinif
            {
                kayitliKullanici = girisYapilanKullaniciAdi,
            };
            SetResponse response = await client.SetAsync("Oda Kullanicilar/" + odalarList.SelectedItem.ToString() + "/" + girisYapilanKullaniciAdi, odaKullaniciKayit);

            odaMesajlasma.odaAdi = odalarList.SelectedItem.ToString();
            Form odaMesajlasmaForm = new odaMesajlasma();
            
            odaMesajlasmaForm.Show();
            this.Hide();
        }

        private void btnBackMain_Click(object sender, EventArgs e)
        {
            anamenu anaMenu = new anamenu();
            anaMenu.Show();
            this.Hide();
        }
    }
}
