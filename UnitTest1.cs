using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using BT_ERP;
using System.Threading;
using System.IO;


namespace UnitTestProject4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
            public void TrendyolLoginTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.trendyol.com/";
            driver.FindElement(By.ClassName("homepage-popup-gender")).Click();
            driver.FindElement(By.XPath("/html/body/div[2]/div[1]/div[2]/div[3]/div/div/ul/li[1]/div[1]/i")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@id='email']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@id='email']")).SendKeys("tlybyr23@gmail.com");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("password")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("password")).SendKeys("123456");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("loginSubmit")).Click();
            Thread.Sleep(2000);

            // Kadın Sekmesi Tıklama

            try
            {
                driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[1]/ul/li[1]/a")).Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div[1]/div/div/div[1]/div[1]/a/img"));

            }
            catch
            {
                var transitionLogFile = ( @ "C:\TEMP\TrendyolTestLog.txt");
                using (var w = File.AppendText(transitionLogFile))
                {

                    w.Write("\r\n{0} : {1} \t ", DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff"), "Butik yüklenirkenhata alınmıştır");
                }
                driver.Close();
            }

            // Erkek Sekmesi Tıklama

            try
            {
                driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[1]/ul/li[2]/a")).Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div[1]/div/div/div[1]/div[1]/a/img"));

            }
            catch
            {
                var transitionLogFile = ( @ "C:\TEMP\TrendyolTestLog.txt");
                using (var w = File.AppendText(transitionLogFile))
                {

                    w.Write("\r\n{0} : {1} \t ", DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff"), "Erkek Butiği yüklenirken hata alınmıştır");
                }
                driver.Close();
            }

            // Çocuk Sekmesi Tıklama

            try
            {
                driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[1]/ul/li[3]/a")).Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div[1]/div/div/div[1]/div[1]/a/img"));

            }
            catch
            {
                var transitionLogFile = ( @ "C:\TEMP\TrendyolTestLog.txt");
                using (var w = File.AppendText(transitionLogFile))
                {

                    w.Write("\r\n{0} : {1} \t ", DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff"), "Çocuk Butiği yüklenirken hata alınmıştır");
                }
                driver.Close();
            }

            // Ayakkabı / Çanta Sekmesi Tıklama

            try
            {
                driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[1]/ul/li[4]/a")).Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div[1]/div/div/div[1]/div[1]/a/img"));

            }
            catch
            {
                var transitionLogFile = ( @ "C:\TEMP\TrendyolTestLog.txt");
                using (var w = File.AppendText(transitionLogFile))
                {

                    w.Write("\r\n{0} : {1} \t ", DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff"), "Ayakkabı butiği yüklenirken hata alınmıştır");
                }
                driver.Close();
            }

            // Saat Aksesuar Sekmesi Tıklama

            try
            {
                driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[1]/ul/li[5]/a")).Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div[1]/div/div/div[1]/div[1]/a/img"));

            }
            catch
            {
                var transitionLogFile = ( @ "C:\TEMP\TrendyolTestLog.txt");
                using (var w = File.AppendText(transitionLogFile))
                {

                    w.Write("\r\n{0} : {1} \t ", DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff"), "Saat Aksesuar Butiği yüklenirken hata alınmıştır");
                }
                driver.Close();
            }

            // Kozmetik Sekmesi Tıklama

            try
            {
                driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[1]/ul/li[6]/a")).Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div[1]/div/div/div[1]/div[1]/a/img"));

            }
            catch
            {
                var transitionLogFile = ( @ "C:\TEMP\TrendyolTestLog.txt");
                using (var w = File.AppendText(transitionLogFile))
                {

                    w.Write("\r\n{0} : {1} \t ", DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff"), "Kozmetik Butiği yüklenirken hata alınmıştır");
                }
                driver.Close();
            }

            // Ev Yaşam Sekmesi Tıklama

            try
            {
                driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[1]/ul/li[7]/a")).Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div[1]/div/div/div[1]/div[1]/a/img"));

            }
            catch
            {
                var transitionLogFile = ( @ "C:\TEMP\TrendyolTestLog.txt");
                using (var w = File.AppendText(transitionLogFile))
                {

                    w.Write("\r\n{0} : {1} \t ", DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff"), "Ev yaşam Butiği yüklenirken hata alınmıştır");
                }
                driver.Close();
            }

            // Elektronik Sekmesi Tıklama

            try
            {
                driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[1]/ul/li[8]/a")).Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div[1]/div/div/div[1]/div[1]/a/img"));

            }
            catch
            {
                var transitionLogFile = ( @ "C:\TEMP\TrendyolTestLog.txt");
                using (var w = File.AppendText(transitionLogFile))
                {

                    w.Write("\r\n{0} : {1} \t ", DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff"), "Elektronik Butiği yüklenirken hata alınmıştır");
                }
                driver.Close();
            }

            // Süpermarket Sekmesi Tıklama

            try
            {
                driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[1]/ul/li[9]/a")).Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div[1]/div/div/div[1]/div[1]/a/img"));

            }
            catch
            {
                var transitionLogFile = ( @ "C:\TEMP\TrendyolTestLog.txt");
                using (var w = File.AppendText(transitionLogFile))
                {

                    w.Write("\r\n{0} : {1} \t ", DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff"), "Süpermarket Butiği yüklenirken hata alınmıştır");
                }
                driver.Close();
            }

            // 3. Case

            try
            {
                driver.FindElement(By.LinkText("Omo & Domestos & Yumoş")).Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                driver.FindElement(By.XPath("/html/body/div[3]/div[1]/div/div[2]/div/div/ul/li[4]/div/a/div[3]/div/div/img"));
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            }
            catch
            {
                var transitionLogFile = ( @ "C:\TEMP\TrendyolTestLog.txt");
                using (var w = File.AppendText(transitionLogFile))
                {

                    w.Write("\r\n{0} : {1} \t ", DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff"), "Süpermarket Pet dünyası sayfası yüklenirken hata alınmıştır");
                }
                driver.Close();
            }

            // 4. Case - Ürünün detayına gidilmesi

            driver.FindElement(By.XPath("/html/body/div[3]/div[1]/div/div[2]/div/div/ul/li[4]/div/a/div[3]/div/div/img")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.ClassName("add-to-bs-tx")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Thread.Sleep(5000);
            driver.Close();

        }
    }
}
   
}

