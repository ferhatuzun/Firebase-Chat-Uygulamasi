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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IFirebaseClient client;
        private void Form1_Load(object sender, EventArgs e)
        {
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "MAHEWWzvefDPAikuwG6AWqdx8JMdlQbNQ18Dw5sz",
                BasePath = "https://chat-uygulamasi-22-default-rtdb.firebaseio.com/"
            };
            client = new FirebaseClient(config);
        }


        //text box temizlme
        private void gKullaniciAdiTxt_MouseEnter(object sender, EventArgs e)
        {
            if(gKullaniciAdiTxt.Text=="Kullanıcı Adı Giriniz")
            {
                gKullaniciAdiTxt.Text = "";
            }
        }

        private void gSifreTxt_MouseEnter(object sender, EventArgs e)
        {
            if (gSifreTxt.Text == "Şifre Giriniz")
            {
                gSifreTxt.Text = "";
                gSifreTxt.isPassword = true;
            }
        }


        //

        private async void katilBtn_Click(object sender, EventArgs e)
        {
            FirebaseResponse kayitliKullaniciSor = await client.GetAsync("Kullanicilar/"+gKullaniciAdiTxt.Text);
            Kullanicilar kayitliKullaniciSorgula = kayitliKullaniciSor.ResultAs<Kullanicilar>();


            //kullanıcı adı sorgulaması
            if (kayitliKullaniciSorgula == null)
            {
                if (gKullaniciAdiTxt.Text != "" && gSifreTxt.Text != "")
                {
                    var yeniKullanici = new Kullanicilar
                    {
                        kullaniciAdi = gKullaniciAdiTxt.Text,
                        sifre = gSifreTxt.Text

                    };
                    SetResponse yeniKullaniciKayit = await client.SetAsync("Kullanicilar/" + gKullaniciAdiTxt.Text, yeniKullanici);

                    genelChat.girisYapilanKullaniciAdi = gKullaniciAdiTxt.Text;
                    anamenu.girisYapilanKullaniciAdi = gKullaniciAdiTxt.Text;
                    odaOlustur.girisYapilanKullaniciAdi = gKullaniciAdiTxt.Text;
                    odaMesajlasma.girisYapilanKullaniciAdi = gKullaniciAdiTxt.Text;
                    odayaKatil.girisYapilanKullaniciAdi = gKullaniciAdiTxt.Text;
                    odalar.girisYapilanKullaniciAdi = gKullaniciAdiTxt.Text;
                    ozelMesaj.girisYapilanKullaniciAdi = gKullaniciAdiTxt.Text;
                    Form anamenuform = new anamenu();
                    anamenuform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı yada şifre boş bırakılamaz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
            else
            {

                if(gKullaniciAdiTxt.Text==kayitliKullaniciSorgula.kullaniciAdi && gSifreTxt.Text == kayitliKullaniciSorgula.sifre)
                {

                    genelChat.girisYapilanKullaniciAdi = gKullaniciAdiTxt.Text;
                    anamenu.girisYapilanKullaniciAdi = gKullaniciAdiTxt.Text;
                    odaOlustur.girisYapilanKullaniciAdi = gKullaniciAdiTxt.Text;
                    odaMesajlasma.girisYapilanKullaniciAdi = gKullaniciAdiTxt.Text;
                    odayaKatil.girisYapilanKullaniciAdi = gKullaniciAdiTxt.Text;
                    odalar.girisYapilanKullaniciAdi = gKullaniciAdiTxt.Text;
                    ozelMesaj.girisYapilanKullaniciAdi = gKullaniciAdiTxt.Text;
                    Form anamenuform = new anamenu();
                    anamenuform.Show();
                    this.Hide();
                    
                }
                else 
                {
                    MessageBox.Show("Girmiş olduğunun şifre yanlış, lütfen şifrenizi kontrol ediniz. İlk defa giriş yapıyorsanız farklı bir kullanıcı adı giriniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }


        }


    }
}
