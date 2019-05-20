using NUnit.Framework;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumStudy.Tests;
using SeleniumStudy.Framework.PageObjects;

namespace SeleniumStudy
{
    public class LogInTests : BaseTest
    {
        public string homeURL;

        [Test]
        public void SuccessLogInToTheSystem()
        {
            homeURL = "https://cazamio-web.azurewebsites.net/";
            Header header = new Header(driver);
            LogInPage logInPage = new LogInPage(driver);

            OpenHomePage(homeURL);
            header.ClickLoginButon();
            logInPage.
                TypeEmail("btest@mail-list.top")
                .TypePassword("Qwerty123!")
                .ClickSignInButton();
     

        }

    }
}
