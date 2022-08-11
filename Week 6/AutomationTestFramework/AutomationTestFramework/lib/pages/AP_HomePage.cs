using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestFramework.lib.pages
{
    public class AP_HomePage
    {
        private IWebDriver seleniumDriver;

        public AP_HomePage(IWebDriver seleniumDriver)
        {
            this.seleniumDriver = seleniumDriver;
        }
    }
}
