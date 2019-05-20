using OpenQA.Selenium;

namespace SeleniumStudy.Tests
{
    public class PageObject
    {
        protected readonly IWebDriver _driver;

        public PageObject(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
