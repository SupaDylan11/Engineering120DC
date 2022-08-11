using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_TestAutomationFramework.lib.pages
{
    public class AP_SigninPage
    {
        #region properties & fields
        private IWebDriver _seleniumDriver;
        private string _signInUrl = AppConfigReader.SignInPageUrl;
        private IWebElement _username => _seleniumDriver.FindElement(By.Id("email"));
        private IWebElement _passwd => _seleniumDriver.FindElement(By.Id("passwd"));
        private IWebElement _submitBtn => _seleniumDriver.FindElement(By.Id("SubmitLogin"));
        private IWebElement _alert => _seleniumDriver.FindElement(By.ClassName("alert"));
        private IWebElement _createAccAlert => _seleniumDriver.FindElement(By.Id("create_account_error"));
        private IWebElement _createEmail => _seleniumDriver.FindElement(By.Id("email_create"));
        private IWebElement _accountLink => _seleniumDriver.FindElement(By.Id("SubmitCreate"));
        private IWebElement _forgotLink => _seleniumDriver.FindElement(By.TagName("a"));

        #endregion

        public AP_SigninPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;
        #region methods
        public void EnterEmail(string email) => _username.SendKeys(email);
        public void EnterPasswd(string passwd) => _passwd.SendKeys(passwd);
        public void EnterCreateEmail(string email) => _createEmail.SendKeys(email);
        public void CreateAccount() => _accountLink.Click();
        public void Submit() => _submitBtn.Click();
        public void VisitRecoveryPage() => _forgotLink.Click();
        public string Alert() => _alert.Text;
        public string createAccAlert() => _createAccAlert.Text;
        public void VisitSignInPage() => _seleniumDriver.Navigate().GoToUrl(_signInUrl);
        #endregion
    }
}
