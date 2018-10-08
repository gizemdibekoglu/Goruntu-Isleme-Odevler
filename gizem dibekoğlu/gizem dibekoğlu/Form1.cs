using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gizem_dibekoğlu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ortalamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 ortalama = new gizem_dibekoğlu.Form2();
            ortalama.ShowDialog();
        }

        private void bt709ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 bt709 = new Form3();
            bt709.ShowDialog();
        }

        private void lumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 luma = new gizem_dibekoğlu.Form4();
            luma.ShowDialog();
        }

        private void açıklıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 açıklık = new Form5();
            açıklık.ShowDialog();

        }

        private void kanalÇıkarmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 kanalçıkarma = new Form6();
            kanalçıkarma.ShowDialog();
        }
    }
}
