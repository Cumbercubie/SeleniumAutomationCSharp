using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace C__Crawler_VSCodeStyle
{
    class Program
    {
        static void Crawl(String URL)
        {
            IWebDriver driver = new ChromeDriver(@"../C#_Crawler_VSCodeStyle/bin/Debug/netcoreapp2.1");
            driver.Navigate().GoToUrl
                (URL);
            var brand_tag = driver.FindElement(By.CssSelector("[itemprop=\"brand manufacturer\"]>a"));
            var brand = brand_tag.GetAttribute("innerHTML").Trim();
            Console.WriteLine(brand);
            var price_tag = driver.FindElement(By.CssSelector("#final-price"));
            var finalPrice = price_tag.GetAttribute("innerHTML").Trim();
            Console.WriteLine(finalPrice);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            String URL = "https://www.jomashop.com/tissot-watch-t0064071603300.html";
            Crawl(URL);
        }
    }
}
