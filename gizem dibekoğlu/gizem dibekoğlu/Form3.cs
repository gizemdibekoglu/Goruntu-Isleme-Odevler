using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
namespace gizem_dibekoğlu
{
    public partial class Form3 : Form
    {
        Bitmap ilk, son;
        public Form3()
        {
            InitializeComponent();
        }

        private void dosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kapaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Görüntüler|*.jpg;*.png";
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                ilk = new Bitmap(openFileDialog1.FileName);
                ilkBox1.Image = ilk;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yuk = ilk.Height;
            int yatay = ilk.Width;
            son = new Bitmap(yatay, yuk);
            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < yatay; x++)
                {
                    Color normalrenk = ilk.GetPixel(x, y);
                    double yeniRenk = ((normalrenk.R * 0.2125) + (normalrenk.G * 0.7154) + (normalrenk.B * 0.072));
                    int bitenRenk = Convert.ToInt16(yeniRenk);
                    Color bitisRenk = Color.FromArgb(bitenRenk, bitenRenk, bitenRenk);



                    son.SetPixel(x, y, bitisRenk);
                }
            }
            sonBox2.Image = son;
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG|*.png";
            ImageFormat format = ImageFormat.Png;
            DialogResult sonuc = saveFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                son.Save(saveFileDialog1.FileName, format);

            }
        }
    }
}
