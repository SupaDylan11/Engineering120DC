using AutomationTestFramework.lib.driver_config;
using AutomationTestFramework.lib.pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestFramework.lib
{
    public class AP_Website<T> where T : IWebDriver, new()
    {
        #region Accessible cage object and selenium drivers
        public IWebDriver SeleniumDriver { get; set; }
        public AP_HomePage AP_HomePage { get; set; }
        public AP_SignInPage AP_SignInPage { get; set; }
        #endregion

        public AP_Website(int pageLoadInsecs = 10, int implicitWaitInSecs = 10, bool isHeadless = false)
        {
            SeleniumDriver = new SeleniumDriverConfig<T>(pageLoadInsecs, implicitWaitInSecs, isHeadless).Driver;
            AP_HomePage = new AP_HomePage(SeleniumDriver);
            AP_SignInPage = new AP_SignInPage(SeleniumDriver);
        }
    }
}
