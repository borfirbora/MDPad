using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MDPad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void baglantıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string baglanti = "[Bağlantı Başlığı](Bağlantı Adresi)";
                MDEdit.Text = MDEdit.Text.Insert(MDEdit.SelectionStart,baglanti);
                                    MDEdit.Select(MDEdit.Text.Length,0);
        }

        private void resimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string resim = "![Resim Başlığı](Resim Adresi) ";
            MDEdit.Text = MDEdit.Text.Insert(MDEdit.SelectionStart, resim);
            MDEdit.Select(MDEdit.Text.Length, 0);
                    }
    }
}
