namespace MDPad
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farklıKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümünüSeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.başlıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seviye1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seviye2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seviye3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seviye4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seviye5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seviye6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baglantıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dipnotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numaralıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numarasızToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.içindekilerVeDizinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görüşBildirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MDEdit = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.düzenToolStripMenuItem,
            this.ekleToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.açToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.farklıKaydetToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "&Dosya";
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniToolStripMenuItem.Text = "Ye&ni";
            this.yeniToolStripMenuItem.Click += new System.EventHandler(this.yeniToolStripMenuItem_Click);
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.açToolStripMenuItem.Text = "A&ç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kaydetToolStripMenuItem.Text = "K&aydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // farklıKaydetToolStripMenuItem
            // 
            this.farklıKaydetToolStripMenuItem.Name = "farklıKaydetToolStripMenuItem";
            this.farklıKaydetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.farklıKaydetToolStripMenuItem.Text = "Fa&rklı Kaydet...";
            this.farklıKaydetToolStripMenuItem.Click += new System.EventHandler(this.farklıKaydetToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.çıkışToolStripMenuItem.Text = "&Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // düzenToolStripMenuItem
            // 
            this.düzenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tümünüSeçToolStripMenuItem,
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapıştırToolStripMenuItem,
            this.geriAlToolStripMenuItem});
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.düzenToolStripMenuItem.Text = "Dü&zen";
            // 
            // tümünüSeçToolStripMenuItem
            // 
            this.tümünüSeçToolStripMenuItem.Name = "tümünüSeçToolStripMenuItem";
            this.tümünüSeçToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.tümünüSeçToolStripMenuItem.Text = "Tümünü Se&ç";
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.kesToolStripMenuItem.Text = "&ke&s";
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.kopyalaToolStripMenuItem.Text = "K&opyala";
            // 
            // yapıştırToolStripMenuItem
            // 
            this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            this.yapıştırToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.yapıştırToolStripMenuItem.Text = "ya&pıştır";
            // 
            // geriAlToolStripMenuItem
            // 
            this.geriAlToolStripMenuItem.Name = "geriAlToolStripMenuItem";
            this.geriAlToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.geriAlToolStripMenuItem.Text = "Geri &Al";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.başlıkToolStripMenuItem,
            this.baglantıToolStripMenuItem,
            this.resimToolStripMenuItem,
            this.dipnotToolStripMenuItem,
            this.listeToolStripMenuItem,
            this.tabloToolStripMenuItem});
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.ekleToolStripMenuItem.Text = "E&kle";
            // 
            // başlıkToolStripMenuItem
            // 
            this.başlıkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seviye1ToolStripMenuItem,
            this.seviye2ToolStripMenuItem,
            this.seviye3ToolStripMenuItem,
            this.seviye4ToolStripMenuItem,
            this.seviye5ToolStripMenuItem,
            this.seviye6ToolStripMenuItem});
            this.başlıkToolStripMenuItem.Name = "başlıkToolStripMenuItem";
            this.başlıkToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.başlıkToolStripMenuItem.Text = "Başlık";
            // 
            // seviye1ToolStripMenuItem
            // 
            this.seviye1ToolStripMenuItem.Name = "seviye1ToolStripMenuItem";
            this.seviye1ToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.seviye1ToolStripMenuItem.Text = "Seviye &1";
            // 
            // seviye2ToolStripMenuItem
            // 
            this.seviye2ToolStripMenuItem.Name = "seviye2ToolStripMenuItem";
            this.seviye2ToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.seviye2ToolStripMenuItem.Text = "Seviye &2";
            // 
            // seviye3ToolStripMenuItem
            // 
            this.seviye3ToolStripMenuItem.Name = "seviye3ToolStripMenuItem";
            this.seviye3ToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.seviye3ToolStripMenuItem.Text = "Seviye &3";
            // 
            // seviye4ToolStripMenuItem
            // 
            this.seviye4ToolStripMenuItem.Name = "seviye4ToolStripMenuItem";
            this.seviye4ToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.seviye4ToolStripMenuItem.Text = "Seviye &4";
            // 
            // seviye5ToolStripMenuItem
            // 
            this.seviye5ToolStripMenuItem.Name = "seviye5ToolStripMenuItem";
            this.seviye5ToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.seviye5ToolStripMenuItem.Text = "Seviye &5";
            // 
            // seviye6ToolStripMenuItem
            // 
            this.seviye6ToolStripMenuItem.Name = "seviye6ToolStripMenuItem";
            this.seviye6ToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.seviye6ToolStripMenuItem.Text = "Seviye &6";
            // 
            // baglantıToolStripMenuItem
            // 
            this.baglantıToolStripMenuItem.Name = "baglantıToolStripMenuItem";
            this.baglantıToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.baglantıToolStripMenuItem.Text = "Bağ&lantı...";
            this.baglantıToolStripMenuItem.Click += new System.EventHandler(this.baglantıToolStripMenuItem_Click);
            // 
            // resimToolStripMenuItem
            // 
            this.resimToolStripMenuItem.Name = "resimToolStripMenuItem";
            this.resimToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.resimToolStripMenuItem.Text = "Re&sim...";
            this.resimToolStripMenuItem.Click += new System.EventHandler(this.resimToolStripMenuItem_Click);
            // 
            // dipnotToolStripMenuItem
            // 
            this.dipnotToolStripMenuItem.Name = "dipnotToolStripMenuItem";
            this.dipnotToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.dipnotToolStripMenuItem.Text = "Di&pnot...";
            // 
            // listeToolStripMenuItem
            // 
            this.listeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numaralıToolStripMenuItem,
            this.numarasızToolStripMenuItem});
            this.listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            this.listeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.listeToolStripMenuItem.Text = "&Liste";
            // 
            // numaralıToolStripMenuItem
            // 
            this.numaralıToolStripMenuItem.Name = "numaralıToolStripMenuItem";
            this.numaralıToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.numaralıToolStripMenuItem.Text = "Numara&lı";
            // 
            // numarasızToolStripMenuItem
            // 
            this.numarasızToolStripMenuItem.Name = "numarasızToolStripMenuItem";
            this.numarasızToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.numarasızToolStripMenuItem.Text = "Numara&sız";
            // 
            // tabloToolStripMenuItem
            // 
            this.tabloToolStripMenuItem.Name = "tabloToolStripMenuItem";
            this.tabloToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.tabloToolStripMenuItem.Text = "Ta&blo...";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.içindekilerVeDizinToolStripMenuItem,
            this.görüşBildirToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "Ya&rdım";
            // 
            // içindekilerVeDizinToolStripMenuItem
            // 
            this.içindekilerVeDizinToolStripMenuItem.Name = "içindekilerVeDizinToolStripMenuItem";
            this.içindekilerVeDizinToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.içindekilerVeDizinToolStripMenuItem.Text = "İçindekiler ve Di&zin";
            // 
            // görüşBildirToolStripMenuItem
            // 
            this.görüşBildirToolStripMenuItem.Name = "görüşBildirToolStripMenuItem";
            this.görüşBildirToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.görüşBildirToolStripMenuItem.Text = "G&örüş Bildir...";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.hakkındaToolStripMenuItem.Text = "Hakkın&da";
            // 
            // MDEdit
            // 
            this.MDEdit.AcceptsTab = true;
            this.MDEdit.AccessibleDescription = "";
            this.MDEdit.AccessibleName = "MarkDown Girişi:";
            this.MDEdit.DetectUrls = false;
            this.MDEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MDEdit.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.MDEdit.HideSelection = false;
            this.MDEdit.Location = new System.Drawing.Point(0, 24);
            this.MDEdit.Name = "MDEdit";
            this.MDEdit.Size = new System.Drawing.Size(1350, 705);
            this.MDEdit.TabIndex = 1;
            this.MDEdit.Text = "";
            this.MDEdit.TextChanged += new System.EventHandler(this.MDEdit_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AccessibleName = "MDPad";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.MDEdit);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "MDPad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farklıKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tümünüSeçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem başlıkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seviye1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seviye2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seviye3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seviye4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seviye5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seviye6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baglantıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dipnotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numaralıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numarasızToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem içindekilerVeDizinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görüşBildirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.RichTextBox MDEdit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

