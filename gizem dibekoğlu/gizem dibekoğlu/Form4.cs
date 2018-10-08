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
    public partial class Form4 : Form
    {
        Bitmap ilk, son;
        public Form4()
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

            int dik = ilk.Height;
            int en = ilk.Width;
            son = new Bitmap(en, dik);
            for (int y = 0; y < dik; y++)
            {
                for (int x = 0; x < en; x++)
                {
                    Color normal = ilk.GetPixel(x, y);
                    double luma = normal.R * 0.3 + normal.G * 0.59 + normal.B * 0.11;
                    int lumaolan = Convert.ToInt16(luma);
                    Color sonislem = Color.FromArgb(lumaolan, lumaolan, lumaolan);
                    son.SetPixel(x, y, sonislem);
                }
                sonBox2.Image = son;
            }
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
