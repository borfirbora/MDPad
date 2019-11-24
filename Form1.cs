using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
        string adsiz = "Adsız";
        string dosya_adi = null;
        bool icerik = false;

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

        private void MDEdit_TextChanged(object sender, EventArgs e)
        {
            icerik = true;
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (icerik==true)
            {
                DialogResult soru = MessageBox.Show("Yaptığınız değişiklikleri kaydetmek istiyor musunuz?", " MDPad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (soru == DialogResult.Yes)
                {
                    if (dosya_adi == null)
                    {
                        farklıKaydetToolStripMenuItem_Click(null, null);
                    }
                    else
                    {
                        StreamWriter sw = new StreamWriter(dosya_adi, false, Encoding.GetEncoding("utf-8"));
                        sw.Write(MDEdit.Text);
                        sw.Flush();
                        sw.Close();
                        Application.Exit();
                    }
                    }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (icerik == true)
            {
                DialogResult soru = MessageBox.Show("Yaptığınız değişiklikleri kaydetmek istiyor musunuz?", " MDPad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (soru == DialogResult.Yes)
                {
                    if (dosya_adi == null)
                    {
                        farklıKaydetToolStripMenuItem_Click(null, null);
                    }
                    else
                    {
                        StreamWriter sw = new StreamWriter(dosya_adi, false, Encoding.GetEncoding("utf-8"));
                        sw.Write(MDEdit.Text);
                        sw.Flush();
                        sw.Close();
                        Form1_Load(null,null);
                    }
                }
                else
                {
                    Form1_Load(null, null);
                }
            }
            else
            {
                Form1_Load(null, null);
            }
      }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = adsiz + " - MDPad";
            MDEdit.Text = "";
        }

                private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dosya_adi == null)
            {
                farklıKaydetToolStripMenuItem_Click(null, null);
            }
            else
            {
                StreamWriter sw = new StreamWriter(dosya_adi, false, Encoding.GetEncoding("utf-8"));
                sw.Write(MDEdit.Text);
                sw.Flush();
                sw.Close();
                this.Text = dosya_adi + " - MDPad";
            }
            }

        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (icerik == true)
            {
                DialogResult soru = MessageBox.Show("Yaptığınız değişiklikleri kaydetmek istiyor musunuz?", " MDPad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (soru == DialogResult.Yes)
                {
                    if (dosya_adi == null)
                    {
                        farklıKaydetToolStripMenuItem_Click(null, null);
                    }
                    else
                    {
                        StreamWriter sw = new StreamWriter(dosya_adi, false, Encoding.GetEncoding("utf-8"));
                        sw.Write(MDEdit.Text);
                        sw.Flush();
                        sw.Close();
                    }
                }
            }
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dosya_adi = saveFileDialog1.FileName;
                kaydetToolStripMenuItem_Click(null, null);
            }
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (icerik == true)
            {
                DialogResult soru = MessageBox.Show("Yaptığınız değişiklikler var. Bunları kaydetmek istiyor musunuz?", " MDPad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (soru == DialogResult.Yes)
                {
                    if (dosya_adi == null)
                    {
                        farklıKaydetToolStripMenuItem_Click(null, null);
                    }
                    else
                    {
                        StreamWriter sw = new StreamWriter(dosya_adi, false, Encoding.GetEncoding("utf-8"));
                        sw.Write(MDEdit.Text);
                        sw.Flush();
                        sw.Close();
                    }
                }
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dosya_adi = openFileDialog1.FileName;
                StreamReader sr = new StreamReader(openFileDialog1.FileName, Encoding.GetEncoding("utf-8"));
                MDEdit.Text = sr.ReadToEnd();
                sr.Close();
                this.Text = dosya_adi + " - MDPad";
                icerik = false;
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void tümünüSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDEdit.SelectAll();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDEdit.Cut();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDEdit.Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDEdit.Paste();
        }

        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDEdit.Undo();
        }
    }
}
