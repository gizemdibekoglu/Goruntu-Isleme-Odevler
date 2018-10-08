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
    public partial class Form2 : Form
    {
        Bitmap ilk, son;
        public Form2()
        {
            InitializeComponent();
        }

        private void kapaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            int yuk= ilk.Height;
            int yatay = ilk.Width;
            son = new Bitmap(yatay, yuk);
            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < yatay; x++)
                {
                    Color normalrenk = ilk.GetPixel(x, y);
                    int olan = (normalrenk.R + normalrenk.G + normalrenk.B) / 3;
                    Color olanRenk = Color.FromArgb(olan, olan, olan);
                    son.SetPixel(x, y, olanRenk);

                }
            }
            sonBox2.Image = son;
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
    }
}
