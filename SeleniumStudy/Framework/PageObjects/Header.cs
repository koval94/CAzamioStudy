using OpenQA.Selenium;
using SeleniumStudy.Tests;

namespace SeleniumStudy.Framework.PageObjects
{
    public class Header : PageObject
    {
        private IWebElement _logInButton;
        public Header(IWebDriver driver) : base(driver)
        {
            _logInButton = _driver.FindElement(By.CssSelector(" header nav  ul.nav-menu  li:nth-child(3) button:nth-child(1)"));

        }


        public Header ClickLoginButon()
        {
            _driver.WaitForElementToBeClickable(_logInButton);
            _logInButton.Click();
            return this;
        }
    }
}
