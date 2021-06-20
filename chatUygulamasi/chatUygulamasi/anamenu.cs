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
    public partial class anamenu : Form
    {
        public anamenu()
        {
            InitializeComponent();
        }
        static public string girisYapilanKullaniciAdi;
        private void genelChatBtn_Click(object sender, EventArgs e)
        {
            Form genelChat = new genelChat();
            genelChat.Show();
            this.Hide();
        }

        private void odaOlusturBtn_Click(object sender, EventArgs e)
        {
            Form odaOlustur = new odaOlustur();
            odaOlustur.Show();

        }

        private void odayaKatilBtn_Click(object sender, EventArgs e)
        {
            Form odayaKatil = new odayaKatil();
            odayaKatil.Show();
        }

        private void odalarBtn_Click(object sender, EventArgs e)
        {
            Form odalar = new odalar();
            odalar.Show();
            this.Hide();
        }

        private void ozelMesajBtn_Click(object sender, EventArgs e)
        {
            Form ozelMesaj = new ozelMesaj();
            ozelMesaj.Show();
        }
    }
}
