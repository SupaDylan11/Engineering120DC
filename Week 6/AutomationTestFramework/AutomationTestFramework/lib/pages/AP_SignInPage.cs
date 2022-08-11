using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestFramework.lib.pages
{
    public class AP_SignInPage
    {
        private IWebDriver _seleniumDriver;
        private string _homePageUrl = AppConfigReader.BaseUrl;
        private IWebElement _signInLink => _seleniumDriver.FindElement(By.LinkText("Sign in"));

        public AP_SignInPage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }

        public void VisitHomePage() => _seleniumDriver.Navigate().GoToUrl(_homePageUrl);
        public void VisitSignInPage() => _seleniumDriver.Navigate().GoToUrl(_signIn);


    }
}
