using BigData.Entities;
using BigData.Operasyon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigData
{
    public partial class Form1 : Form
    {
        Image Img;
        BusinessLogicLayer BLL;
        public Form1()
        {
            InitializeComponent();
            BLL = new BusinessLogicLayer();
            List<Entities.Kisi> Kisiler = BLL.KisilerListe();
            cmbKisiListesi.DataSource = Kisiler;
        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            OFD.ShowDialog();
            Img = Image.FromFile(OFD.FileName);
            ptbYeniKayitEkle.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbYeniKayitEkle.Image = Img;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            MemoryStream mem = new MemoryStream();
            Img.Save(mem, System.Drawing.Imaging.ImageFormat.Jpeg);
            //BusinessLogicLayer BLL = new BusinessLogicLayer(); üstte class seviyesinde yazdığım için burada buna gerek kalmadı.
            int ReturnValue = BLL.KayitEkle(txtIsim.Text, txtSoyisim.Text, txtEposta.Text, txtTel.Text, mem.ToArray());
            if (ReturnValue > 0)
            {
                MessageBox.Show("Başarılı");
            }
            else
            {
                MessageBox.Show("Başarısız");
            }
        }

        private void cmbKisiListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kisi k = (Kisi)((ComboBox)sender).SelectedItem;
            k = BLL.KisiDetayGetir(k.ID);
            txtIsimKayitGoruntuleme.Text = k.Isim;
            txtSoyisimKayitGoruntuleme.Text = k.Soyisim;
            txtTelKayitGoruntuleme.Text = k.Tel;
            txtEpostaKayitGoruntuleme.Text = k.EmailAdres;

            MemoryStream mem = new MemoryStream(k.Resim);
            Image Img = Image.FromStream(mem);
            ptbKayitGoruntuleme.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbKayitGoruntuleme.Image = Img;
        }
    }
}
