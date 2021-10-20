using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Auth.OAuth2.Flows;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.OleDb;
using System.Windows.Threading;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Web;
using HtmlAgilityPack;
using System.Net.Http;
using Newtonsoft.Json;
using System.Configuration;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static void waitForPageToBeReady(IWebDriver driver, int time)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            for (int i = 0; i < 400; i++)
            {
                try
                {
                    Thread.Sleep(time);
                }
                catch (ThreadInterruptedException e) { }
                //To check page ready state.

                if (js.ExecuteScript("return document.readyState").ToString().Equals("complete"))
                {
                    break;
                }
            }
        }
        OleDbCommand cmd;
        OleDbCommand cmd2;
        public OleDbConnection baglanti()
        {
            OleDbConnection bag = new OleDbConnection("Provider = Microsoft.ACE.Oledb.12.0; Data Source = " + Application.StartupPath + @"\Ana Dosyalar\Dosyalar\" + "Videolar.accdb");
            cmd = new OleDbCommand();
            bag.Open();
            return bag;
        }
        public OleDbConnection baglan()
        {
            OleDbConnection bag2 = new OleDbConnection("Provider = Microsoft.ACE.Oledb.12.0; Data Source = " + Application.StartupPath + @"\Ana Dosyalar\Kanallar\" + "Kanallar.accdb");
            cmd2 = new OleDbCommand();
            bag2.Open();
            return bag2;
        }
        private void VideoData()
        {
            try
            {
                OleDbConnection bag = baglanti();
                DataSet dtst = new DataSet();
                OleDbDataAdapter adtr = new OleDbDataAdapter("select * From videolar", bag);
                adtr.Fill(dtst, "videolar");
                dataGridView1.DataSource = dtst.Tables["videolar"];
                bag.Close();

            }
            catch
            {
            }
        }
        private void YüklenmeDurumu()
        {
            try
            {
                OleDbConnection bag2 = new OleDbConnection("Provider = Microsoft.ACE.Oledb.12.0; Data Source = " + Application.StartupPath + @"\Ana Dosyalar\Dosyalar\" + "Videolar.accdb");
                cmd2 = new OleDbCommand();
                bag2.Open();
                cmd.Connection = bag2;
                cmd.CommandText = "update videolar set YüklenmeDurumu='%100' where baslikk='" + baslik.Text + "'";
                cmd.ExecuteNonQuery();
                bag2.Close();
                VideoData();
            }
            catch
            {
            }
        }
        private void Kanallarr()
        {
            try
            {
                OleDbConnection bag2 = baglan();
                DataSet dtst2 = new DataSet();
                OleDbDataAdapter adtr2 = new OleDbDataAdapter("select * From Kanallar", bag2);
                adtr2.Fill(dtst2, "Kanallar");
                dataGridView2.DataSource = dtst2.Tables["Kanallar"];
                adtr2.Dispose();
                bag2.Close();

            }
            catch (Exception)
            {
            }
        }
        private void VideoDataKaydet2()
        {
            try
            {
                string firstColum = baslik2.Text;
                string secondColum = aciklama2.Text;
                string[] row = { firstColum, secondColum };
                dataGridView1.Rows.Add(row);
            }
            catch
            {


            }
        }
        private void VideoDataKaydet()
        {
            try
            {
                OleDbConnection bag = baglanti();
                OleDbCommand cmd = new OleDbCommand("insert into videolar (baslikk, aciklamaa, etikett) values (@baslikk,@aciklamaa,@etikett) ", bag);
                cmd.Parameters.Add("@baslikk", baslik2.Text);
                cmd.Parameters.Add("@aciklamaa", aciklama2.Text);
                cmd.Parameters.Add("@etikett", etiket2.Text);
                cmd.ExecuteNonQuery();
                DataSet dtst = new DataSet();
                OleDbDataAdapter adtr = new OleDbDataAdapter("select * From videolar", bag);
                adtr.Fill(dtst, "videolar");
                System.Threading.Thread.Sleep(1000);
                //dataGridView1.DataSource = dtst.Tables["videolar"];
                adtr.Dispose();
                cmd.Dispose();
                bag.Close();
                bag.Dispose();





                //VideoData();

            }
            catch
            {


            }
        }
        private void VideoDataSil()
        {
            try
            {
                if (MessageBox.Show("Veriyi silmek istiyormusunuz ?", "Uyarı !", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    OleDbConnection bag = new OleDbConnection("Provider = Microsoft.ACE.Oledb.12.0; Data Source = " + Application.StartupPath + @"\Ana Dosyalar\Dosyalar\" + "Videolar.accdb");
                    OleDbCommand kmt = new OleDbCommand();
                    bag.Open();
                    kmt.Connection = bag;
                    kmt.CommandText = "DELETE FROM videolar WHERE kimlik=@kimlik";
                    kmt.Parameters.AddWithValue("@kimlik", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    kmt.ExecuteNonQuery();
                    bag.Close();
                    VideoData();
                }
                else
                {
                }
            }
            catch (Exception)
            {
            }
        }
        private void VideoDataGüncelle()
        {
            MessageBox.Show("yapılacak");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            VideoData();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            VideoDataKaydet();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            VideoDataSil();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            VideoDataGüncelle();
        }












        int i = 0;
        string videoyolu;
        private void Gönder_Click(object sender, EventArgs e)
        {
            string id = uploadid.Text;
            try
            {

                for (int i = 0; i < uzantilivideo.Items.Count; i++)
                {
                    if (uzantilivideo.Items[i].ToString().ToLower().Contains(id.ToLower()))
                    {
                         videoyolu = uzantilivideo.Items[i].ToString();
                    }
                }
                System.IO.FileInfo ff = new System.IO.FileInfo(videoyolu);
                videoyeri.Text = Application.StartupPath + "\\Ana Dosyalar\\Atılacak Videolar\\" + uploadid.Text + ff.Extension;


                //FileInfo fi = new FileInfo(videoyeri.Text);
                //long dosyaBoyutu = fi.Length;
                //videoboyut = Convert.ToInt32(dosyaBoyutu);
                dataGridView6.Rows.Add(Kanallar.Text,baslik.Text,aciklama.Text,etiket.Text);
            }
            catch
            {
            }
            Thread thead = new Thread(() =>
            {
                DailyUpload().Wait();
            });
            thead.IsBackground = true;
            thead.Start();

        }
        public class ExtendedWebClient : WebClient
        {
            public int Timeout { get; set; }
            public new bool AllowWriteStreamBuffering { get; set; }

            protected override WebRequest GetWebRequest(Uri address)
            {
                var request = base.GetWebRequest(address);
                if (request != null)
                {
                    request.Timeout = Timeout;
                    var httpRequest = request as HttpWebRequest;
                    if (httpRequest != null)
                    {
                        httpRequest.AllowWriteStreamBuffering = AllowWriteStreamBuffering;
                    }
                }
                return request;
            }

            public ExtendedWebClient()
            {
                Timeout = 100000; // the standard HTTP Request Timeout default
            }
        }
        private async Task DailyUpload()
        {
            try
            {
                string link = videoyeri.Text; 

                /////////////////////////////// GetAccessToken//////////////////////////////

                var request = WebRequest.Create("https://api.dailymotion.com/oauth/token");
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";

                var requestString = String.Format("grant_type=password&client_id={0}&client_secret={1}&username={2}&password={3}",
                    HttpUtility.UrlEncode(dailybilgi.Items[2].ToString()),
                    HttpUtility.UrlEncode(dailybilgi.Items[3].ToString()),
                    HttpUtility.UrlEncode(dailybilgi.Items[0].ToString()),
                    HttpUtility.UrlEncode(dailybilgi.Items[1].ToString()));

                var requestBytes = Encoding.UTF8.GetBytes(requestString);
                var requestStream = request.GetRequestStream();
                requestStream.Write(requestBytes, 0, requestBytes.Length);
                var response = request.GetResponse();
                var responseStream = response.GetResponseStream();
                string responseString;
                using (var reader = new StreamReader(responseStream))
                {
                    responseString = reader.ReadToEnd();
                }
                dynamic vericek = SimpleJson.DeserializeObject(responseString);
                var accessToken = (vericek["access_token"]);
                /////////////////////////       GetFileUploadUrl                   /////////////////////

                var client2 = new ExtendedWebClient();
                client2.Headers.Add("Authorization", "OAuth " + accessToken);
                client2.Timeout = Timeout.Infinite;
                client2.AllowWriteStreamBuffering = false;


                var urlResponse = client2.DownloadString("https://api.dailymotion.com/file/upload");

                dynamic vericek2 = SimpleJson.DeserializeObject(urlResponse);

                var uploadUrl = (vericek2["upload_url"]);

                ////////////////////////          GetFileUploadResponse                  ///////////////
                
                //client2.UploadFileAsync(new Uri(uploadUrl), link);
                
                client2.UploadProgressChanged += WebClientUploadProgressChanged;
                client2.UploadFileCompleted += WebClientUploadCompleted;



                {
                    TaskCompletionSource<int> tcs = new TaskCompletionSource<int>();
                    client2.UploadProgressChanged += WebClientUploadProgressChanged;

                    // this sets the task to completed when the upload finished
                    client2.UploadFileCompleted += (sender, e) => tcs.SetResult(0);

                    client2.UploadFileAsync(new Uri(uploadUrl), link);
                    await tcs.Task.ConfigureAwait(false);
                }


                

                dynamic vericek3 = SimpleJson.DeserializeObject(yüklemegeridöngü.Text);

                var response2 = (vericek3["url"]);

                //////////////////        PublishVideo        //////////////////////////////

                {

                    var request2 = WebRequest.Create("https://api.dailymotion.com/me/videos?url=" + HttpUtility.UrlEncode(response2));
                    request2.Method = "POST";
                    request2.ContentType = "application/x-www-form-urlencoded";
                    request2.Headers.Add("Authorization", "OAuth " + accessToken);

                    var requestString2 = String.Format("title={0}&description={1}&tags={2}&channel={3}&published={4}",
                        HttpUtility.UrlEncode(baslik.Text),
                        HttpUtility.UrlEncode(aciklama.Text),
                        HttpUtility.UrlEncode(etiket.Text),
                        HttpUtility.UrlEncode("news"),
                        HttpUtility.UrlEncode("true"));

                    var requestBytes2 = Encoding.UTF8.GetBytes(requestString2);

                    var requestStream2 = request2.GetRequestStream();

                    requestStream2.Write(requestBytes2, 0, requestBytes2.Length);

                    var response3 = request2.GetResponse();

                    var responseStream2 = response3.GetResponseStream();
                    string responseString3;
                    using (var reader = new StreamReader(responseStream2))
                    {
                        responseString3 = reader.ReadToEnd();
                    }

                    dynamic vericek4 = SimpleJson.DeserializeObject(responseString3);

                    var videoid = (vericek4["id"]);

                    int sonsatır = dataGridView6.RowCount - 2;
                    dataGridView6.Rows[sonsatır].Cells[5].Value = videoid;

                }

            }
            catch (Exception hata)
            {
                int sonsatır = dataGridView6.RowCount - 2;
                dataGridView6.Rows[sonsatır].Cells[6].Value = ("Durum: Bu kanalın günlük yükleme limiti dolu. Hata kodu: " + hata);
            }
        }
       
        void WebClientUploadProgressChanged(object sender, UploadProgressChangedEventArgs e)
        {
            int sonsatır = dataGridView6.RowCount - 2;
            dataGridView6.Rows[sonsatır].Cells[4].Value = 2 * e.ProgressPercentage;
        }
        void WebClientUploadCompleted(object sender, UploadFileCompletedEventArgs e)
        {
            try
            {
                int sonsatır = dataGridView6.RowCount - 2;
                dataGridView6.Rows[sonsatır].Cells[4].Value = "100";

                var reply = System.Text.Encoding.UTF8.GetString(e.Result);
                yüklemegeridöngü.Text = reply;
            }
            catch
            {
            }
        }

        void WebClientUploadProgressChanged2(object sender, UploadProgressChangedEventArgs e)
        {
            try
            {
                dataGridView3.Rows[f].Cells[7].Value = (2 * e.ProgressPercentage);
            }
            catch
            {
            }
        }
        void WebClientUploadCompleted2(object sender, UploadFileCompletedEventArgs e)
        {
            try
            {
                dataGridView3.Rows[f].Cells[7].Value = "100";

                var reply = System.Text.Encoding.UTF8.GetString(e.Result);
                yüklemegeridöngü.Text = reply;
            }
            catch
            {
            }
        }




        private void etiket2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (etiket2.TextLength == 400)
            {
                e.Handled = true;
            }
        }
        private void yenile_Click(object sender, EventArgs e)
        {
            Kanallar.Items.Clear();
            string[] dosyalar = Directory.GetFiles(Application.StartupPath + "\\Ana Dosyalar\\Kanal Api\\");
            foreach (string dosya in dosyalar)
            {
                Kanallar.Items.Add(System.IO.Path.GetFileNameWithoutExtension(dosya));

            }
            Kanallar.SelectedIndex = 0;
        }

        private void ApiAl_Click(object sender, EventArgs e)
        {
            Api_Al();
        }
        string client_id;
        private void SetText(string Text)
        {
            if (this.InvokeRequired)
                this.Invoke((Action)(() => { SetText(Text); }));
            else
                client_id = Text;
        }
        private void Api_Al()
        {
            try
            {
                ChromeOptions options = new ChromeOptions();
                //options.AddArguments("--incognito");
                options.AddArguments("start-maximized");
                options.AddArguments("disable-infobars");
                options.AddArguments("--js-flags=--expose-gc");
                options.AddArguments("--enable-precise-memory-info");
                options.AddArguments("--disable-popup-blocking");
                options.AddArguments("--disable-default-apps");
                IWebDriver driver = new ChromeDriver(Application.StartupPath, options);

                System.Threading.Thread.Sleep(3000);
                driver.Manage().Cookies.DeleteAllCookies();
                driver.Navigate().GoToUrl("https://console.developers.google.com");
                System.Threading.Thread.Sleep(3000);

                IWebElement Giris = driver.FindElement(By.Id("identifierId"));
                Giris.SendKeys(mail.Text);
                Giris.FindElement(By.XPath("//div[@id='identifierNext']/content/span")).Click();
                System.Threading.Thread.Sleep(3000);
                driver.FindElement(By.Name("password")).SendKeys(sifre.Text);
                System.Threading.Thread.Sleep(3000);
                driver.FindElement(By.XPath("//div[@id='passwordNext']/content/span")).Click();
                System.Threading.Thread.Sleep(3000);
                //driver.Navigate().GoToUrl("https://console.developers.google.com/apis/dashboard");
                //System.Threading.Thread.Sleep(3000);
                //try
                //{
                //    driver.FindElement(By.XPath("//md-dialog-content[@id='dialogContent_0']/div/form/tos-checkboxes/div/span/fieldset/div/div/label[2]/span")).Click();
                //    System.Threading.Thread.Sleep(3000);
                //    driver.FindElement(By.XPath("//md-dialog-content[@id='dialogContent_0']/div/form/tos-checkboxes/fieldset/div/div/label/span")).Click();
                //    System.Threading.Thread.Sleep(3000);
                //    driver.FindElement(By.XPath("//pan-modal-action[2]/a/span/span")).Click();
                //    System.Threading.Thread.Sleep(3000);
                //}
                //catch (Exception)
                //{
                //}
                //driver.Navigate().GoToUrl("https://console.developers.google.com/projectcreate?previousPage=%2Fprojectselector%2Fapis%2Flibrary%2Fyoutube.googleapis.com");
                //System.Threading.Thread.Sleep(4000);
                //driver.FindElement(By.XPath("//div[@id='p6ntest-project-create-page']/cfc-panel-body/div/div/proj-creation-form/form/button/span")).Click();
                //System.Threading.Thread.Sleep(20000);
                //driver.FindElement(By.XPath("//button[@id='p6n-mp-enable-api-button']/span")).Click();
                //System.Threading.Thread.Sleep(10000);

                ///myproject yazılacak ürün adına
                driver.Navigate().GoToUrl("https://console.developers.google.com/apis/credentials/consent?createClient&");
                System.Threading.Thread.Sleep(5000);
                driver.FindElement(By.Id("p6n-consent-product-name")).SendKeys(OpenQA.Selenium.Keys.Control + "a");
                driver.FindElement(By.Id("p6n-consent-product-name")).SendKeys("myprojectt");
                System.Threading.Thread.Sleep(2000);
                driver.FindElement(By.XPath("//jfk-button[@id='api-consent-save']/span")).Click();
                System.Threading.Thread.Sleep(5000);
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='PlayStation 4'])[1]/following::span[1]")).Click();
                System.Threading.Thread.Sleep(4000);
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Ad gerekli'])[1]/following::span[1]")).Click();
                System.Threading.Thread.Sleep(4000);
                //driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='OAuth istemcisi'])[1]/following::md-icon[1]")).Click();
                System.Threading.Thread.Sleep(3000);

                driver.FindElement(By.Name("cancel")).Click();
                System.Threading.Thread.Sleep(2000);
                
                json2 = driver.FindElement(By.XPath("/html/body/pan-shell/div/div[3]/div/div[1]/pan-upgrade-panel-container/div/ng-transclude/div[2]/div/div/ng-transclude/div/div[3]/md-content/div/div[2]/div/section/table/tbody/tr/td[6]/a")).GetAttribute("Content");
                System.Threading.Thread.Sleep(4000);

                dosyayaYaz();
                //System.Threading.Thread.Sleep(4000);
                //Yüklenilen();
                //System.Threading.Thread.Sleep(5000);
                //SendKeys.Send("{F6}");
                //System.Threading.Thread.Sleep(1000);
                //SendKeys.SendWait("^(c)");
                //    System.Threading.Thread.Sleep(3000);

                //    string youtubelink = Clipboard.GetText();
                //    System.Threading.Thread.Sleep(3000);

                //    driver.Navigate().GoToUrl(youtubelink);
                //    System.Threading.Thread.Sleep(4000);
                //    driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='myprojectt'])[1]/following::div[5]")).Click();
                //    System.Threading.Thread.Sleep(3000);
                //    driver.FindElement(By.XPath("//*[@id='submit_approve_access']/content/span")).Click();


                System.Threading.Thread.Sleep(4000);
                Process[] p;
                p = Process.GetProcessesByName("chrome");
                if (p.Length > 0)
                {
                    foreach (Process process in p)
                    {
                        process.Kill();
                    }
                    Process[] p2;
                    p2 = Process.GetProcessesByName("reset"); if (p2.Length > 0)
                    {
                        foreach (Process process in p2)
                        {
                            process.Kill();
                        }
                    }
                }

                driver.Close();
            }
            catch
            {
            }
        }
        private void dosyayaYaz()
        {
            string dosya_yolu = Application.StartupPath + "\\Ana Dosyalar\\Kanal Api\\" + mail.Text + ".json";
            //İşlem yapacağımız dosyanın yolunu belirtiyoruz.
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(json2);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        private void yenile2_Click(object sender, EventArgs e)
        {
            Kanallar2.Items.Clear();
            DirectoryInfo di = new DirectoryInfo(Application.StartupPath + "\\Kanal Api\\");
            FileInfo[] dosyalar = di.GetFiles();
            foreach (FileInfo var in dosyalar)

            {
                Kanallar2.Items.Add(var);
            }
        }
        private void DurumGüncelle()
        {
            try
            {
                for (int j = 0; j < dataGridView2.Rows.Count - 1; j++)
                {
                    DataGridViewCellStyle renk = new DataGridViewCellStyle();
                    if (Convert.ToInt32(dataGridView2.Rows[j].Cells["Durum"].Value) > 0)
                    {
                        renk.BackColor = Color.YellowGreen;
                    }
                    else if (Convert.ToInt32(dataGridView2.Rows[j].Cells["Durum"].Value) == 0)
                    {
                        renk.BackColor = Color.Red;
                    }
                    dataGridView2.Rows[j].DefaultCellStyle = renk;
                }
                kimlik.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                mail.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                sifre.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            }
            catch
            {
            }
        }
        int videoboyut;
        private void Form1_Load(object sender, EventArgs e)
        {
            //listView1.View = View.Details;
            //listView1.FullRowSelect = true;

            //listView1.Columns.Add("VideoId", 110);
            //listView1.Columns.Add("Başlık", 300);
            //listView1.Columns.Add("Açıklama", 350);
            //listView1.Columns.Add("Etiket", 300);
            //listView1.Columns.Add("İndirme", 110);

            dataGridView3.RowTemplate.MinimumHeight = 50;
            dataGridView4.RowTemplate.MinimumHeight = 40;
            dataGridView4.AllowUserToAddRows = false;

            VideoData();
            Kanallarr();

            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[1].Width = 317;
            dataGridView1.Columns[2].Width = 280;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 128;
            dataGridView1.Columns[5].Width = 143;


            dataGridView2.Columns[0].Width = 40;
            dataGridView2.Columns[1].Width = 250;
            dataGridView2.Columns[2].Width = 220;
            dataGridView2.Columns[3].Width = 120;

            kategori.SelectedIndex = 0;
            gizlilik.SelectedIndex = 0;

            //durumguncelle.Start();
            ToolTip Aciklama = new ToolTip();
            Aciklama.IsBalloon = true;

            Aciklama.SetToolTip(etiketözgün, "Eğer videoda etiket bulunmuyorsa, başlıkla uyumlu 50 video arasından etiket bulur.");


            Process[] p;
            p = Process.GetProcessesByName("youtube-dl");
            if (p.Length > 0)
            {
                foreach (Process process in p)
                {
                    process.Kill();
                }
                Process[] p2;
                p2 = Process.GetProcessesByName("reset"); if (p2.Length > 0)
                {
                    foreach (Process process in p2)
                    {
                        process.Kill();
                    }
                }
            }
            try
            {
                Control.CheckForIllegalCrossThreadCalls = false;
                Kanallar.Items.Clear();
                Kanallar2.Items.Clear();
                string[] dosyalar = Directory.GetFiles(Application.StartupPath + "\\Ana Dosyalar\\Kanal Api\\");
                foreach (string dosya in dosyalar)
                {
                    Kanallar.Items.Add(System.IO.Path.GetFileNameWithoutExtension(dosya));
                    Kanallar2.Items.Add(System.IO.Path.GetFileNameWithoutExtension(dosya));

                }
                Kanallar.SelectedIndex = 0;
                Kanallar2.SelectedIndex = 0;
            }
            catch
            {
            }
            


            //////////////
        }
        
        int z;
        string ubaslik;
        string uaciklama;
        string utag;
        
        string json;
        string json2;
        private void VideoMetaData()
        {
            baslik2.Text = "";
            aciklama2.Text = "";
            etiket2.Text = "";

            tags.Items.Clear();
            try
            {
                //progressBar1.Visible = true;
                videoid.Text = indirlink.Text;
                videoid.Text = videoid.Text.Replace("https://", "");
                videoid.Text = videoid.Text.Replace("http://", "");
                videoid.Text = videoid.Text.Replace("www.youtube.com/watch?v=", "");
                using (WebClient wc = new WebClient())
                {
                    wc.Encoding = System.Text.Encoding.UTF8;
                    json = wc.DownloadString(string.Format("https://www.googleapis.com/youtube/v3/videos?part=snippet&id={0}&key={1}", videoid.Text, apikey.Text));
                }
                dynamic vericek = SimpleJson.DeserializeObject(json);
                baslik2.Text = vericek["items"][0]["snippet"]["title"];
                aciklama2.Text = vericek["items"][0]["snippet"]["description"];
                aciklama2.Text = aciklama2.Text.Replace("\n", " ");
                string thumbnails = vericek["items"][0]["snippet"]["thumbnails"]["default"]["url"];
                //string thumbnails = vericek["items"][0]["snippet"]["thumbnails"]["medium"]["url"];


                pictureBox1.ImageLocation = thumbnails;
                for (int i = 0; i < 15; i++)
                {
                    tags.Items.Add(vericek["items"][0]["snippet"]["tags"][i]);
                }

                for (int i = 0; i < tags.Items.Count; i++)
                {
                    if ((i + 1) < tags.Items.Count)
                        etiket2.Text += tags.Items[i] + ",";
                    else
                        etiket2.Text += tags.Items[i];
                }
            }
            catch
            {
            }
            if (String.IsNullOrEmpty(etiket2.Text) || String.IsNullOrWhiteSpace(etiket2.Text))
            {
                if (etiketözgün.Checked == true)
                {
                    etiket2.Text = "Etiket çekiliyor bekleyin.";
                    Thread thead = new Thread(() =>
                    {
                        search().Wait();
                    });
                    thead.Start();
                }
            }
            if (aciklamalinksil.Checked == true)
            {
                aciklamalink.Items.Clear();
                foreach (Match item in Regex.Matches(aciklama2.Text, @"(http|ftp|https):\/\/([\w\-_]+(?:(?:\.[\w\-_]+)+))([\w\-\.,@?^=%&amp;:/~\+#]*[\w\-\@?^=%&amp;/~\+#])?"))
                {
                    aciklamalink.Items.Add(item.Value);
                }
                for (int i = 0; i < aciklamalink.Items.Count; i++)
                {
                    aciklama2.Text = aciklama2.Text.Replace(aciklamalink.Items[i].ToString(), "");
                }
            }
            baslik2.Text = baslik2.Text.Replace("?", "");
            baslik.Text = baslik.Text.Replace("?", "");
        }
        private async Task VideoMetaData2()
        {
            for (int t = 0; t < videoidler.Items.Count; t++)
            {
                baslik3.Text = "";
                aciklama3.Text = "";
                etiket3.Text = "";

                tags.Items.Clear();
                try
                {
                    //progressBar1.Visible = true;
                    videoid.Text = indirlink.Text;
                    videoid.Text = videoid.Text.Replace("https ://", "");
                    videoid.Text = videoid.Text.Replace("http://", "");
                    videoid.Text = videoid.Text.Replace("www.youtube.com/watch?v=", "");
                    using (WebClient wc = new WebClient())
                    {
                        wc.Encoding = System.Text.Encoding.UTF8;
                        json = wc.DownloadString(string.Format("https://www.googleapis.com/youtube/v3/videos?part=snippet&id={0}&key={1}", videoidler.Items[t], apikey.Text));
                    }
                    dynamic vericek = SimpleJson.DeserializeObject(json);
                    baslik3.Text = vericek["items"][0]["snippet"]["title"];
                    aciklama3.Text = vericek["items"][0]["snippet"]["description"];
                    aciklama3.Text = aciklama3.Text.Replace("\n", " ");
                    //string thumbnails = vericek["items"][0]["snippet"]["thumbnails"]["default"]["url"];
                    string thumbnails = vericek["items"][0]["snippet"]["thumbnails"]["medium"]["url"];
                    
                    using (WebClient client = new WebClient())
                    {
                        client.DownloadFile(thumbnails, Application.StartupPath + "\\Ana Dosyalar\\Dosyalar\\Thumbnail\\" + videoidler.Items[t]+".jpg");
                    }
                    GenerateThumbImage(Application.StartupPath + "\\Ana Dosyalar\\Dosyalar\\Thumbnail\\" + videoidler.Items[t] + ".jpg", Application.StartupPath + "\\Ana Dosyalar\\Dosyalar\\Thumbnail\\2" + videoidler.Items[t] + ".jpg", 75, 75);


                    for (int i = 0; i < 15; i++)
                    {
                        tags.Items.Add(vericek["items"][0]["snippet"]["tags"][i]);
                    }

                    for (int i = 0; i < tags.Items.Count; i++)
                    {
                        if ((i + 1) < tags.Items.Count)
                            etiket3.Text += tags.Items[i] + ",";
                        else
                            etiket3.Text += tags.Items[i];
                    }
                }
                catch
                {
                }
                if (String.IsNullOrEmpty(etiket3.Text) || String.IsNullOrWhiteSpace(etiket3.Text))
                {
                    if (etiketözgün.Checked == true)
                    {
                        etiket3.Text = "Etiket çekiliyor bekleyin.";
                        Thread thead = new Thread(() =>
                        {
                            search2().Wait();
                        });
                        thead.Start();
                    }
                }
                if (aciklamalinksil.Checked == true)
                {
                    aciklamalink.Items.Clear();
                    foreach (Match item in Regex.Matches(aciklama3.Text, @"(http|ftp|https):\/\/([\w\-_]+(?:(?:\.[\w\-_]+)+))([\w\-\.,@?^=%&amp;:/~\+#]*[\w\-\@?^=%&amp;/~\+#])?"))
                    {
                        aciklamalink.Items.Add(item.Value);
                    }
                    for (int i = 0; i < aciklamalink.Items.Count; i++)
                    {
                        aciklama3.Text = aciklama3.Text.Replace(aciklamalink.Items[i].ToString(), "");
                    }
                }
                
                baslik3.Text = baslik3.Text.Replace("?", "");
                baslik.Text = baslik.Text.Replace("?", "");
                do
                {
                    System.Threading.Thread.Sleep(1400);

                }
                while (etiket3.Text == "Etiket çekiliyor bekleyin.");
                try
                {
                    dataGridView3.Rows.Add((t + 1).ToString(), videoidler.Items[t] ,Image.FromFile(Application.StartupPath + "\\Ana Dosyalar\\Dosyalar\\Thumbnail\\2" + videoidler.Items[t] + ".jpg"), baslik3.Text, aciklama3.Text, etiket3.Text);

                }
                catch
                {
                    dataGridView3.Rows.Add((t + 1).ToString(), videoidler.Items[t], Image.FromFile(Application.StartupPath +"\\hata.png"), baslik3.Text, aciklama3.Text, etiket3.Text);
                }
                videosayi.Text = "Toplam Video: " + videoidler.Items.Count.ToString() + "\\" + (videoidler.Items.Count - (t+1)).ToString();
            }
        }

        
        private void veri_cek_Click(object sender, EventArgs e)
        {
            if (indirlink.Text.Contains("channel") == true || indirlink.Text.Contains("user") == true)
            {
                if (MessageBox.Show("Kanalı çekmek istiyor musunuz ?", "Uyarı!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Thread thead = new Thread(() =>
                    {
                        videolinkler().Wait();
                    });
                    thead.IsBackground = true;
                    thead.Start();
                }
                else
                {
                }
            }
            else
            {
                VideoMetaData();
            }
        }

        private void indirr_Click(object sender, EventArgs e)
        { 
            Thread thead = new Thread(() =>
            {
                indir().Wait();
            });
            thead.IsBackground = true;
            thead.Start();
        }
        public async Task indir()
        {
            try
            {
                string videoid = indirlink.Text;
                videoid = videoid.Replace("http://", "");
                videoid = videoid.Replace("https://", "");
                videoid = videoid.Replace("www.youtube.com", "");
                videoid = videoid.Replace("/watch?v=", "");

                string[] kanal = Regex.Split(videoid, "&");
                videoid = kanal[0];

                indirmelinki.Text = kod1.Text + Application.StartupPath + "\\Ana Dosyalar\\Atılacak Videolar\\" + kod2.Text + "youtube.com/watch?v="+ videoid;
                
                ProcessStartInfo s = new ProcessStartInfo
                {
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    LoadUserProfile = true,
                    CreateNoWindow = true,
                    FileName = Application.StartupPath + "\\Ana Dosyalar\\Dosyalar\\youtube-dl.exe",
                    Arguments = indirmelinki.Text

                };

                dataGridView5.Rows.Add(videoid, baslik2.Text, aciklama2.Text, etiket2.Text);


                Process p = new Process { StartInfo = s, EnableRaisingEvents = true };
                if (p.Start())
                {
                    StreamReader ProcessReader = p.StandardOutput;
                    while (!p.StandardOutput.EndOfStream)
                    {
                        var reading = ProcessReader.ReadLine().Replace(" ", "");
                        try
                        {
                            int perc = reading.IndexOf('%');
                            int cl = reading.IndexOf(']') + 1;
                            var percentage = reading.Substring(cl, (perc - cl));
                            int sonsatır = dataGridView5.RowCount-2;
                            dataGridView5.Rows[sonsatır].Cells[4].Value = percentage.ToString();
                        }
                        catch
                        {
                        }

                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata + "");
            }
        }
        private void Dosyayaz_Tick(object sender, EventArgs e)
        {
            Dosyayaz.Stop();
        }

        private void Kanallar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                uzantilivideo.Items.Clear();
                uzantisizvideo.Items.Clear();
                string[] dosyalar = Directory.GetFiles(Application.StartupPath + "\\Ana Dosyalar\\Atılacak Videolar\\");
                foreach (string dosya in dosyalar)
                {
                    uzantilivideo.Items.Add(dosya);
                    uzantisizvideo.Items.Add(System.IO.Path.GetFileNameWithoutExtension(dosya));
                }
            }
            catch (Exception)
            {
            }

            try
            {
                dailybilgi.Items.Clear();
                string json = File.ReadAllText(Application.StartupPath + "\\Ana Dosyalar\\Kanal Api\\" + Kanallar.Text + ".json");
                dynamic vericek = SimpleJson.DeserializeObject(json);
                dailybilgi.Items.Add(vericek["Dailymotion"]["Mail"]);
                dailybilgi.Items.Add(vericek["Dailymotion"]["Sifre"]);
                dailybilgi.Items.Add(vericek["Dailymotion"]["Key"]);
                dailybilgi.Items.Add(vericek["Dailymotion"]["Secret"]);
                dailybilgi.Items.Add(vericek["Dailymotion"]["Callbackurl"]);
            }
            catch
            {
            }
        }
        private void ApiKanal_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string deger;
            //StreamReader oku = File.OpenText(Application.StartupPath + "\\Ana Dosyalar\\Kanallar\\" + Kanallar.Text + ".txt");
            //deger = oku.ReadToEnd();
            //oku.Close();

            //int uzun, poz;
            //string mail, sifre;

            //uzun = deger.Length;
            //poz = deger.IndexOf(",", 0, uzun);

            //mail = deger.Substring(0, poz);
            //sifre = deger.Substring(poz + 1, uzun - (poz + 1));

            //this.mail.Text = mail;
            //this.sifre.Text = sifre;
        }
        string clientid, clientsecret;
    
       
        
        void Kaldır()
        {
            //baslik.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //aciklama.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //etiket.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            try
            {
                foreach (DataGridViewRow item in this.dataGridView3.SelectedRows)
                {
                    dataGridView3.Rows.RemoveAt(item.Index);
                }
                int sayi = dataGridView3.RowCount + 1;
                for (int i = 1; i < sayi; i++)
                {
                    dataGridView3.Rows[i - 1].Cells[0].Value = i;

                }
            }
            catch
            {
            }

        }
        void Aktar()
        {
            try
            {
                uploadid.Text = dataGridView5.CurrentRow.Cells[0].Value.ToString();
                baslik.Text = dataGridView5.CurrentRow.Cells[1].Value.ToString();
                aciklama.Text = dataGridView5.CurrentRow.Cells[2].Value.ToString();
                etiket.Text = dataGridView5.CurrentRow.Cells[3].Value.ToString();
            }
            catch
            {
            }
        }
        private void aktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kaldır();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            DurumGüncelle();
        }

        private void onayla_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection bag2 = new OleDbConnection("Provider = Microsoft.ACE.Oledb.12.0; Data Source = " + Application.StartupPath + @"\Ana Dosyalar\Kanallar\" + "Kanallar.accdb");
            cmd2 = new OleDbCommand();
            bag2.Open();
            cmd.Connection = bag2;
            cmd.CommandText = "update Kanallar set Durum='1' where Sıra="+Convert.ToInt32(kimlik.Text)+"";
            cmd.ExecuteNonQuery();
            bag2.Close();
            Kanallarr();
            }
            catch
            {
            }
        }

        private void onaykaldır_Click(object sender, EventArgs e)
        {
            try
            {
             OleDbConnection bag2 = new OleDbConnection("Provider = Microsoft.ACE.Oledb.12.0; Data Source = " + Application.StartupPath + @"\Ana Dosyalar\Kanallar\" + "Kanallar.accdb");
            cmd2 = new OleDbCommand();
            bag2.Open();
            cmd.Connection = bag2;
            cmd.CommandText = "update Kanallar set Durum='0' where Sıra="+Convert.ToInt32(kimlik.Text)+"";
            cmd.ExecuteNonQuery();
            bag2.Close();
            Kanallarr();
            }
            catch
            {
            }
        }
        string kate;
        string gizli;
        private void kategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kategori.SelectedIndex==0)
            {
                kate = "kids";
            }
            else if (kategori.SelectedIndex == 1)
            {
                kate = "school";
            }
            else if (kategori.SelectedIndex == 2)
            {
                kate = "news";
            }
            else if (kategori.SelectedIndex == 3)
            {
                kate = "animals";
            }
            else if (kategori.SelectedIndex == 4)
            {
                kate = "fun";
            }
            else if (kategori.SelectedIndex == 5)
            {
                kate = "people";
            }
            else if (kategori.SelectedIndex == 6)
            {
                kate = "music";
            }
            else if (kategori.SelectedIndex == 7)
            {
                kate = "auto";
            }
            else if (kategori.SelectedIndex == 8)
            {
                kate = "videogames";
            }
            else if (kategori.SelectedIndex == 9)
            {
                kate = "creation";
            }
            else if (kategori.SelectedIndex == 10)
            {
                kate = "travel";
            }
            else if (kategori.SelectedIndex == 11)
            {
                kate = "shortfilms";
            }
            else if (kategori.SelectedIndex == 12)
            {
                kate = "sport";
            }
            else if (kategori.SelectedIndex == 13)
            {
                kate = "tech";
            }
            else if (kategori.SelectedIndex == 14)
            {
                kate = "tv";
            }
            else if (kategori.SelectedIndex == 15)
            {
                kate = "webcam";
            }
            else if (kategori.SelectedIndex == 16)
            {
                kate = "lifestyle";
            }
        }

        private void gizlilik_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gizlilik.SelectedIndex == 0)
            {
                gizli = "true";
            }
            else if (gizlilik.SelectedIndex == 1)
            {
                gizli = "false";
            }
        }
        
        private async Task videolinkler()
        {
            try
            {
                string kanallinki2;

                string linkid = indirlink.Text;
                linkid = linkid.Replace("https://", "");
                linkid = linkid.Replace("http://", "");
                linkid = linkid.Replace("www.youtube.com/user/", "");
                linkid = linkid.Replace("www.youtube.com/channel/", "");
                if (linkid.Contains("/") == true)
                {
                    int uzun, poz;
                    uzun = linkid.Length;
                    poz = linkid.IndexOf("/", 0, uzun);
                    kanallinki2 = linkid.Substring(0, poz);
                }
                else
                {
                    kanallinki2 = linkid;
                }
                videoidler.Items.Clear();
                var yt = new YouTubeService(new BaseClientService.Initializer() { ApiKey = apikey.Text });

                var channelsListRequest = yt.Channels.List("contentDetails");
                if (indirlink.Text.Contains("channel") == true)
                {
                    channelsListRequest.Id = kanallinki2;
                }
                else
                {
                    channelsListRequest.ForUsername = kanallinki2;
                }

                var channelsListResponse = channelsListRequest.Execute();
                int VideoCount = 0;
                foreach (var channel in channelsListResponse.Items)
                {
                    var uploadsListId = channel.ContentDetails.RelatedPlaylists.Uploads;
                    var nextPageToken = "";
                    while (nextPageToken != null)
                    {
                        var playlistItemsListRequest = yt.PlaylistItems.List("snippet");
                        playlistItemsListRequest.PlaylistId = uploadsListId;
                        playlistItemsListRequest.MaxResults = 50;
                        playlistItemsListRequest.PageToken = nextPageToken;
                        // Retrieve the list of videos uploaded to the authenticated user's channel.  
                        var playlistItemsListResponse = playlistItemsListRequest.Execute();
                        foreach (var playlistItem in playlistItemsListResponse.Items)
                        {
                            videoidler.Items.Add(string.Format("{0}", playlistItem.Snippet.ResourceId.VideoId));

                            VideoCount++;
                        }
                        nextPageToken = playlistItemsListResponse.NextPageToken;
                    }
                    //toplamvideosayisi.Text=(string.Format("Toplam video sayısı: {0}", VideoCount));
                }
            }
            catch
            {
            }
        }
        private async Task videolinkler2()
        {
            try
            {
                string kanallinki2;

                string linkid = indirlink2.Text;
                linkid = linkid.Replace("https://", "");
                linkid = linkid.Replace("http://", "");
                linkid = linkid.Replace("www.youtube.com/user/", "");
                linkid = linkid.Replace("www.youtube.com/channel/", "");
                if (linkid.Contains("/") == true)
                {
                    int uzun, poz;
                    uzun = linkid.Length;
                    poz = linkid.IndexOf("/", 0, uzun);
                    kanallinki2 = linkid.Substring(0, poz);
                }
                else
                {
                    kanallinki2 = linkid;
                }
                videoidler.Items.Clear();
                var yt = new YouTubeService(new BaseClientService.Initializer() { ApiKey = apikey.Text });

                var channelsListRequest = yt.Channels.List("contentDetails");
                if (indirlink2.Text.Contains("channel") == true)
                {
                    channelsListRequest.Id = kanallinki2;
                }
                else
                {
                    channelsListRequest.ForUsername = kanallinki2;
                }

                var channelsListResponse = channelsListRequest.Execute();
                foreach (var channel in channelsListResponse.Items)
                {
                    var uploadsListId = channel.ContentDetails.RelatedPlaylists.Uploads;
                    var nextPageToken = "";
                    while (nextPageToken != null)
                    {
                        var playlistItemsListRequest = yt.PlaylistItems.List("snippet");
                        playlistItemsListRequest.PlaylistId = uploadsListId;
                        playlistItemsListRequest.MaxResults = 50;
                        playlistItemsListRequest.PageToken = nextPageToken;
                        // Retrieve the list of videos uploaded to the authenticated user's channel.  
                        var playlistItemsListResponse = playlistItemsListRequest.Execute();
                        foreach (var playlistItem in playlistItemsListResponse.Items)
                        {
                            videoidler.Items.Add(string.Format("{0}", playlistItem.Snippet.ResourceId.VideoId));
                        }
                        nextPageToken = playlistItemsListResponse.NextPageToken;
                    }
                }
            }
            catch
            {
            }
            videosayi.Text = "Toplam Video: " + videoidler.Items.Count.ToString() + "\\" + videoidler.Items.Count.ToString();
        }
        
        
        private void button8_Click(object sender, EventArgs e)
        {
            if (indirlink2.Text.Contains("list=") == true)
            {

                string linkid = indirlink2.Text;
                int len = indirlink2.Text.Length;
                if (linkid.Contains("list=") == true)
                {
                    int uzun, poz;
                    uzun = linkid.Length;
                    poz = linkid.IndexOf("list=", 0, uzun);
                    indirlink2.Text = indirlink2.Text.Replace((linkid.Substring(0, poz) + "list="), "");
                }
                else
                {
                }
                Thread thead2 = new Thread(() =>
                {
                    PlaylistLink().Wait();
                });
                thead2.IsBackground = true;
                thead2.Start();
            }
            else
            {
            }
            if (indirlink2.Text.Contains("channel") == true || indirlink2.Text.Contains("user") == true)
            {
                Thread thead = new Thread(() =>
                {
                    videolinkler2().Wait();
                });
                thead.IsBackground = true;
                thead.Start();
            }
            else
            {
            }
        }
        public static void GenerateThumbImage(string originalImagePath, string thumbImagePath, int newWidth, int newHeight)
        {
            Bitmap srcBmp = new Bitmap(originalImagePath);
            float ratio = 1;
            float minSize = Math.Min(newHeight, newHeight);

            if (srcBmp.Width > srcBmp.Height)
            {
                ratio = minSize / (float)srcBmp.Width;
            }
            else
            {
                ratio = minSize / (float)srcBmp.Height;
            }

            SizeF newSize = new SizeF(srcBmp.Width * ratio, srcBmp.Height * ratio);
            Bitmap target = new Bitmap((int)newSize.Width, (int)newSize.Height);

            using (Graphics graphics = Graphics.FromImage(target))
            {
                graphics.CompositingQuality = CompositingQuality.HighSpeed;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.DrawImage(srcBmp, 0, 0, newSize.Width, newSize.Height);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    target.Save(thumbImagePath);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string linkid = indirlink2.Text;
            int len = indirlink2.Text.Length;
            if (linkid.Contains("list=") == true)
            {
                int uzun, poz;
                uzun = linkid.Length;
                poz = linkid.IndexOf("list=", 0, uzun);
                indirlink2.Text = indirlink2.Text.Replace((linkid.Substring(0, poz) + "list="), "");
            }
            else
            {
            }
            Thread thead = new Thread(() =>
            {
                PlaylistLink().Wait();
            });
            thead.IsBackground = true;
            thead.Start();
        }
        private async Task PlaylistLink()
        {
            yüklenilenvideo.Items.Clear();
            videoidler.Items.Clear();
            try
            {
            
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = System.Text.Encoding.UTF8;
                json = wc.DownloadString(string.Format("https://www.googleapis.com/youtube/v3/playlistItems?playlistId={0}&maxResults=50&part=contentDetails&key={1}", indirlink2.Text, apikey.Text));
            }
            dynamic vericek = SimpleJson.DeserializeObject(json);

                while(true)
                {
                    try
                    {
                        for (int i = 0; i < 50; i++)
                        {
                            if (!videoidler.Items.Contains(indirlink2.Text))
                            {
                                    videoidler.Items.Add(vericek["items"][i]["contentDetails"]["videoId"]);

                            }
                             else
                            {

                            }
                        }
                    }
                    catch
                    {
                    }
                    try
                    {
                        string nextpage = vericek["nextPageToken"];
                        using (WebClient wc = new WebClient())
                        {
                            wc.Encoding = System.Text.Encoding.UTF8;
                            json = wc.DownloadString(string.Format("https://www.googleapis.com/youtube/v3/playlistItems?pageToken={0}&playlistId={1}&maxResults=50&part=contentDetails&key={2}", nextpage, indirlink2.Text, apikey.Text));
                        }
                        vericek = SimpleJson.DeserializeObject(json);
                    }
                    catch
                    {
                    }
                    if (vericek["pageInfo"]["totalResults"] == (videoidler.Items.Count))
                    {
                        break;
                    }
                }

            }
            catch
            {
            }
            videosayi.Text = "Toplam Video: " + videoidler.Items.Count.ToString()+"\\"+ videoidler.Items.Count.ToString();
        }
        private async Task  search()
        {
            searchvideoid.Items.Clear();
            searchetiket.Items.Clear();
            try
            {
            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = apikey.Text,
                ApplicationName = this.GetType().ToString()
            });

            var searchListRequest = youtubeService.Search.List("snippet");
            searchListRequest.Q = baslik2.Text; // Replace with your search term.
            searchListRequest.MaxResults = 50;

            // Call the search.list method to retrieve results matching the specified query term.
            var searchListResponse = await searchListRequest.ExecuteAsync();

            List<string> videos = new List<string>();

            // Add each result to the appropriate list, and then display the lists of
            // matching videos, channels, and playlists.
            foreach (var searchResult in searchListResponse.Items)
            {
                searchvideoid.Items.Add((String.Format("{0}", searchResult.Id.VideoId)));
            }
            searchvideoid.Items.RemoveAt(0);

            for (int i = 0; i < 40; i++)
            {
                using (WebClient wc = new WebClient())
                {
                    wc.Encoding = System.Text.Encoding.UTF8;
                    json = wc.DownloadString(string.Format("https://www.googleapis.com/youtube/v3/videos?part=snippet&id={0}&key={1}", searchvideoid.Items[i], apikey.Text));
                }
                dynamic vericek = SimpleJson.DeserializeObject(json);

                try
                {
                    Random deneme = new Random();
                    searchetiket.Items.Add(vericek["items"][0]["snippet"]["tags"][deneme.Next(1, 10)]);
                    searchetiket.Items.Add(vericek["items"][0]["snippet"]["tags"][deneme.Next(1, 15)]);
                    searchetiket.Items.Add(vericek["items"][0]["snippet"]["tags"][deneme.Next(1, 20)]);

                    }
                    catch
                {

                }

            }
            }
            catch
            {
            }
            etiket2.Text = "";
            ArrayList eleman = new ArrayList(); //sonsuz dizimizi yaratıyoruz
            {
                foreach (string item in searchetiket.Items) //listBox1 deki itemları tek tek dolaş ve bunların adına item de.
                {
                    if (eleman.Contains(item) == false) //eğer eleman (yani sonsuz dizimiz) elemanları içermiyorsa
                    {
                        eleman.Add(item); //sonsuz diziye itemları ekle

                    }
                }
                searchetiket.Items.Clear(); //listBox'ı temizle
                searchetiket.Items.AddRange(eleman.ToArray()); //listBox'a eleman dizinin elemanlarını ekle
            }
            for (int i = 0; i < searchetiket.Items.Count; i++)
            {
                if ((i + 1) < searchetiket.Items.Count)
                    etiket2.Text += searchetiket.Items[i] + ",";
                else
                    etiket2.Text += searchetiket.Items[i];
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string linkid = indirlink2.Text;
            int len = indirlink2.Text.Length;
            if (linkid.Contains("list=") == true)
            {
                int uzun, poz;
                uzun = linkid.Length;
                poz = linkid.IndexOf("list=", 0, uzun);
                indirlink2.Text = indirlink2.Text.Replace((linkid.Substring(0, poz)+"list="), "");
            }
            else
            {
                indirlink2.Text = linkid;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (linkileindir.Items.Count>0)
            {
                foreach (var item in linkileindir.Items)
                {
                    videoidler.Items.Add(item);
                }
            }
            Thread thead3 = new Thread(() =>
            {
                VideoMetaData2().Wait();
            });
            thead3.IsBackground = true;
            thead3.Start();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            string link = Clipboard.GetText();
            link = link.Replace("https://", "");
            link = link.Replace("http://", "");
            link = link.Replace("www.youtube.com/watch?v=", "");

            linkileindir.Items.Add(link);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            linkileindir.Items.Remove(linkileindir.SelectedItem);
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            // values
            TabControl tabCtrl = (TabControl)sender;
            Brush fontBrush = Brushes.Black;
            string title = tabCtrl.TabPages[e.Index].Text;
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Near;
            sf.LineAlignment = StringAlignment.Center;
            int indent = 3;
            Rectangle rect = new Rectangle(e.Bounds.X, e.Bounds.Y + indent, e.Bounds.Width, e.Bounds.Height - indent);

            // draw title
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.DarkBlue);
                g.FillRectangle(Brushes.WhiteSmoke, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Verdana", (float)13.0);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Far;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));

            // draw image if available
            if (tabCtrl.TabPages[e.Index].ImageIndex >= 0)
            {
                Image img = tabCtrl.ImageList.Images[tabCtrl.TabPages[e.Index].ImageIndex];
                float _x = (rect.X + rect.Width - 125) - img.Width - indent;
                float _y = ((rect.Height - img.Height) / 2.0f) + rect.Y;
                e.Graphics.DrawImage(img, _x, _y);
            }
        }
        int toplamvid;
        private void button5_Click(object sender, EventArgs e)
        {;
            Thread thead3 = new Thread(() =>
            {
                indir2().Wait();
            });
            thead3.IsBackground = true;
            thead3.Start();
        }
        public async Task indir2()
        {
            for (int i = 0; i < dataGridView3.RowCount; i++)
            {
                try
                {
                    string id = dataGridView3.Rows[i].Cells[1].Value.ToString();

                    indirmelinki.Text = kod1.Text + Application.StartupPath + "\\Ana Dosyalar\\Atılacak Videolar\\" + kod2.Text + "https://www.youtube.com/watch?v="+id;
                    
                    ProcessStartInfo s = new ProcessStartInfo
                    {
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        LoadUserProfile = true,
                        CreateNoWindow = true,
                        FileName = Application.StartupPath + "\\Ana Dosyalar\\Dosyalar\\youtube-dl.exe",
                        Arguments = indirmelinki.Text

                    };


                    Process p = new Process { StartInfo = s, EnableRaisingEvents = true };
                    if (p.Start())
                    {
                        StreamReader ProcessReader = p.StandardOutput;
                        while (!p.StandardOutput.EndOfStream)
                        {
                            var reading = ProcessReader.ReadLine().Replace(" ", "");
                            try
                            {
                                int perc = reading.IndexOf('%');
                                int cl = reading.IndexOf(']') + 1;
                                String percentage = reading.Substring(cl, (perc - cl));

                                dataGridView3.Rows[i].Cells[6].Value = "%" + percentage;
                            }
                            catch
                            {
                            }
                        }
                    }
                    if (dataGridView3.Rows[i].Cells[6].Value==null)
                    {
                        dataGridView3.Rows[i].Cells[6].Value = "Sorunlu";
                    }
                }
                catch
                {
                }
            }
        }
        
        void Git()
        {
            string target = "www.dailymotion.com/"+dataGridView4.CurrentRow.Cells[1].Value.ToString();
            System.Diagnostics.Process.Start(target);
        }
        private void gitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Git();
        }

        private void Dailyupload_Click(object sender, EventArgs e)
        {
            Thread thead = new Thread(() =>
            {
                DailyUpload2().Wait();
            });
            thead.IsBackground = true;
            thead.Start();
        }
        int f;
        private async Task DailyUpload2()
        {
            for (f = 0; f < dataGridView3.RowCount-1; f++)
            {
                try
                {
                    yüklemegeridöngü.Text = string.Empty;
                    try
                    {
                        uzantilivideo.Items.Clear();
                        uzantisizvideo.Items.Clear();
                        string[] dosyalar = Directory.GetFiles(Application.StartupPath + "\\Ana Dosyalar\\Atılacak Videolar\\");
                        foreach (string dosya in dosyalar)
                        {
                            uzantilivideo.Items.Add(dosya);
                            uzantisizvideo.Items.Add(System.IO.Path.GetFileNameWithoutExtension(dosya));
                        }
                    }
                    catch (Exception)
                    {
                    }

                    try
                    {
                        dailybilgi.Items.Clear();
                        string json = File.ReadAllText(Application.StartupPath + "\\Ana Dosyalar\\Kanal Api\\" + Kanallar2.Text + ".json");
                        dynamic vericekk = SimpleJson.DeserializeObject(json);
                        dailybilgi.Items.Add(vericekk["Dailymotion"]["Mail"]);
                        dailybilgi.Items.Add(vericekk["Dailymotion"]["Sifre"]);
                        dailybilgi.Items.Add(vericekk["Dailymotion"]["Key"]);
                        dailybilgi.Items.Add(vericekk["Dailymotion"]["Secret"]);
                        dailybilgi.Items.Add(vericekk["Dailymotion"]["Callbackurl"]);
                    }
                    catch
                    {
                    }
                    for (int z = 0; z < uzantilivideo.Items.Count; z++)
                    {
                        if (uzantilivideo.Items[z].ToString().ToLower().Contains((dataGridView3.Rows[f].Cells[1].Value).ToString().ToLower()))
                        {
                            videoyolu = uzantilivideo.Items[z].ToString();
                        }
                    }
                    System.IO.FileInfo ff = new System.IO.FileInfo(videoyolu);
                    videoyeri.Text = Application.StartupPath + "\\Ana Dosyalar\\Atılacak Videolar\\" + dataGridView3.Rows[f].Cells[1].Value.ToString() + ff.Extension;

                    string link = videoyeri.Text;
                    MessageBox.Show(link);
                    /////////////////////////////// GetAccessToken//////////////////////////////

                    var request = WebRequest.Create("https://api.dailymotion.com/oauth/token");
                    request.Method = "POST";
                    request.ContentType = "application/x-www-form-urlencoded";

                    var requestString = String.Format("grant_type=password&client_id={0}&client_secret={1}&username={2}&password={3}",
                        HttpUtility.UrlEncode(dailybilgi.Items[2].ToString()),
                        HttpUtility.UrlEncode(dailybilgi.Items[3].ToString()),
                        HttpUtility.UrlEncode(dailybilgi.Items[0].ToString()),
                        HttpUtility.UrlEncode(dailybilgi.Items[1].ToString()));

                    var requestBytes = Encoding.UTF8.GetBytes(requestString);
                    var requestStream = request.GetRequestStream();
                    requestStream.Write(requestBytes, 0, requestBytes.Length);
                    var response = request.GetResponse();
                    var responseStream = response.GetResponseStream();
                    string responseString;
                    using (var reader = new StreamReader(responseStream))
                    {
                        responseString = reader.ReadToEnd();
                    }
                    dynamic vericek = SimpleJson.DeserializeObject(responseString);
                    var accessToken = (vericek["access_token"]);

                    linkileindir.Items.Add(accessToken);

                    /////////////////////////       GetFileUploadUrl                   /////////////////////

                    var client2 = new ExtendedWebClient();
                    client2.Headers.Add("Authorization", "OAuth " + accessToken);
                    client2.Timeout = Timeout.Infinite;
                    client2.AllowWriteStreamBuffering = false;


                    var urlResponse = client2.DownloadString("https://api.dailymotion.com/file/upload");

                    dynamic vericek2 = SimpleJson.DeserializeObject(urlResponse);

                    var uploadUrl = (vericek2["upload_url"]);

                   
                    ////////////////////////          GetFileUploadResponse                  ///////////////

                    client2.UploadProgressChanged += WebClientUploadProgressChanged2;
                    client2.UploadFileCompleted += WebClientUploadCompleted2;


                    {
                        TaskCompletionSource<int> tcs = new TaskCompletionSource<int>();
                        client2.UploadProgressChanged += WebClientUploadProgressChanged2;

                        // this sets the task to completed when the upload finished
                        client2.UploadFileCompleted += (sender, e) => tcs.SetResult(0);

                        client2.UploadFileAsync(new Uri(uploadUrl), link);
                        await tcs.Task.ConfigureAwait(false);
                    }


                    while (yüklemegeridöngü.Text == string.Empty)
                    {
                        System.Threading.Thread.Sleep(1000);
                    }

                    dynamic vericek3 = SimpleJson.DeserializeObject(yüklemegeridöngü.Text);

                    var response2 = (vericek3["url"]);

                    while (response2 == string.Empty)
                    {
                        System.Threading.Thread.Sleep(1000);
                    }
                    linkileindir.Items.Add(response2);
                    ////////////////////        PublishVideo        //////////////////////////////

                    {

                        var request2 = WebRequest.Create("https://api.dailymotion.com/me/videos?url=" + HttpUtility.UrlEncode(response2));
                        request2.Method = "POST";
                        request2.ContentType = "application/x-www-form-urlencoded";
                        request2.Headers.Add("Authorization", "OAuth " + accessToken);

                        var requestString2 = String.Format("title={0}&description={1}&tags={2}&channel={3}&published={4}",
                            HttpUtility.UrlEncode(baslik.Text),
                            HttpUtility.UrlEncode(aciklama.Text),
                            HttpUtility.UrlEncode(etiket.Text),
                            HttpUtility.UrlEncode("news"),
                            HttpUtility.UrlEncode("true"));

                        var requestBytes2 = Encoding.UTF8.GetBytes(requestString2);

                        var requestStream2 = request2.GetRequestStream();


                        requestStream2.Write(requestBytes2, 0, requestBytes2.Length);

                        var response3 = request2.GetResponse();

                        var responseStream2 = response3.GetResponseStream();
                        string responseString3;
                        using (var reader = new StreamReader(responseStream2))
                        {
                            responseString3 = reader.ReadToEnd();
                        }
                        dynamic vericek4 = SimpleJson.DeserializeObject(responseString3);

                        var videoid = (vericek4["id"]);

                        dataGridView3.Rows[f].Cells[8].Value = videoid;

                    }

                }
                catch (Exception hata)
                {
                    dataGridView3.Rows[f].Cells[9].Value = ("Durum: Bu kanalın günlük yükleme limiti dolu. Hata kodu: " + hata);
                }
            }
        }
        private void aktarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Aktar();
        }

        private void Kanallar2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                uzantilivideo.Items.Clear();
                uzantisizvideo.Items.Clear();
                string[] dosyalar = Directory.GetFiles(Application.StartupPath + "\\Ana Dosyalar\\Atılacak Videolar\\");
                foreach (string dosya in dosyalar)
                {
                    uzantilivideo.Items.Add(dosya);
                    uzantisizvideo.Items.Add(System.IO.Path.GetFileNameWithoutExtension(dosya));
                }
            }
            catch (Exception)
            {
            }

            try
            {
                dailybilgi.Items.Clear();
                string json = File.ReadAllText(Application.StartupPath + "\\Ana Dosyalar\\Kanal Api\\" + Kanallar2.Text + ".json");
                dynamic vericek = SimpleJson.DeserializeObject(json);
                dailybilgi.Items.Add(vericek["Dailymotion"]["Mail"]);
                dailybilgi.Items.Add(vericek["Dailymotion"]["Sifre"]);
                dailybilgi.Items.Add(vericek["Dailymotion"]["Key"]);
                dailybilgi.Items.Add(vericek["Dailymotion"]["Secret"]);
                dailybilgi.Items.Add(vericek["Dailymotion"]["Callbackurl"]);
            }
            catch
            {
            }
        }

        private async Task search2()
        {
            searchvideoid.Items.Clear();
            searchetiket.Items.Clear();
            try
            {
                var youtubeService = new YouTubeService(new BaseClientService.Initializer()
                {
                    ApiKey = apikey.Text,
                    ApplicationName = this.GetType().ToString()
                });

                var searchListRequest = youtubeService.Search.List("snippet");
                searchListRequest.Q = baslik3.Text; // Replace with your search term.
                searchListRequest.MaxResults = 50;

                // Call the search.list method to retrieve results matching the specified query term.
                var searchListResponse = await searchListRequest.ExecuteAsync();

                List<string> videos = new List<string>();

                // Add each result to the appropriate list, and then display the lists of
                // matching videos, channels, and playlists.
                foreach (var searchResult in searchListResponse.Items)
                {
                    searchvideoid.Items.Add((String.Format("{0}", searchResult.Id.VideoId)));
                }
                searchvideoid.Items.RemoveAt(0);

                for (int i = 0; i < 40; i++)
                {
                    using (WebClient wc = new WebClient())
                    {
                        wc.Encoding = System.Text.Encoding.UTF8;
                        json = wc.DownloadString(string.Format("https://www.googleapis.com/youtube/v3/videos?part=snippet&id={0}&key={1}", searchvideoid.Items[i], apikey.Text));
                    }
                    dynamic vericek = SimpleJson.DeserializeObject(json);

                    try
                    {
                        Random deneme = new Random();
                        searchetiket.Items.Add(vericek["items"][0]["snippet"]["tags"][deneme.Next(1, 10)]);
                        searchetiket.Items.Add(vericek["items"][0]["snippet"]["tags"][deneme.Next(1, 15)]);
                        searchetiket.Items.Add(vericek["items"][0]["snippet"]["tags"][deneme.Next(1, 20)]);

                    }
                    catch
                    {

                    }

                }
            }
            catch
            {
            }
            ArrayList eleman = new ArrayList(); //sonsuz dizimizi yaratıyoruz
            {
                foreach (string item in searchetiket.Items) //eki itemları tek tek dolaş ve bunların adına item de.
                {
                    if (eleman.Contains(item) == false) //eğer eleman (yani sonsuz dizimiz) elemanları içermiyorsa
                    {
                        eleman.Add(item); //sonsuz diziye itemları ekle

                    }
                }
                searchetiket.Items.Clear(); //listBox'ı temizle
                searchetiket.Items.AddRange(eleman.ToArray()); //listBox'a eleman dizinin elemanlarını ekle
            } 
            etiket3.Text = "";
            for (int i = 0; i < searchetiket.Items.Count; i++)
            {
                if ((i + 1) < searchetiket.Items.Count)
                    etiket3.Text += searchetiket.Items[i] + ",";
                else
                    etiket3.Text += searchetiket.Items[i];
            }
            while (etiket3.Text.Length >= 450)
            {
                etiket3.Text = etiket3.Text.Substring(0, etiket3.Text.Length - 100);
            }
        }




       
        public void CropImage(int x, int y, int width, int height)
        {
            string imagePath = (Application.StartupPath + "\\full.png");
            string output = (Application.StartupPath + "\\fullqw.png");

            Bitmap croppedImage;

            // Here we capture the resource - image file.
            using (var originalImage = new Bitmap(imagePath))
            {
                Rectangle crop = new Rectangle(x, y, width, height);

                // Here we capture another resource.
                croppedImage = originalImage.Clone(crop, originalImage.PixelFormat);

            } // Here we release the original resource - bitmap in memory and file on disk.

            // At this point the file on disk already free - you can record to the same path.
            croppedImage.Save(output, System.Drawing.Imaging.ImageFormat.Jpeg);

            // It is desirable release this resource too.
            croppedImage.Dispose();
        }
        private void button11_Click_1(object sender, EventArgs e)
        {
            Thread thead = new Thread(() =>
            {
                DailyKanalEkle().Wait();
            });
            thead.Start();
        }
        private async Task DailyKanalEkle()
        {
            try
            {
                kanalmailsifre.DataSource = File.ReadAllLines(Application.StartupPath + "\\Ana Dosyalar\\Kanallar\\Kanallar.txt");
                for (int i = 0; i < kanalmailsifre.Items.Count; i++)
                {
                    string[] kanal = Regex.Split(kanalmailsifre.Items[i].ToString(), ",");
                    string mail = kanal[0];
                    string sifre = kanal[1];
                    label2.Text = "Durum: "+mail+" 'adlı kanal ekleniyor.";
                    ChromeDriverService service = ChromeDriverService.CreateDefaultService();
                    service.HideCommandPromptWindow = true;

                    var options = new ChromeOptions();
                    options.AddArguments("--incognito");
                    options.AddArguments("start-maximized");
                    options.AddArguments("disable-infobars");
                    options.AddArguments("--js-flags=--expose-gc");
                    options.AddArguments("--enable-precise-memory-info");
                    options.AddArguments("--disable-popup-blocking");
                    options.AddArguments("--disable-default-apps");

                    IWebDriver driver = new ChromeDriver(service, options);

                    waitForPageToBeReady(driver, 3000);
                    driver.Manage().Cookies.DeleteAllCookies();
                    driver.Navigate().GoToUrl("https://www.dailymotion.com/settings/developer/new");
                    waitForPageToBeReady(driver, 3000);
                    driver.FindElement(By.XPath("//*[@id='root']/div/div[5]/div/div[1]/a")).Click();
                    waitForPageToBeReady(driver, 1000);
                    driver.FindElement(By.XPath("//*[@id='signin_email']")).SendKeys(mail);
                    waitForPageToBeReady(driver, 1000);
                    driver.FindElement(By.XPath("//*[@id='signin_password']")).SendKeys(sifre);
                    waitForPageToBeReady(driver, 1000);
                    driver.FindElement(By.XPath("//*[@id='root']/div/div[5]/div/div[1]/div/a/span")).Click();
                    waitForPageToBeReady(driver, 3000);

                    label2.Text = "Durum: "+mail+ " 'adlı kanala giriş yapıldı";

                    driver.FindElement(By.XPath("//*[@id='application_name']")).SendKeys("Application");
                    driver.FindElement(By.XPath("//*[@id='application_url']")).SendKeys("http://www.google.com");
                    driver.FindElement(By.XPath("//*[@id='application_purpose']")).SendKeys("unknown");
                    driver.FindElement(By.XPath("//*[@id='callback_url']")).SendKeys("http://localhost");


                    waitForPageToBeReady(driver, 3000);
                    IJavaScriptExecutor js = driver as IJavaScriptExecutor;
                    waitForPageToBeReady(driver, 1000);
                    js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");

                    waitForPageToBeReady(driver, 1000);

                    ITakesScreenshot ssdriver = driver as ITakesScreenshot;
                    Screenshot screenshot = ssdriver.GetScreenshot();
                    Screenshot tempImage = screenshot;
                    tempImage.SaveAsFile(Application.StartupPath + "\\full.png");

                    CropImage(720, 530, 180, 50);
                    pictureBox2.ImageLocation = (Application.StartupPath + "\\fullqw.png");

                    string IsimGirisi = Microsoft.VisualBasic.Interaction.InputBox("Bilgi Girişi", "Captcha Giriniz.");
                    driver.FindElement(By.XPath("//*[@id='captchaInput']")).SendKeys(IsimGirisi);

                    waitForPageToBeReady(driver, 3000);
                    driver.FindElement(By.XPath("//*[@id='save']")).Click();
                    waitForPageToBeReady(driver, 3000);


                    string key, secret, callbackurl, kanalid;
                    key = driver.FindElement(By.XPath("//*[@id='content']/div/div[2]/div[4]/div/div/div/div[1]/span[2]")).GetAttribute("textContent");
                    secret = driver.FindElement(By.XPath("//*[@id='content']/div/div[2]/div[4]/div/div/div/div[2]/span[2]")).GetAttribute("textContent");
                    callbackurl = "http://localhost";
                    string api = dailyjson.Items[0].ToString() + mail + dailyjson.Items[1].ToString() + sifre + dailyjson.Items[2].ToString() + key + dailyjson.Items[3].ToString() + secret + dailyjson.Items[4].ToString() + callbackurl + dailyjson.Items[5].ToString();

                    label2.Text = "Durum: Key-Secret çekildi kanal ismi alınıyor.";

                    driver.Navigate().GoToUrl("https://www.dailymotion.com/partner/channel/basic");
                    waitForPageToBeReady(driver, 1000);
                    kanalid = driver.FindElement(By.Name("channelUrl")).GetAttribute("value");
                    waitForPageToBeReady(driver, 1000);

                    TextWriter Kaydet = new StreamWriter(Application.StartupPath + "\\Ana Dosyalar\\Kanal Api\\" + kanalid + ".json");
                    Kaydet.Write(api);
                    Kaydet.Close();



                    var request = WebRequest.Create("https://api.dailymotion.com/oauth/token");
                    request.Method = "POST";
                    request.ContentType = "application/x-www-form-urlencoded";

                    var requestString = String.Format("grant_type=password&client_id={0}&client_secret={1}&username={2}&password={3}",
                        HttpUtility.UrlEncode(key),
                        HttpUtility.UrlEncode(secret),
                        HttpUtility.UrlEncode(mail),
                        HttpUtility.UrlEncode(sifre));

                    var requestBytes = Encoding.UTF8.GetBytes(requestString);

                    var requestStream = request.GetRequestStream();

                    requestStream.Write(requestBytes, 0, requestBytes.Length);

                    var response = request.GetResponse();

                    var responseStream = response.GetResponseStream();
                    string responseString;
                    using (var reader = new StreamReader(responseStream))
                    {
                        responseString = reader.ReadToEnd();
                    }
                    dynamic vericek = SimpleJson.DeserializeObject(responseString);

                    var accessToken = (vericek["access_token"]);

                    var authorizeUrl = String.Format("https://api.dailymotion.com/oauth/authorize?response_type=code&client_id={0}&scope=read+write+delete+manage_videos+userinfo+email+manage_comments+manage_playlists+manage_tiles+manage_subscriptions+manage_friends+manage_favorites+read_insights&redirect_uri={1}",
                    HttpUtility.UrlEncode(key),
                     HttpUtility.UrlEncode(callbackurl));

                    driver.Navigate().GoToUrl(authorizeUrl);

                    waitForPageToBeReady(driver, 3000);

                    driver.FindElement(By.XPath("//*[@id='login']/div/div[2]/div[3]/form/input[15]")).Click();

                    var client = new WebClient();
                    client.Headers.Add("Authorization", "OAuth " + accessToken);
                    waitForPageToBeReady(driver, 3000);
                    driver.Close();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata + "");
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            Thread thead = new Thread(() =>
            {
                Dailyçek().Wait();
            });
            thead.Start();
        }
        private Image LoadImage(string url)
        {
            System.Net.WebRequest request =
                System.Net.WebRequest.Create(url);

            System.Net.WebResponse response = request.GetResponse();
            System.IO.Stream responseStream =
                response.GetResponseStream();

            Bitmap bmp = new Bitmap(responseStream);

            responseStream.Dispose();

            return bmp;
        }
        
        string Görüntüleme, takipçi, video, kategorii, ülke, status, avatar, user_revenues_video_last_day, user_revenues_video_last_week, user_revenues_video_last_month, user_revenues_video_total;

        private void button12_Click(object sender, EventArgs e)
        {
            {

                var request2 = WebRequest.Create("https://api.dailymotion.com/me/videos?url=" + HttpUtility.UrlEncode(linkileindir.Items[2].ToString()));
                request2.Method = "POST";
                request2.ContentType = "application/x-www-form-urlencoded";
                request2.Headers.Add("Authorization", "OAuth " + linkileindir.Items[1].ToString());

                var requestString2 = String.Format("title={0}&description={1}&tags={2}&channel={3}&published={4}",
                    HttpUtility.UrlEncode(baslik.Text),
                    HttpUtility.UrlEncode(aciklama.Text),
                    HttpUtility.UrlEncode(etiket.Text),
                    HttpUtility.UrlEncode("news"),
                    HttpUtility.UrlEncode("true"));

                var requestBytes2 = Encoding.UTF8.GetBytes(requestString2);

                var requestStream2 = request2.GetRequestStream();


                requestStream2.Write(requestBytes2, 0, requestBytes2.Length);

                var response3 = request2.GetResponse();

                var responseStream2 = response3.GetResponseStream();
                string responseString3;
                using (var reader = new StreamReader(responseStream2))
                {
                    responseString3 = reader.ReadToEnd();
                }

                dynamic vericek4 = SimpleJson.DeserializeObject(responseString3);

                var videoid = (vericek4["id"]);

                dataGridView3.Rows[f].Cells[8].Value = videoid;

            }
        }

        private void videoyaGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VideoyaGit();
        }
        void VideoyaGit()
        {
            try
            {
                string target = "www.dailymotion.com/video/" + dataGridView6.CurrentRow.Cells[5].Value.ToString();
                System.Diagnostics.Process.Start(target);
            }
            catch
            {
            }
        }
        private async Task Dailyçek()
        {
            dailykanalid.Items.Clear();
            dataGridView4.Rows.Clear();

            string[] dosyalar = Directory.GetFiles(Application.StartupPath + "\\Ana Dosyalar\\Kanal Api\\");
            foreach (string dosya in dosyalar)
            {
                dailykanalid.Items.Add(System.IO.Path.GetFileNameWithoutExtension(dosya));
            }

            for (int i = 0; i < dailykanalid.Items.Count; i++)
            {
                try
                {
                    string json = File.ReadAllText(Application.StartupPath + "\\Ana Dosyalar\\Kanal Api\\" + dailykanalid.Items[i].ToString() + ".json");
                    dynamic dailykanalapi = SimpleJson.DeserializeObject(json);

                    dailybilgi.Items.Add(dailykanalapi["Dailymotion"]["Mail"]);
                    dailybilgi.Items.Add(dailykanalapi["Dailymotion"]["Sifre"]);
                    dailybilgi.Items.Add(dailykanalapi["Dailymotion"]["Key"]);
                    dailybilgi.Items.Add(dailykanalapi["Dailymotion"]["Secret"]);

                    var request = WebRequest.Create("https://api.dailymotion.com/oauth/token");
                    request.Method = "POST";
                    request.ContentType = "application/x-www-form-urlencoded";
                    var requestString = String.Format("grant_type=password&client_id={0}&client_secret={1}&username={2}&password={3}",
                        HttpUtility.UrlEncode(dailybilgi.Items[2].ToString()),
                        HttpUtility.UrlEncode(dailybilgi.Items[3].ToString()),
                        HttpUtility.UrlEncode(dailybilgi.Items[0].ToString()),
                        HttpUtility.UrlEncode(dailybilgi.Items[1].ToString()));
                    var requestBytes = Encoding.UTF8.GetBytes(requestString);
                    var requestStream = request.GetRequestStream();
                    requestStream.Write(requestBytes, 0, requestBytes.Length);
                    var response = request.GetResponse();
                    var responseStream = response.GetResponseStream();
                    string responseString;
                    using (var reader = new StreamReader(responseStream))
                    {
                        responseString = reader.ReadToEnd();
                    }
                    dynamic vericek = SimpleJson.DeserializeObject(responseString);
                    var accessToken = (vericek["access_token"]);
                    string daily;
                    using (WebClient wc = new WebClient())
                    {
                        wc.Encoding = System.Text.Encoding.UTF8;
                        daily = wc.DownloadString(string.Format("https://api.dailymotion.com/user/{0}/videos?fields=user.views_total,user.followers_total,user.videos_total,user.avatar_60_url,channel.id,country,status,user.revenues_video_last_day,user.revenues_video_last_week,user.revenues_video_last_month,user.revenues_video_total&access_token={1}", dailykanalid.Items[i].ToString(), accessToken));
                        
                    }
                    dynamic dailys = SimpleJson.DeserializeObject(daily);

                    try
                    {
                        Görüntüleme = (dailys["list"][0]["user.views_total"]).ToString();
                        takipçi = (dailys["list"][0]["user.followers_total"]).ToString();
                        video = (dailys["list"][0]["user.videos_total"]).ToString();
                        kategorii = (dailys["list"][0]["channel.id"]).ToString();
                        ülke = (dailys["list"][0]["country"]).ToString();
                        status = (dailys["list"][0]["status"]).ToString();
                        avatar = (dailys["list"][0]["user.avatar_60_url"]).ToString();
                        user_revenues_video_last_day = (dailys["list"][0]["user.revenues_video_last_day"]).ToString();
                        user_revenues_video_last_week = (dailys["list"][0]["user.revenues_video_last_week"]).ToString();
                        user_revenues_video_last_month = (dailys["list"][0]["user.revenues_video_last_month"]).ToString();
                        user_revenues_video_total = (dailys["list"][0]["user.revenues_video_total"]).ToString();
                        if (user_revenues_video_last_day == null)
                        {
                            user_revenues_video_last_day = "0";
                        }
                        if (user_revenues_video_last_week == null)
                        {
                            user_revenues_video_last_week = "0";
                        }
                        if (user_revenues_video_last_month == null)
                        {
                            user_revenues_video_last_month = "0";
                        }
                        if (user_revenues_video_total == null)
                        {
                            user_revenues_video_total = "0";
                        }
                    }
                    catch
                    {
                    }

                    string dosya_dizini = Application.StartupPath + "\\Ana Dosyalar\\Dosyalar\\Avatar\\" + dailykanalid.Items[i].ToString() + ".jpg";
                    if (File.Exists(dosya_dizini) == true) // dizindeki dosya var mı ?
                    {
                    }
                    else
                    {
                        using (WebClient client = new WebClient())
                        {
                            client.DownloadFile(avatar, Application.StartupPath + "\\Ana Dosyalar\\Dosyalar\\Avatar\\" + dailykanalid.Items[i].ToString() + ".jpg");
                        }
                    }
                    dataGridView4.Rows.Add(Image.FromFile(Application.StartupPath + "\\Ana Dosyalar\\Dosyalar\\Avatar\\" + dailykanalid.Items[i].ToString() + ".jpg"), dailykanalid.Items[i].ToString(), Görüntüleme, takipçi, video, kategorii, user_revenues_video_last_day, user_revenues_video_last_week, user_revenues_video_last_month, user_revenues_video_total, ülke, status);

                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata + "");
                }
            }
        }

     
    }
}
