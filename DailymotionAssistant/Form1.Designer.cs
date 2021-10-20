namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sifre = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.apikey = new System.Windows.Forms.TextBox();
            this.indirmelinki = new System.Windows.Forms.TextBox();
            this.videoid = new System.Windows.Forms.TextBox();
            this.kanalismi = new System.Windows.Forms.TextBox();
            this.kod2 = new System.Windows.Forms.TextBox();
            this.kod1 = new System.Windows.Forms.TextBox();
            this.toplamvideo = new System.Windows.Forms.TextBox();
            this.videoyeri = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.KANAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GÖRÜNTÜLEME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAKİPÇİSAYISI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VİDEOSAYISI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KATEGORİ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GEÇENGÜN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GEÇENHAFTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GEÇENAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOPLAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ÜLKE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DURUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button10 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button11 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.VİDEOİD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAŞŞLIK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AÇIKLAMAA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ETİKETT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.İNDİRMEE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aktarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aciklamalinksil = new System.Windows.Forms.CheckBox();
            this.etiketözgün = new System.Windows.Forms.CheckBox();
            this.indirr = new System.Windows.Forms.Button();
            this.veri_cek = new System.Windows.Forms.Button();
            this.aciklama2 = new System.Windows.Forms.TextBox();
            this.etiket2 = new System.Windows.Forms.TextBox();
            this.baslik2 = new System.Windows.Forms.TextBox();
            this.indirlink = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UploadURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.videoyaGitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gizlilik = new System.Windows.Forms.ComboBox();
            this.kategori = new System.Windows.Forms.ComboBox();
            this.yenile = new System.Windows.Forms.Button();
            this.Gönder = new System.Windows.Forms.Button();
            this.Kanallar = new System.Windows.Forms.ComboBox();
            this.aciklama = new System.Windows.Forms.TextBox();
            this.baslik = new System.Windows.Forms.TextBox();
            this.etiket = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button12 = new System.Windows.Forms.Button();
            this.Dailyupload = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Sayı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VideoIdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOWN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UploadURLL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HATAA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button9 = new System.Windows.Forms.Button();
            this.yüklemegeridöngü = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.linkileindir = new System.Windows.Forms.ListBox();
            this.button6 = new System.Windows.Forms.Button();
            this.videosayi = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.aciklamalinksil2 = new System.Windows.Forms.CheckBox();
            this.etiketözgünlestir2 = new System.Windows.Forms.CheckBox();
            this.Kanallar2 = new System.Windows.Forms.ComboBox();
            this.indirlink2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.onaykaldır = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.onayla = new System.Windows.Forms.Button();
            this.ApiAl = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.uploadid = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.kanalmailsifre = new System.Windows.Forms.ListBox();
            this.dailykanalid = new System.Windows.Forms.ComboBox();
            this.dailybilgi = new System.Windows.Forms.ListBox();
            this.dailyjson = new System.Windows.Forms.ListBox();
            this.VideoSil = new System.Windows.Forms.Button();
            this.videoidler = new System.Windows.Forms.ListBox();
            this.yüklenilenvideo = new System.Windows.Forms.ListBox();
            this.yenile2 = new System.Windows.Forms.Button();
            this.kanallink = new System.Windows.Forms.TextBox();
            this.Dosyayaz = new System.Windows.Forms.Timer(this.components);
            this.searchvideoid = new System.Windows.Forms.ListBox();
            this.searchetiket = new System.Windows.Forms.ListBox();
            this.yüklenenvideoid = new System.Windows.Forms.ListBox();
            this.durumguncelle = new System.Windows.Forms.Timer(this.components);
            this.kimlik = new System.Windows.Forms.TextBox();
            this.aciklama3 = new System.Windows.Forms.TextBox();
            this.etiket3 = new System.Windows.Forms.TextBox();
            this.baslik3 = new System.Windows.Forms.TextBox();
            this.ETİKET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AÇIKLAMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAŞLIK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THUMBNAİL = new System.Windows.Forms.DataGridViewImageColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SAYI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.aciklamalink = new System.Windows.Forms.ListBox();
            this.uzantilivideo = new System.Windows.Forms.ListBox();
            this.uzantisizvideo = new System.Windows.Forms.ListBox();
            this.tags = new System.Windows.Forms.ListBox();
            this.videoyeri2 = new System.Windows.Forms.TextBox();
            this.dailykanaltakip = new System.Windows.Forms.ListBox();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uploadAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.contextMenuStrip4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(1736, 176);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(62, 20);
            this.sifre.TabIndex = 52;
            this.sifre.Text = "sifre";
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(1736, 149);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(62, 20);
            this.mail.TabIndex = 51;
            this.mail.Text = "mail";
            // 
            // apikey
            // 
            this.apikey.Location = new System.Drawing.Point(1630, 587);
            this.apikey.Multiline = true;
            this.apikey.Name = "apikey";
            this.apikey.Size = new System.Drawing.Size(214, 19);
            this.apikey.TabIndex = 62;
            this.apikey.Text = "AIzaSyBtzmA_FXrUq5Qt8KUWaAwX5TeTPMG--8s";
            // 
            // indirmelinki
            // 
            this.indirmelinki.Location = new System.Drawing.Point(1630, 176);
            this.indirmelinki.Name = "indirmelinki";
            this.indirmelinki.Size = new System.Drawing.Size(100, 20);
            this.indirmelinki.TabIndex = 59;
            // 
            // videoid
            // 
            this.videoid.Location = new System.Drawing.Point(1630, 560);
            this.videoid.Name = "videoid";
            this.videoid.Size = new System.Drawing.Size(214, 20);
            this.videoid.TabIndex = 61;
            this.videoid.Text = "4ufUNyhkhuM";
            // 
            // kanalismi
            // 
            this.kanalismi.Location = new System.Drawing.Point(1630, 150);
            this.kanalismi.Name = "kanalismi";
            this.kanalismi.Size = new System.Drawing.Size(100, 20);
            this.kanalismi.TabIndex = 58;
            this.kanalismi.Text = "kanalismi";
            // 
            // kod2
            // 
            this.kod2.Location = new System.Drawing.Point(1630, 122);
            this.kod2.Name = "kod2";
            this.kod2.Size = new System.Drawing.Size(334, 20);
            this.kod2.TabIndex = 57;
            this.kod2.Text = "%(id)s.%(ext)s\" ";
            // 
            // kod1
            // 
            this.kod1.Location = new System.Drawing.Point(1630, 96);
            this.kod1.Name = "kod1";
            this.kod1.Size = new System.Drawing.Size(334, 20);
            this.kod1.TabIndex = 56;
            this.kod1.Text = "youtube-dl  -f mp4 --verbose --ignore-errors --playlist-start=1 -o \"";
            // 
            // toplamvideo
            // 
            this.toplamvideo.Location = new System.Drawing.Point(1630, 17);
            this.toplamvideo.Name = "toplamvideo";
            this.toplamvideo.Size = new System.Drawing.Size(146, 20);
            this.toplamvideo.TabIndex = 55;
            this.toplamvideo.Text = "toplamvideo";
            // 
            // videoyeri
            // 
            this.videoyeri.Location = new System.Drawing.Point(1633, 42);
            this.videoyeri.Multiline = true;
            this.videoyeri.Name = "videoyeri";
            this.videoyeri.Size = new System.Drawing.Size(143, 24);
            this.videoyeri.TabIndex = 53;
            this.videoyeri.Text = "videoyeri";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.ImageList = this.ımageList1;
            this.tabControl1.ItemSize = new System.Drawing.Size(75, 200);
            this.tabControl1.Location = new System.Drawing.Point(12, 10);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1496, 868);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 64;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Controls.Add(this.button10);
            this.tabPage4.Controls.Add(this.pictureBox2);
            this.tabPage4.Controls.Add(this.button11);
            this.tabPage4.ImageIndex = 12;
            this.tabPage4.Location = new System.Drawing.Point(204, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1288, 860);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "Kanal Takip";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 124;
            this.label2.Text = "Durum:";
            // 
            // dataGridView4
            // 
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn2,
            this.KANAL,
            this.GÖRÜNTÜLEME,
            this.TAKİPÇİSAYISI,
            this.VİDEOSAYISI,
            this.KATEGORİ,
            this.GEÇENGÜN,
            this.GEÇENHAFTA,
            this.GEÇENAY,
            this.TOPLAM,
            this.ÜLKE,
            this.DURUM});
            this.dataGridView4.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView4.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView4.Location = new System.Drawing.Point(20, 89);
            this.dataGridView4.MultiSelect = false;
            this.dataGridView4.Name = "dataGridView4";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView4.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(1253, 737);
            this.dataGridView4.TabIndex = 123;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Avatar";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 70;
            // 
            // KANAL
            // 
            this.KANAL.HeaderText = "Kanal";
            this.KANAL.Name = "KANAL";
            // 
            // GÖRÜNTÜLEME
            // 
            this.GÖRÜNTÜLEME.HeaderText = "Görüntüleme";
            this.GÖRÜNTÜLEME.Name = "GÖRÜNTÜLEME";
            this.GÖRÜNTÜLEME.Width = 120;
            // 
            // TAKİPÇİSAYISI
            // 
            this.TAKİPÇİSAYISI.HeaderText = "Takipçi Sayısı";
            this.TAKİPÇİSAYISI.Name = "TAKİPÇİSAYISI";
            // 
            // VİDEOSAYISI
            // 
            this.VİDEOSAYISI.HeaderText = "Video Sayısı";
            this.VİDEOSAYISI.Name = "VİDEOSAYISI";
            // 
            // KATEGORİ
            // 
            this.KATEGORİ.HeaderText = "Kategori";
            this.KATEGORİ.Name = "KATEGORİ";
            // 
            // GEÇENGÜN
            // 
            this.GEÇENGÜN.HeaderText = "Geçen Gün";
            this.GEÇENGÜN.Name = "GEÇENGÜN";
            // 
            // GEÇENHAFTA
            // 
            this.GEÇENHAFTA.HeaderText = "Geçen Hafta";
            this.GEÇENHAFTA.Name = "GEÇENHAFTA";
            // 
            // GEÇENAY
            // 
            this.GEÇENAY.HeaderText = "Geçen Ay";
            this.GEÇENAY.Name = "GEÇENAY";
            // 
            // TOPLAM
            // 
            this.TOPLAM.HeaderText = "Toplam";
            this.TOPLAM.Name = "TOPLAM";
            // 
            // ÜLKE
            // 
            this.ÜLKE.HeaderText = "Ülke";
            this.ÜLKE.Name = "ÜLKE";
            // 
            // DURUM
            // 
            this.DURUM.HeaderText = "Durum";
            this.DURUM.Name = "DURUM";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aktarToolStripMenuItem,
            this.gitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(105, 48);
            // 
            // aktarToolStripMenuItem
            // 
            this.aktarToolStripMenuItem.Name = "aktarToolStripMenuItem";
            this.aktarToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.aktarToolStripMenuItem.Text = "Kaldır";
            this.aktarToolStripMenuItem.Click += new System.EventHandler(this.aktarToolStripMenuItem_Click);
            // 
            // gitToolStripMenuItem
            // 
            this.gitToolStripMenuItem.Name = "gitToolStripMenuItem";
            this.gitToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.gitToolStripMenuItem.Text = "Git";
            this.gitToolStripMenuItem.Click += new System.EventHandler(this.gitToolStripMenuItem_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(31, 18);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(150, 45);
            this.button10.TabIndex = 104;
            this.button10.Text = "Kanalları getir";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(989, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(244, 53);
            this.pictureBox2.TabIndex = 102;
            this.pictureBox2.TabStop = false;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(197, 18);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(172, 45);
            this.button11.TabIndex = 96;
            this.button11.Text = "Api al ve onayla";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click_1);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView5);
            this.tabPage1.Controls.Add(this.aciklamalinksil);
            this.tabPage1.Controls.Add(this.etiketözgün);
            this.tabPage1.Controls.Add(this.indirr);
            this.tabPage1.Controls.Add(this.veri_cek);
            this.tabPage1.Controls.Add(this.aciklama2);
            this.tabPage1.Controls.Add(this.etiket2);
            this.tabPage1.Controls.Add(this.baslik2);
            this.tabPage1.Controls.Add(this.indirlink);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.ImageIndex = 7;
            this.tabPage1.Location = new System.Drawing.Point(204, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1288, 860);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Download";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VİDEOİD,
            this.BAŞŞLIK,
            this.AÇIKLAMAA,
            this.ETİKETT,
            this.İNDİRMEE});
            this.dataGridView5.ContextMenuStrip = this.contextMenuStrip2;
            this.dataGridView5.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView5.Location = new System.Drawing.Point(22, 505);
            this.dataGridView5.MultiSelect = false;
            this.dataGridView5.Name = "dataGridView5";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView5.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView5.Size = new System.Drawing.Size(1251, 330);
            this.dataGridView5.TabIndex = 124;
            // 
            // VİDEOİD
            // 
            this.VİDEOİD.HeaderText = "VideoId";
            this.VİDEOİD.Name = "VİDEOİD";
            // 
            // BAŞŞLIK
            // 
            this.BAŞŞLIK.HeaderText = "Başlık";
            this.BAŞŞLIK.Name = "BAŞŞLIK";
            this.BAŞŞLIK.Width = 350;
            // 
            // AÇIKLAMAA
            // 
            this.AÇIKLAMAA.HeaderText = "Açıklama";
            this.AÇIKLAMAA.Name = "AÇIKLAMAA";
            this.AÇIKLAMAA.Width = 300;
            // 
            // ETİKETT
            // 
            this.ETİKETT.HeaderText = "Etiket";
            this.ETİKETT.Name = "ETİKETT";
            this.ETİKETT.Width = 320;
            // 
            // İNDİRMEE
            // 
            this.İNDİRMEE.HeaderText = "İndirme";
            this.İNDİRMEE.Name = "İNDİRMEE";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aktarToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(103, 26);
            // 
            // aktarToolStripMenuItem1
            // 
            this.aktarToolStripMenuItem1.Name = "aktarToolStripMenuItem1";
            this.aktarToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.aktarToolStripMenuItem1.Text = "Aktar";
            this.aktarToolStripMenuItem1.Click += new System.EventHandler(this.aktarToolStripMenuItem1_Click);
            // 
            // aciklamalinksil
            // 
            this.aciklamalinksil.AutoSize = true;
            this.aciklamalinksil.Checked = true;
            this.aciklamalinksil.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aciklamalinksil.Location = new System.Drawing.Point(486, 87);
            this.aciklamalinksil.Name = "aciklamalinksil";
            this.aciklamalinksil.Size = new System.Drawing.Size(186, 24);
            this.aciklamalinksil.TabIndex = 97;
            this.aciklamalinksil.Text = "Açıklamadaki linkleri sil";
            this.aciklamalinksil.UseVisualStyleBackColor = true;
            // 
            // etiketözgün
            // 
            this.etiketözgün.AutoSize = true;
            this.etiketözgün.Checked = true;
            this.etiketözgün.CheckState = System.Windows.Forms.CheckState.Checked;
            this.etiketözgün.Location = new System.Drawing.Point(282, 87);
            this.etiketözgün.Name = "etiketözgün";
            this.etiketözgün.Size = new System.Drawing.Size(198, 24);
            this.etiketözgün.TabIndex = 96;
            this.etiketözgün.Text = "Etiketi yoksa özgünleştir";
            this.etiketözgün.UseVisualStyleBackColor = true;
            // 
            // indirr
            // 
            this.indirr.Location = new System.Drawing.Point(529, 434);
            this.indirr.Name = "indirr";
            this.indirr.Size = new System.Drawing.Size(75, 42);
            this.indirr.TabIndex = 94;
            this.indirr.Text = "İndir";
            this.indirr.UseVisualStyleBackColor = true;
            this.indirr.Click += new System.EventHandler(this.indirr_Click);
            // 
            // veri_cek
            // 
            this.veri_cek.Location = new System.Drawing.Point(869, 54);
            this.veri_cek.Name = "veri_cek";
            this.veri_cek.Size = new System.Drawing.Size(86, 50);
            this.veri_cek.TabIndex = 92;
            this.veri_cek.Text = "Verileri Çek";
            this.veri_cek.UseVisualStyleBackColor = true;
            this.veri_cek.Click += new System.EventHandler(this.veri_cek_Click);
            // 
            // aciklama2
            // 
            this.aciklama2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aciklama2.Location = new System.Drawing.Point(282, 153);
            this.aciklama2.Multiline = true;
            this.aciklama2.Name = "aciklama2";
            this.aciklama2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.aciklama2.Size = new System.Drawing.Size(526, 184);
            this.aciklama2.TabIndex = 85;
            // 
            // etiket2
            // 
            this.etiket2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.etiket2.Location = new System.Drawing.Point(282, 353);
            this.etiket2.Multiline = true;
            this.etiket2.Name = "etiket2";
            this.etiket2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.etiket2.Size = new System.Drawing.Size(526, 51);
            this.etiket2.TabIndex = 86;
            this.etiket2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.etiket2_KeyPress);
            // 
            // baslik2
            // 
            this.baslik2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslik2.Location = new System.Drawing.Point(282, 117);
            this.baslik2.Name = "baslik2";
            this.baslik2.Size = new System.Drawing.Size(526, 27);
            this.baslik2.TabIndex = 84;
            // 
            // indirlink
            // 
            this.indirlink.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.indirlink.Location = new System.Drawing.Point(282, 54);
            this.indirlink.Name = "indirlink";
            this.indirlink.Size = new System.Drawing.Size(526, 27);
            this.indirlink.TabIndex = 90;
            this.indirlink.Text = "https://www.youtube.com/watch?v=7Ydw8xFCNvs";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(216, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 18);
            this.label12.TabIndex = 91;
            this.label12.Text = "Link:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(123, 366);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 18);
            this.label10.TabIndex = 88;
            this.label10.Text = "Video Etiketleri:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(142, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 18);
            this.label6.TabIndex = 87;
            this.label6.Text = "Video Başlığı:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(110, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 18);
            this.label11.TabIndex = 89;
            this.label11.Text = "Video Açıklaması:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(858, 182);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView6);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.gizlilik);
            this.tabPage2.Controls.Add(this.kategori);
            this.tabPage2.Controls.Add(this.yenile);
            this.tabPage2.Controls.Add(this.Gönder);
            this.tabPage2.Controls.Add(this.Kanallar);
            this.tabPage2.Controls.Add(this.aciklama);
            this.tabPage2.Controls.Add(this.baslik);
            this.tabPage2.Controls.Add(this.etiket);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.ImageIndex = 5;
            this.tabPage2.Location = new System.Drawing.Point(204, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1288, 860);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Upload";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView6
            // 
            this.dataGridView6.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.UploadURL,
            this.Hata});
            this.dataGridView6.ContextMenuStrip = this.contextMenuStrip4;
            this.dataGridView6.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView6.Location = new System.Drawing.Point(31, 532);
            this.dataGridView6.MultiSelect = false;
            this.dataGridView6.Name = "dataGridView6";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView6.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView6.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView6.Size = new System.Drawing.Size(1251, 299);
            this.dataGridView6.TabIndex = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Kanal";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Başlık";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 320;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Açıklama";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 250;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Etiket";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 250;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Yükleme";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 80;
            // 
            // UploadURL
            // 
            this.UploadURL.HeaderText = "UploadURL";
            this.UploadURL.Name = "UploadURL";
            // 
            // Hata
            // 
            this.Hata.HeaderText = "Hata";
            this.Hata.Name = "Hata";
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.videoyaGitToolStripMenuItem});
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(135, 26);
            // 
            // videoyaGitToolStripMenuItem
            // 
            this.videoyaGitToolStripMenuItem.Name = "videoyaGitToolStripMenuItem";
            this.videoyaGitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.videoyaGitToolStripMenuItem.Text = "Videoya Git";
            this.videoyaGitToolStripMenuItem.Click += new System.EventHandler(this.videoyaGitToolStripMenuItem_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(793, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 20);
            this.label14.TabIndex = 93;
            this.label14.Text = "Gizlilik:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(793, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 92;
            this.label7.Text = "Kategori:";
            // 
            // gizlilik
            // 
            this.gizlilik.FormattingEnabled = true;
            this.gizlilik.Items.AddRange(new object[] {
            "Herkese Açık",
            "Gizli"});
            this.gizlilik.Location = new System.Drawing.Point(883, 140);
            this.gizlilik.Name = "gizlilik";
            this.gizlilik.Size = new System.Drawing.Size(216, 28);
            this.gizlilik.TabIndex = 91;
            this.gizlilik.SelectedIndexChanged += new System.EventHandler(this.gizlilik_SelectedIndexChanged);
            // 
            // kategori
            // 
            this.kategori.FormattingEnabled = true;
            this.kategori.Items.AddRange(new object[] {
            "Çocuk",
            "Eğitim",
            "Haber ve Politika",
            "Hayvanlar",
            "Komedi ve Eğlence",
            "Magazin",
            "Müzik",
            "Oto-Moto",
            "Oyun",
            "Sanat",
            "Seyehat",
            "Sinema",
            "Spor ve Zorlu Sporlar",
            "Teknoloji ve Bilim",
            "TV ve Dizi",
            "Web Kamerası",
            "Yaşam ve Stil"});
            this.kategori.Location = new System.Drawing.Point(883, 89);
            this.kategori.Name = "kategori";
            this.kategori.Size = new System.Drawing.Size(216, 28);
            this.kategori.TabIndex = 90;
            this.kategori.SelectedIndexChanged += new System.EventHandler(this.kategori_SelectedIndexChanged);
            // 
            // yenile
            // 
            this.yenile.Location = new System.Drawing.Point(575, 84);
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(82, 26);
            this.yenile.TabIndex = 84;
            this.yenile.Text = "yenile";
            this.yenile.UseVisualStyleBackColor = true;
            this.yenile.Click += new System.EventHandler(this.yenile_Click);
            // 
            // Gönder
            // 
            this.Gönder.Location = new System.Drawing.Point(290, 450);
            this.Gönder.Name = "Gönder";
            this.Gönder.Size = new System.Drawing.Size(166, 32);
            this.Gönder.TabIndex = 83;
            this.Gönder.Text = "Gönder";
            this.Gönder.UseVisualStyleBackColor = true;
            this.Gönder.Click += new System.EventHandler(this.Gönder_Click);
            // 
            // Kanallar
            // 
            this.Kanallar.FormattingEnabled = true;
            this.Kanallar.Location = new System.Drawing.Point(209, 84);
            this.Kanallar.Name = "Kanallar";
            this.Kanallar.Size = new System.Drawing.Size(343, 28);
            this.Kanallar.TabIndex = 82;
            this.Kanallar.SelectedIndexChanged += new System.EventHandler(this.Kanallar_SelectedIndexChanged);
            // 
            // aciklama
            // 
            this.aciklama.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aciklama.Location = new System.Drawing.Point(209, 181);
            this.aciklama.Multiline = true;
            this.aciklama.Name = "aciklama";
            this.aciklama.Size = new System.Drawing.Size(343, 186);
            this.aciklama.TabIndex = 81;
            // 
            // baslik
            // 
            this.baslik.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslik.Location = new System.Drawing.Point(209, 126);
            this.baslik.Multiline = true;
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(343, 47);
            this.baslik.TabIndex = 79;
            // 
            // etiket
            // 
            this.etiket.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.etiket.Location = new System.Drawing.Point(209, 373);
            this.etiket.Multiline = true;
            this.etiket.Name = "etiket";
            this.etiket.Size = new System.Drawing.Size(343, 47);
            this.etiket.TabIndex = 80;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(113, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 76;
            this.label5.Text = "Kanallar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(105, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 73;
            this.label3.Text = "Açıklama:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(125, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 75;
            this.label1.Text = "Başlık:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(126, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 74;
            this.label4.Text = "Etiket:";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button12);
            this.tabPage5.Controls.Add(this.Dailyupload);
            this.tabPage5.Controls.Add(this.button5);
            this.tabPage5.Controls.Add(this.dataGridView3);
            this.tabPage5.Controls.Add(this.button9);
            this.tabPage5.Controls.Add(this.yüklemegeridöngü);
            this.tabPage5.Controls.Add(this.button7);
            this.tabPage5.Controls.Add(this.linkileindir);
            this.tabPage5.Controls.Add(this.button6);
            this.tabPage5.Controls.Add(this.videosayi);
            this.tabPage5.Controls.Add(this.button8);
            this.tabPage5.Controls.Add(this.aciklamalinksil2);
            this.tabPage5.Controls.Add(this.etiketözgünlestir2);
            this.tabPage5.Controls.Add(this.Kanallar2);
            this.tabPage5.Controls.Add(this.indirlink2);
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.ImageIndex = 11;
            this.tabPage5.Location = new System.Drawing.Point(204, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1288, 860);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Toplu Video";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(720, 94);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(89, 37);
            this.button12.TabIndex = 127;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // Dailyupload
            // 
            this.Dailyupload.Location = new System.Drawing.Point(1061, 22);
            this.Dailyupload.Name = "Dailyupload";
            this.Dailyupload.Size = new System.Drawing.Size(126, 43);
            this.Dailyupload.TabIndex = 126;
            this.Dailyupload.Text = "Upload";
            this.Dailyupload.UseVisualStyleBackColor = true;
            this.Dailyupload.Click += new System.EventHandler(this.Dailyupload_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(922, 17);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 49);
            this.button5.TabIndex = 123;
            this.button5.Text = "İndirmeye Başla";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sayı,
            this.VideoIdd,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.DOWN,
            this.UP,
            this.UploadURLL,
            this.HATAA});
            this.dataGridView3.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView3.Location = new System.Drawing.Point(191, 157);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(1091, 684);
            this.dataGridView3.TabIndex = 122;
            // 
            // Sayı
            // 
            this.Sayı.HeaderText = "SAYI";
            this.Sayı.Name = "Sayı";
            this.Sayı.Width = 50;
            // 
            // VideoIdd
            // 
            this.VideoIdd.HeaderText = "ID";
            this.VideoIdd.Name = "VideoIdd";
            this.VideoIdd.Width = 90;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "THUMBNAİL";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "BAŞLIK";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "AÇIKLAMA";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "ETİKET";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // DOWN
            // 
            this.DOWN.HeaderText = "DOWN";
            this.DOWN.Name = "DOWN";
            this.DOWN.Width = 90;
            // 
            // UP
            // 
            this.UP.HeaderText = "UP";
            this.UP.Name = "UP";
            this.UP.Width = 90;
            // 
            // UploadURLL
            // 
            this.UploadURLL.HeaderText = "UPLOADURL";
            this.UploadURLL.Name = "UploadURLL";
            // 
            // HATAA
            // 
            this.HATAA.HeaderText = "HATA";
            this.HATAA.Name = "HATAA";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(111, 112);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(74, 35);
            this.button9.TabIndex = 120;
            this.button9.Text = "Sil";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // yüklemegeridöngü
            // 
            this.yüklemegeridöngü.Location = new System.Drawing.Point(247, 77);
            this.yüklemegeridöngü.Multiline = true;
            this.yüklemegeridöngü.Name = "yüklemegeridöngü";
            this.yüklemegeridöngü.Size = new System.Drawing.Size(450, 29);
            this.yüklemegeridöngü.TabIndex = 99;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(16, 112);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(79, 35);
            this.button7.TabIndex = 119;
            this.button7.Text = "Ekle";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // linkileindir
            // 
            this.linkileindir.FormattingEnabled = true;
            this.linkileindir.ItemHeight = 20;
            this.linkileindir.Items.AddRange(new object[] {
            "13yrOIY48kY"});
            this.linkileindir.Location = new System.Drawing.Point(19, 157);
            this.linkileindir.Name = "linkileindir";
            this.linkileindir.Size = new System.Drawing.Size(166, 684);
            this.linkileindir.TabIndex = 118;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(788, 17);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(119, 49);
            this.button6.TabIndex = 117;
            this.button6.Text = "Video Data Çek";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // videosayi
            // 
            this.videosayi.AutoSize = true;
            this.videosayi.Location = new System.Drawing.Point(960, 112);
            this.videosayi.Name = "videosayi";
            this.videosayi.Size = new System.Drawing.Size(110, 20);
            this.videosayi.TabIndex = 114;
            this.videosayi.Text = "Toplam Video:";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(663, 17);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(119, 49);
            this.button8.TabIndex = 111;
            this.button8.Text = "Videoları Çek";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // aciklamalinksil2
            // 
            this.aciklamalinksil2.AutoSize = true;
            this.aciklamalinksil2.Checked = true;
            this.aciklamalinksil2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aciklamalinksil2.Location = new System.Drawing.Point(315, 50);
            this.aciklamalinksil2.Name = "aciklamalinksil2";
            this.aciklamalinksil2.Size = new System.Drawing.Size(186, 24);
            this.aciklamalinksil2.TabIndex = 110;
            this.aciklamalinksil2.Text = "Açıklamadaki linkleri sil";
            this.aciklamalinksil2.UseVisualStyleBackColor = true;
            // 
            // etiketözgünlestir2
            // 
            this.etiketözgünlestir2.AutoSize = true;
            this.etiketözgünlestir2.Checked = true;
            this.etiketözgünlestir2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.etiketözgünlestir2.Location = new System.Drawing.Point(111, 50);
            this.etiketözgünlestir2.Name = "etiketözgünlestir2";
            this.etiketözgünlestir2.Size = new System.Drawing.Size(198, 24);
            this.etiketözgünlestir2.TabIndex = 109;
            this.etiketözgünlestir2.Text = "Etiketi yoksa özgünleştir";
            this.etiketözgünlestir2.UseVisualStyleBackColor = true;
            // 
            // Kanallar2
            // 
            this.Kanallar2.FormattingEnabled = true;
            this.Kanallar2.Location = new System.Drawing.Point(373, 112);
            this.Kanallar2.Name = "Kanallar2";
            this.Kanallar2.Size = new System.Drawing.Size(241, 28);
            this.Kanallar2.TabIndex = 45;
            this.Kanallar2.SelectedIndexChanged += new System.EventHandler(this.Kanallar2_SelectedIndexChanged);
            // 
            // indirlink2
            // 
            this.indirlink2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.indirlink2.Location = new System.Drawing.Point(111, 17);
            this.indirlink2.Name = "indirlink2";
            this.indirlink2.Size = new System.Drawing.Size(526, 27);
            this.indirlink2.TabIndex = 106;
            this.indirlink2.Text = "https://www.youtube.com/channel/UCOGiql4Hr_aTEb1YPH8y7_Q/videos?view=0&sort=dd&sh" +
    "elf_id=1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(45, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 18);
            this.label16.TabIndex = 107;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.onaykaldır);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.onayla);
            this.tabPage3.Controls.Add(this.ApiAl);
            this.tabPage3.ImageIndex = 6;
            this.tabPage3.Location = new System.Drawing.Point(204, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1288, 860);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Google Api";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // onaykaldır
            // 
            this.onaykaldır.Location = new System.Drawing.Point(931, 51);
            this.onaykaldır.Name = "onaykaldır";
            this.onaykaldır.Size = new System.Drawing.Size(97, 29);
            this.onaykaldır.TabIndex = 93;
            this.onaykaldır.Text = "Onay kaldır";
            this.onaykaldır.UseVisualStyleBackColor = true;
            this.onaykaldır.Click += new System.EventHandler(this.onaykaldır_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView2.Location = new System.Drawing.Point(278, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(632, 423);
            this.dataGridView2.TabIndex = 92;
            // 
            // onayla
            // 
            this.onayla.Location = new System.Drawing.Point(931, 16);
            this.onayla.Name = "onayla";
            this.onayla.Size = new System.Drawing.Size(97, 29);
            this.onayla.TabIndex = 88;
            this.onayla.Text = "Onaylandı";
            this.onayla.UseVisualStyleBackColor = true;
            this.onayla.Click += new System.EventHandler(this.onayla_Click);
            // 
            // ApiAl
            // 
            this.ApiAl.Location = new System.Drawing.Point(134, 26);
            this.ApiAl.Name = "ApiAl";
            this.ApiAl.Size = new System.Drawing.Size(114, 37);
            this.ApiAl.TabIndex = 84;
            this.ApiAl.Text = "Api";
            this.ApiAl.UseVisualStyleBackColor = true;
            this.ApiAl.Click += new System.EventHandler(this.ApiAl_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "if_40-google-plus_843777.png");
            this.ımageList1.Images.SetKeyName(1, "if_98_111048.png");
            this.ımageList1.Images.SetKeyName(2, "if_123_CloudDownload_183249.png");
            this.ımageList1.Images.SetKeyName(3, "if_ic_cloud_upload_48px_352278.png");
            this.ımageList1.Images.SetKeyName(4, "if_Video-Camera-2_379365.png");
            this.ımageList1.Images.SetKeyName(5, "512x512.png");
            this.ımageList1.Images.SetKeyName(6, "if__Google_1156636.png");
            this.ımageList1.Images.SetKeyName(7, "if_Download-Computer_379337 (1).png");
            this.ımageList1.Images.SetKeyName(8, "if_google_1220339.png");
            this.ımageList1.Images.SetKeyName(9, "channel-512.png");
            this.ımageList1.Images.SetKeyName(10, "if_browser-add-link_532703.png");
            this.ımageList1.Images.SetKeyName(11, "204321.png");
            this.ımageList1.Images.SetKeyName(12, "92850_234467_channel_mosaic.png");
            // 
            // uploadid
            // 
            this.uploadid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uploadid.Location = new System.Drawing.Point(1571, 790);
            this.uploadid.Multiline = true;
            this.uploadid.Name = "uploadid";
            this.uploadid.Size = new System.Drawing.Size(75, 21);
            this.uploadid.TabIndex = 96;
            this.uploadid.Text = "id";
            this.uploadid.Visible = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(1945, 814);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 33);
            this.button4.TabIndex = 88;
            this.button4.Text = "Güncelle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip2;
            this.dataGridView1.Location = new System.Drawing.Point(1785, 851);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(279, 29);
            this.dataGridView1.TabIndex = 85;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(1785, 812);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 33);
            this.button1.TabIndex = 85;
            this.button1.Text = "Videoları getir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(2003, 814);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 33);
            this.button3.TabIndex = 87;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(1891, 814);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 33);
            this.button2.TabIndex = 86;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // kanalmailsifre
            // 
            this.kanalmailsifre.FormattingEnabled = true;
            this.kanalmailsifre.Location = new System.Drawing.Point(1652, 854);
            this.kanalmailsifre.Name = "kanalmailsifre";
            this.kanalmailsifre.Size = new System.Drawing.Size(114, 17);
            this.kanalmailsifre.TabIndex = 115;
            // 
            // dailykanalid
            // 
            this.dailykanalid.FormattingEnabled = true;
            this.dailykanalid.Location = new System.Drawing.Point(1652, 828);
            this.dailykanalid.Name = "dailykanalid";
            this.dailykanalid.Size = new System.Drawing.Size(121, 21);
            this.dailykanalid.TabIndex = 114;
            this.dailykanalid.Text = "dailykanalid";
            // 
            // dailybilgi
            // 
            this.dailybilgi.FormattingEnabled = true;
            this.dailybilgi.Location = new System.Drawing.Point(1760, 714);
            this.dailybilgi.Name = "dailybilgi";
            this.dailybilgi.Size = new System.Drawing.Size(145, 43);
            this.dailybilgi.TabIndex = 99;
            // 
            // dailyjson
            // 
            this.dailyjson.FormattingEnabled = true;
            this.dailyjson.Items.AddRange(new object[] {
            "{\"Dailymotion\":{\"Mail\":\"",
            "\",\"Sifre\":\"",
            "\",\"Key\":\"",
            "\",\"Secret\":\"",
            "\",\"Callbackurl\":\"",
            "\"}}"});
            this.dailyjson.Location = new System.Drawing.Point(1760, 763);
            this.dailyjson.Name = "dailyjson";
            this.dailyjson.Size = new System.Drawing.Size(145, 43);
            this.dailyjson.TabIndex = 97;
            // 
            // VideoSil
            // 
            this.VideoSil.Location = new System.Drawing.Point(6, 19);
            this.VideoSil.Name = "VideoSil";
            this.VideoSil.Size = new System.Drawing.Size(103, 41);
            this.VideoSil.TabIndex = 91;
            this.VideoSil.Text = "Sil";
            this.VideoSil.UseVisualStyleBackColor = true;
            // 
            // videoidler
            // 
            this.videoidler.FormattingEnabled = true;
            this.videoidler.Location = new System.Drawing.Point(1760, 639);
            this.videoidler.Name = "videoidler";
            this.videoidler.Size = new System.Drawing.Size(98, 56);
            this.videoidler.TabIndex = 100;
            // 
            // yüklenilenvideo
            // 
            this.yüklenilenvideo.FormattingEnabled = true;
            this.yüklenilenvideo.Location = new System.Drawing.Point(6, 71);
            this.yüklenilenvideo.Name = "yüklenilenvideo";
            this.yüklenilenvideo.Size = new System.Drawing.Size(103, 56);
            this.yüklenilenvideo.TabIndex = 90;
            // 
            // yenile2
            // 
            this.yenile2.Location = new System.Drawing.Point(1812, 202);
            this.yenile2.Name = "yenile2";
            this.yenile2.Size = new System.Drawing.Size(66, 25);
            this.yenile2.TabIndex = 46;
            this.yenile2.Text = "Yenile";
            this.yenile2.UseVisualStyleBackColor = true;
            this.yenile2.Click += new System.EventHandler(this.yenile2_Click);
            // 
            // kanallink
            // 
            this.kanallink.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kanallink.Location = new System.Drawing.Point(1755, 269);
            this.kanallink.Name = "kanallink";
            this.kanallink.Size = new System.Drawing.Size(166, 27);
            this.kanallink.TabIndex = 42;
            this.kanallink.Text = "https://www.youtube.com/channel/UCFKr-F5_pYpn92-H0M8jmLg/";
            // 
            // Dosyayaz
            // 
            this.Dosyayaz.Interval = 8000;
            this.Dosyayaz.Tick += new System.EventHandler(this.Dosyayaz_Tick);
            // 
            // searchvideoid
            // 
            this.searchvideoid.FormattingEnabled = true;
            this.searchvideoid.Location = new System.Drawing.Point(1630, 414);
            this.searchvideoid.Name = "searchvideoid";
            this.searchvideoid.Size = new System.Drawing.Size(98, 30);
            this.searchvideoid.TabIndex = 2;
            // 
            // searchetiket
            // 
            this.searchetiket.FormattingEnabled = true;
            this.searchetiket.Location = new System.Drawing.Point(1630, 464);
            this.searchetiket.Name = "searchetiket";
            this.searchetiket.Size = new System.Drawing.Size(98, 30);
            this.searchetiket.TabIndex = 3;
            // 
            // yüklenenvideoid
            // 
            this.yüklenenvideoid.FormattingEnabled = true;
            this.yüklenenvideoid.Location = new System.Drawing.Point(9, 131);
            this.yüklenenvideoid.Name = "yüklenenvideoid";
            this.yüklenenvideoid.Size = new System.Drawing.Size(100, 69);
            this.yüklenenvideoid.TabIndex = 6;
            // 
            // durumguncelle
            // 
            this.durumguncelle.Interval = 80;
            this.durumguncelle.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // kimlik
            // 
            this.kimlik.Location = new System.Drawing.Point(1736, 202);
            this.kimlik.Name = "kimlik";
            this.kimlik.Size = new System.Drawing.Size(54, 20);
            this.kimlik.TabIndex = 94;
            this.kimlik.Text = "kimlik";
            // 
            // aciklama3
            // 
            this.aciklama3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aciklama3.Location = new System.Drawing.Point(1630, 675);
            this.aciklama3.Multiline = true;
            this.aciklama3.Name = "aciklama3";
            this.aciklama3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.aciklama3.Size = new System.Drawing.Size(124, 39);
            this.aciklama3.TabIndex = 101;
            // 
            // etiket3
            // 
            this.etiket3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.etiket3.Location = new System.Drawing.Point(1630, 741);
            this.etiket3.Multiline = true;
            this.etiket3.Name = "etiket3";
            this.etiket3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.etiket3.Size = new System.Drawing.Size(124, 34);
            this.etiket3.TabIndex = 102;
            // 
            // baslik3
            // 
            this.baslik3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslik3.Location = new System.Drawing.Point(1630, 639);
            this.baslik3.Name = "baslik3";
            this.baslik3.Size = new System.Drawing.Size(124, 27);
            this.baslik3.TabIndex = 100;
            // 
            // ETİKET
            // 
            this.ETİKET.HeaderText = "ETİKET";
            this.ETİKET.Name = "ETİKET";
            this.ETİKET.Width = 250;
            // 
            // AÇIKLAMA
            // 
            this.AÇIKLAMA.HeaderText = "AÇIKLAMA";
            this.AÇIKLAMA.Name = "AÇIKLAMA";
            this.AÇIKLAMA.Width = 260;
            // 
            // BAŞLIK
            // 
            this.BAŞLIK.HeaderText = "BAŞLIK";
            this.BAŞLIK.Name = "BAŞLIK";
            this.BAŞLIK.Width = 300;
            // 
            // THUMBNAİL
            // 
            this.THUMBNAİL.HeaderText = "THUMBNAİL";
            this.THUMBNAİL.Name = "THUMBNAİL";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 70;
            // 
            // SAYI
            // 
            this.SAYI.HeaderText = "Sayı";
            this.SAYI.Name = "SAYI";
            this.SAYI.Width = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VideoSil);
            this.groupBox1.Controls.Add(this.yüklenilenvideo);
            this.groupBox1.Controls.Add(this.yüklenenvideoid);
            this.groupBox1.Location = new System.Drawing.Point(1755, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 213);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Youtube Video silme";
            // 
            // aciklamalink
            // 
            this.aciklamalink.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aciklamalink.FormattingEnabled = true;
            this.aciklamalink.ItemHeight = 19;
            this.aciklamalink.Location = new System.Drawing.Point(1633, 519);
            this.aciklamalink.Name = "aciklamalink";
            this.aciklamalink.Size = new System.Drawing.Size(95, 23);
            this.aciklamalink.TabIndex = 81;
            // 
            // uzantilivideo
            // 
            this.uzantilivideo.FormattingEnabled = true;
            this.uzantilivideo.Location = new System.Drawing.Point(1633, 211);
            this.uzantilivideo.Name = "uzantilivideo";
            this.uzantilivideo.Size = new System.Drawing.Size(93, 43);
            this.uzantilivideo.TabIndex = 92;
            // 
            // uzantisizvideo
            // 
            this.uzantisizvideo.FormattingEnabled = true;
            this.uzantisizvideo.Location = new System.Drawing.Point(1633, 271);
            this.uzantisizvideo.Name = "uzantisizvideo";
            this.uzantisizvideo.Size = new System.Drawing.Size(93, 43);
            this.uzantisizvideo.TabIndex = 105;
            // 
            // tags
            // 
            this.tags.FormattingEnabled = true;
            this.tags.Location = new System.Drawing.Point(1630, 328);
            this.tags.Name = "tags";
            this.tags.Size = new System.Drawing.Size(98, 56);
            this.tags.TabIndex = 106;
            // 
            // videoyeri2
            // 
            this.videoyeri2.Location = new System.Drawing.Point(1633, 70);
            this.videoyeri2.Multiline = true;
            this.videoyeri2.Name = "videoyeri2";
            this.videoyeri2.Size = new System.Drawing.Size(143, 24);
            this.videoyeri2.TabIndex = 107;
            this.videoyeri2.Text = "videoyeri2";
            // 
            // dailykanaltakip
            // 
            this.dailykanaltakip.FormattingEnabled = true;
            this.dailykanaltakip.Location = new System.Drawing.Point(1652, 781);
            this.dailykanaltakip.Name = "dailykanaltakip";
            this.dailykanaltakip.Size = new System.Drawing.Size(102, 30);
            this.dailykanaltakip.TabIndex = 106;
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadAktarToolStripMenuItem});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(144, 26);
            // 
            // uploadAktarToolStripMenuItem
            // 
            this.uploadAktarToolStripMenuItem.Name = "uploadAktarToolStripMenuItem";
            this.uploadAktarToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.uploadAktarToolStripMenuItem.Text = "Upload Aktar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 886);
            this.Controls.Add(this.uploadid);
            this.Controls.Add(this.kanalmailsifre);
            this.Controls.Add(this.dailykanalid);
            this.Controls.Add(this.dailybilgi);
            this.Controls.Add(this.videoyeri2);
            this.Controls.Add(this.dailykanaltakip);
            this.Controls.Add(this.dailyjson);
            this.Controls.Add(this.tags);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.uzantisizvideo);
            this.Controls.Add(this.uzantilivideo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.videoidler);
            this.Controls.Add(this.kimlik);
            this.Controls.Add(this.aciklama3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.etiket3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.baslik3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.yenile2);
            this.Controls.Add(this.kanallink);
            this.Controls.Add(this.aciklamalink);
            this.Controls.Add(this.searchetiket);
            this.Controls.Add(this.searchvideoid);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.apikey);
            this.Controls.Add(this.indirmelinki);
            this.Controls.Add(this.videoid);
            this.Controls.Add(this.kanalismi);
            this.Controls.Add(this.kod2);
            this.Controls.Add(this.kod1);
            this.Controls.Add(this.toplamvideo);
            this.Controls.Add(this.videoyeri);
            this.Name = "Form1";
            this.Text = "Dailymotion Assistant";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.contextMenuStrip4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox apikey;
        private System.Windows.Forms.TextBox indirmelinki;
        private System.Windows.Forms.TextBox videoid;
        private System.Windows.Forms.TextBox kanalismi;
        private System.Windows.Forms.TextBox kod2;
        private System.Windows.Forms.TextBox kod1;
        private System.Windows.Forms.TextBox toplamvideo;
        private System.Windows.Forms.TextBox videoyeri;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button Gönder;
        private System.Windows.Forms.ComboBox Kanallar;
        private System.Windows.Forms.TextBox aciklama;
        private System.Windows.Forms.TextBox baslik;
        private System.Windows.Forms.TextBox etiket;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button yenile;
        private System.Windows.Forms.Button indirr;
        private System.Windows.Forms.Button veri_cek;
        private System.Windows.Forms.TextBox aciklama2;
        private System.Windows.Forms.TextBox etiket2;
        private System.Windows.Forms.TextBox baslik2;
        private System.Windows.Forms.TextBox indirlink;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button ApiAl;
        private System.Windows.Forms.Button yenile2;
        private System.Windows.Forms.ComboBox Kanallar2;
        private System.Windows.Forms.TextBox kanallink;
        private System.Windows.Forms.Timer Dosyayaz;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox searchetiket;
        private System.Windows.Forms.ListBox searchvideoid;
        private System.Windows.Forms.CheckBox aciklamalinksil;
        private System.Windows.Forms.CheckBox etiketözgün;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox yüklenenvideoid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aktarToolStripMenuItem;
        private System.Windows.Forms.Button onayla;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Timer durumguncelle;
        private System.Windows.Forms.Button onaykaldır;
        private System.Windows.Forms.TextBox kimlik;
        private System.Windows.Forms.ComboBox gizlilik;
        private System.Windows.Forms.ComboBox kategori;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button VideoSil;
        private System.Windows.Forms.ListBox yüklenilenvideo;
        private System.Windows.Forms.ListBox videoidler;
        private System.Windows.Forms.TextBox aciklama3;
        private System.Windows.Forms.TextBox etiket3;
        private System.Windows.Forms.TextBox baslik3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ListBox linkileindir;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label videosayi;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.CheckBox aciklamalinksil2;
        private System.Windows.Forms.CheckBox etiketözgünlestir2;
        private System.Windows.Forms.TextBox indirlink2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn ETİKET;
        private System.Windows.Forms.DataGridViewTextBoxColumn AÇIKLAMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAŞLIK;
        private System.Windows.Forms.DataGridViewImageColumn THUMBNAİL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SAYI;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStripMenuItem gitToolStripMenuItem;
        private System.Windows.Forms.Button Dailyupload;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem aktarToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox aciklamalink;
        private System.Windows.Forms.ListBox uzantilivideo;
        private System.Windows.Forms.ListBox uzantisizvideo;
        private System.Windows.Forms.ListBox tags;
        private System.Windows.Forms.TextBox videoyeri2;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ListBox dailyjson;
        private System.Windows.Forms.ListBox dailybilgi;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ListBox dailykanaltakip;
        private System.Windows.Forms.ComboBox dailykanalid;
        private System.Windows.Forms.ListBox kanalmailsifre;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn KANAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn GÖRÜNTÜLEME;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAKİPÇİSAYISI;
        private System.Windows.Forms.DataGridViewTextBoxColumn VİDEOSAYISI;
        private System.Windows.Forms.DataGridViewTextBoxColumn KATEGORİ;
        private System.Windows.Forms.DataGridViewTextBoxColumn GEÇENGÜN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GEÇENHAFTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn GEÇENAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOPLAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ÜLKE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DURUM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn VİDEOİD;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAŞŞLIK;
        private System.Windows.Forms.DataGridViewTextBoxColumn AÇIKLAMAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ETİKETT;
        private System.Windows.Forms.DataGridViewTextBoxColumn İNDİRMEE;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem uploadAktarToolStripMenuItem;
        private System.Windows.Forms.TextBox uploadid;
        private System.Windows.Forms.TextBox yüklemegeridöngü;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.Windows.Forms.ToolStripMenuItem videoyaGitToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn UploadURL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hata;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sayı;
        private System.Windows.Forms.DataGridViewTextBoxColumn VideoIdd;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOWN;
        private System.Windows.Forms.DataGridViewTextBoxColumn UP;
        private System.Windows.Forms.DataGridViewTextBoxColumn UploadURLL;
        private System.Windows.Forms.DataGridViewTextBoxColumn HATAA;
        private System.Windows.Forms.Button button12;
    }
}

