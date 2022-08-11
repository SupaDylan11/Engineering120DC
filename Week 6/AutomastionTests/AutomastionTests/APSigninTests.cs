namespace AutomastionTests
{
    public class Tests
    {

        [Test]
        public void GivenIOpenTheLink_EnterTheHomePageOfSauceDemo()
        {
            var options = new FirefoxOptions();
            options.AddArguments("--headless");
            using (IWebDriver driver = new FirefoxDriver(options))
            {
                //maximise browser
                driver.Manage().Window.Maximize();
                //navigate to ap site
                driver.Navigate().GoToUrl("https://www.saucedemo.com/");
                //test to ensure site is loaded
                Thread.Sleep(5000);
                Assert.That(driver.Title, Is.EqualTo("Swag Labs"));
            }
        }

        [Test]
        public void GivenAValidUsernameAndPassword_WhenISignIn_EnterNextPage()
        {
            var options = new FirefoxOptions();
            options.AddArguments("--headless");
            using (IWebDriver driver = new FirefoxDriver(options))
            {
                //maximise browser
                driver.Manage().Window.Maximize();
                //navigate to ap site
                driver.Navigate().GoToUrl("https://www.saucedemo.com/");
                //pause test
                Thread.Sleep(5000);
                IWebElement userField = driver.FindElement(By.Id("user-name"));
                IWebElement passwordField = driver.FindElement(By.Id("password"));
                userField.SendKeys("standard_user");
                passwordField.SendKeys("secret_sauce");
                passwordField.SendKeys(Keys.Enter);
                Thread.Sleep(5000);
                IWebElement alert = driver.FindElement(By.ClassName("title"));
                Assert.That(alert.Text, Is.EqualTo("PRODUCTS"));
            }
        }

        [Test]
        public void GivenAValidUsernameAndInvalidPassword_WhenISignIn_ReturnError()
        {
            var options = new FirefoxOptions();
            options.AddArguments("--headless");
            using (IWebDriver driver = new FirefoxDriver(options))
            {
                //maximise browser
                driver.Manage().Window.Maximize();
                //navigate to ap site
                driver.Navigate().GoToUrl("https://www.saucedemo.com/");
                //pause test
                Thread.Sleep(5000);
                IWebElement userField = driver.FindElement(By.Id("user-name"));
                IWebElement passwordField = driver.FindElement(By.Id("password"));
                userField.SendKeys("standard_user");
                passwordField.SendKeys("secretsauce");
                passwordField.SendKeys(Keys.Enter);
                Thread.Sleep(5000);
                IWebElement alert = driver.FindElement(By.ClassName("error-message-container"));
                Assert.That(alert.Text, Does.Contain("sadface"));
            }
        }

        [Test]
        public void GivenAProblemTypeUserAndCorrectPassword_WhenISignIn_ReturnRelevantError()
        {
            var options = new FirefoxOptions();
            options.AddArguments("--headless");
            using (IWebDriver driver = new FirefoxDriver(/*options*/))
            {
                //maximise browser
                driver.Manage().Window.Maximize();
                //navigate to ap site
                driver.Navigate().GoToUrl("https://www.saucedemo.com/");
                //pause test
                Thread.Sleep(5000);
                IWebElement userField = driver.FindElement(By.Id("user-name"));
                IWebElement passwordField = driver.FindElement(By.Id("password"));
                userField.SendKeys("locked_out_user");
                passwordField.SendKeys("secret_sauce");
                passwordField.SendKeys(Keys.Enter);
                Thread.Sleep(5000);
                IWebElement alert = driver.FindElement(By.ClassName("error-message-container"));
                Assert.That(alert.Text, Does.Contain("locked out"));
            }
        }
    }
}