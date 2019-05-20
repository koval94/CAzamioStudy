using OpenQA.Selenium;
using SeleniumStudy.Tests;
using System;

namespace SeleniumStudy.Framework.PageObjects
{
    public class LogInPage : PageObject
    {
        public IWebElement _emailField;
        public IWebElement _passwordField;
        public IWebElement _signInButton;

        public LogInPage(IWebDriver driver) : base(driver)
        {
            _emailField = _driver.FindElement(By.CssSelector("signin form div.email-wrapper input"));
            _passwordField = _driver.FindElement(By.CssSelector("signin form div.password-wrapper input"));
            _signInButton = _driver.FindElement(By.CssSelector("signin form button[type='submit']"));
        }

        public LogInPage TypeEmail(String email)
        {
            _driver.WaitForElementToBeVisible(By.CssSelector("signin form div.email-wrapper input"));
            _emailField.SendKeys(email);
            return this;
        }
        public LogInPage TypePassword(String password)
        {
            _driver.WaitForElementToBeVisible(By.CssSelector("signin form div.password-wrapper input"));
            _emailField.SendKeys(password);
            return this;
        }
        public LogInPage ClickSignInButton()
        {
            _signInButton.Click();
            return this;
        }
    }
}
