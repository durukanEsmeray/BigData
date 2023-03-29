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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            OFD.ShowDialog();
            Img = Image.FromFile(OFD.FileName);
            ptbYeniKayitEkle.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbYeniKayitEkle.Image= Img;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            MemoryStream mem = new MemoryStream();
            Img.Save(mem, System.Drawing.Imaging.ImageFormat.Jpeg);
            BusinessLogicLayer BLL = new BusinessLogicLayer();
            int ReturnValue = BLL.KayitEkle(txtIsim.Text, txtSoyisim.Text, txtEposta.Text, txtTel.Text, mem.ToArray());
            if(ReturnValue > 0)
            {
                MessageBox.Show("Başarılı");
            }
            else
            {
                MessageBox.Show("Başarısız");
            }
        }
    }
}
