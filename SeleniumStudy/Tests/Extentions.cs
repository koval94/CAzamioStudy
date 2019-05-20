using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumStudy.Tests
{
    public static class Extentions
    {
        public static void WaitForElementToBeClickable(this IWebDriver driver, IWebElement element, int seconds = 200)
        {
            var timeOutInSeconds = TimeSpan.FromSeconds(seconds).TotalSeconds;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutInSeconds));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }
        
        public static void WaitForElementToBeVisible(this IWebDriver driver, By by, int seconds = 200)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            wait.Until(ExpectedConditions.ElementExists(by));
        }
    }
}
