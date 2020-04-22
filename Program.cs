using System;

namespace C__Crawler_VSCodeStyle
{
    class Program
    {
        void Crawler(String URL)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl
                ("https://www.jomashop.com/tissot-watch-t0064071603300.html");
            var brand_tag = driver.FindElement(By.CssSelector("[itemprop=\"brand manufacturer\"]>a"));
            var brand = element.GetAttribute("innerHTML");
            var price_tag = driver.FindElement(Byte.CssSelector("#final-price"));
            var finalPrice = price_tag.GetAttribute("innerHTML");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
