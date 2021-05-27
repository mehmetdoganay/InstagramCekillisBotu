using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstagramCekilisBotu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        public IWebDriver driver { get; set; }
        public async void DriverBaslat(string proxy)
        {
            ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;
            ChromeOptions chromeOptions = new ChromeOptions();
            if (!string.IsNullOrEmpty(proxy))
            {
                chromeOptions.AddArgument("--proxy-server=" + proxy);
            }
            chromeOptions.AddExcludedArgument("enable-automation");
            chromeOptions.AddAdditionalCapability("useAutomationExtension", false);
            chromeOptions.AddArguments("--allow-file-access");
            chromeOptions.AddArgument("--disable-web-security");
            chromeOptions.AddArgument("--allow-running-insecure-content");
            driver = new ChromeDriver(chromeDriverService, chromeOptions, TimeSpan.FromMinutes(30.0));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            await Task.Delay(2000);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                try
                {
                    DriverBaslat("");
                    driver.Navigate().GoToUrl(txtLink.Text);
                    var kapat = driver.FindElement(By.ClassName("xqRnw"));
                    kapat.Click();

                    string xpath = "//*[@id='react-root']/section/main/div/div[1]/article/div[3]/div[1]/ul/li/div/button";
                    var loadMoreBtn = driver.FindElement(By.XPath(xpath));

                    while (loadMoreBtn.Displayed)
                    {
                        loadMoreBtn.Click();
                        try
                        {
                            loadMoreBtn = driver.FindElement(By.XPath(xpath));
                        }
                        catch (Exception)
                        {

                            break;
                        }
                        Thread.Sleep(2000);
                    }
                    IList<IWebElement> yorumlar = driver.FindElements(By.ClassName("gElp9"));
                    foreach (var item in yorumlar)
                    {
                        var container = item.FindElement(By.ClassName("C4VMK"));
                        var kullaniciAdi = container.FindElement(By.ClassName("_6lAjh")).Text;
                        LstKatilimci.Items.Add(kullaniciAdi);
                    }
                    driver.Close();

                    int kazanacaklar = Convert.ToInt32(CmbKazanacakKisiSayisi.SelectedItem);
                    int yedekler = Convert.ToInt32(CmbYedekKisiSayisi.SelectedItem);

                    for (int i = 0; i < kazanacaklar; i++)
                    {
                        int cikanKisi = rastgele.Next(0, LstKatilimci.Items.Count);
                        LstKazananlar.Items.Add(LstKatilimci.Items[cikanKisi]);
                        LstKatilimci.Items.Remove(cikanKisi);
                    }

                    for (int i = 0; i < yedekler; i++)
                    {
                        int cikanKisi = rastgele.Next(0, LstKatilimci.Items.Count);
                        LstYedekler.Items.Add(LstKatilimci.Items[cikanKisi]);
                        LstKatilimci.Items.Remove(cikanKisi);
                    }




                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            });
        }
        Random rastgele;
        private void Form1_Load(object sender, EventArgs e)
        {
            rastgele = new Random();
        }
        public void DosyaKaydet(ListBox lst,string adi)
        {
            try
            {
                string yol = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + adi;
                using(StreamWriter sw = new StreamWriter(yol))
                {
                    foreach (var item in lst.Items)
                    {
                        sw.WriteLine(item.ToString());
                    }
                    sw.Close();
                    MessageBox.Show("Masaüstüne Kaydedildi");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DosyaKaydet(LstKatilimci, "Katilimci.txt");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DosyaKaydet(LstKazananlar, "Kazananlar.txt");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DosyaKaydet(LstYedekler, "Yedekler.txt");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
    
}
