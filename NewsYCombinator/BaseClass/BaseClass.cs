using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NewsYCombinator.BaseClass
{
    public class BaseClass
    {
        public static IWebDriver driver;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://news.ycombinator.com/news";
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }
}
