using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumStudy.Tests
{
    public class BaseTest
    {

        //public IWebDriver Driver
        //{
        //    get
        //    {
        //        if (driver == null)
        //        {
        //            //ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"C:\Users\Anuitex-QA-1\Downloads\chromedriver_win32");
        //            ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"C:\Users\Anuitex-50\Downloads\Install\chromedriver");
        //            driver = new ChromeDriver(service);
        //        }
        //        return driver;
        //    }
        //}
        public IWebDriver driver { get; private set; }

        public BaseTest()
        {
            driver = new ChromeDriver();
        }

        public void OpenHomePage(String homeUrl)
        {
            driver.Navigate().GoToUrl(homeUrl);
        }

        [SetUp]
        public void BeforeTests()
        {
            driver.Manage().Window.Maximize();
        }
        [TearDown]
        public void AfrterEachTest()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
