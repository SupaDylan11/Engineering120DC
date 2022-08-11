using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_TestAutomationFramework.lib.pages
{
    public class AP_RecoveryPage
    {
        private IWebDriver _seleniumDriver;
        private string _recoveryPageUrl = AppConfigReader.RecoveryPageUrl;
        private IWebElement _recoveryEmail => _seleniumDriver.FindElement(By.Id("email"));
        private IWebElement _recoverySubmit => _seleniumDriver.FindElement(By.ClassName("btn.btn-default.button.button-medium"));
        private IWebElement _recoveryAlert => _seleniumDriver.FindElement(By.ClassName("alert"));


        public AP_RecoveryPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;


        public void EnterEmail(string email) => _recoveryEmail.SendKeys(email);
        public void Submit() => _recoverySubmit.Click();
        public string RecoveryAlert() => _recoveryAlert.Text;
        public void VisitRecoveryPage() => _seleniumDriver.Navigate().GoToUrl(_recoveryPageUrl);
    }
}
