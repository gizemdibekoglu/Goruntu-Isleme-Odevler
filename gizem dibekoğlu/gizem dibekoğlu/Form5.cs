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
    public partial class Form5 : Form
    {
        Bitmap ilk, son;
        public Form5()
        {
            InitializeComponent();
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
                    Color normal = ilk.GetPixel(x, y);
                    int max = Math.Max(normal.R, normal.G);
                    int bitismax = Math.Max(max, normal.B);
                    int min = Math.Min(normal.R, normal.G);
                    int bitismin = Math.Min(min, normal.B);
                    int sonuc = (bitismax + bitismin) / 2;
                    Color bitisRenk = Color.FromArgb(sonuc, sonuc, sonuc);
                   son.SetPixel(x, y, bitisRenk);
                }

            }
            sonBox2.Image = son;
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Görüntüler|*.jpg;*.png";
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                ilk = new Bitmap(openFileDialog1.FileName);
                ilkBox1.Image = ilk;

            }
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
