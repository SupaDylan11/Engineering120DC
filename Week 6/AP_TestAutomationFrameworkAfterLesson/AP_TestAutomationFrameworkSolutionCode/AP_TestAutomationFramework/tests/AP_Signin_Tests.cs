using AP_TestAutomationFramework.lib;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace AP_TestAutomationFramework.tests
{
    public class Tests
    {
        private AP_Website<FirefoxDriver> AP_Website = new();

        [Test]
        public void GivenIAmOnTheHomePage_WhenIClickTheSIgninButton_ThenIShouldLandOnTheSignInPage()
        {
            AP_Website.AP_HomePage.VisitHomePage();
            Thread.Sleep(5000);
            AP_Website.AP_HomePage.VisitSignInPage();
            Thread.Sleep(5000);
            Assert.That(AP_Website.SeleniumDriver.Title, Does.Contain("Login - My Store"));
        }

        [Category("Tests For Sign In Page")]
        [Test]
        public void GivenIAmOnTheSignInPage_AndIEnterA5DigitPassword_WhenIClickTheSignInButton_ThenIShouldGetAnErrorMessage()
        {
            AP_Website.AP_HomePage.VisitHomePage();
            Thread.Sleep(5000);
            AP_Website.AP_HomePage.VisitSignInPage();
            Thread.Sleep(5000);
            AP_Website.AP_SigninPage.EnterEmail("dylancole@enron.com");
            Thread.Sleep(5000);
            AP_Website.AP_SigninPage.EnterPasswd("heyah");
            Thread.Sleep(5000);
            AP_Website.AP_SigninPage.Submit();
            Thread.Sleep(5000);
            Assert.That(AP_Website.AP_SigninPage.Alert, Does.Contain("Authentication failed"));
        }

        [Category("Create Account")]
        [Test]
        public void GivenIAmOnTheSignInPage_AndIEnterAValidEmailAddress_WhenIClickTheCreateButton_ThenIShouldLandOnSignUpPage()
        {
            AP_Website.AP_HomePage.VisitHomePage();
            Thread.Sleep(5000);
            AP_Website.AP_HomePage.VisitSignInPage();
            Thread.Sleep(5000);
            AP_Website.AP_SigninPage.EnterCreateEmail("supadylan11@gmail.com");
            Thread.Sleep(5000);
            AP_Website.AP_SigninPage.CreateAccount();
            Thread.Sleep(5000);
            Assert.That(AP_Website.SeleniumDriver.Url, Does.Contain("http://automationpractice.com/index.php?controller=authentication&back=my-account"));
        }

        [Category("Create Account")]
        [Test]
        public void GivenIAmOnTheSignInPage_AndIEnterAnInvalidEmailAddress_WhenIClickTheCreateButton_ThenIShouldGetAnErrorMessage()
        {
            AP_Website.AP_HomePage.VisitHomePage();
            Thread.Sleep(5000);
            AP_Website.AP_HomePage.VisitSignInPage();
            Thread.Sleep(5000);
            AP_Website.AP_SigninPage.EnterCreateEmail("RonDeSantis");
            Thread.Sleep(5000);
            AP_Website.AP_SigninPage.CreateAccount();
            Thread.Sleep(5000);
            Assert.That(AP_Website.AP_SigninPage.createAccAlert(), Does.Contain("Invalid email address"));
        }

        [Category("Forget Password")]
        [Test]
        public void GivenIAmOnTheSignInPage_WhenIClickOnForgotPasswordLink_ThenIShouldLandOnTheForgottenPasswordPage()
        {
            AP_Website.AP_HomePage.VisitHomePage();
            Thread.Sleep(5000);
            AP_Website.AP_HomePage.VisitSignInPage();
            Thread.Sleep(5000);
            AP_Website.AP_SigninPage.VisitRecoveryPage();
            Thread.Sleep(5000);
            Assert.That(AP_Website.SeleniumDriver.Title, Does.Contain("Forgot your password - My Store"));
        }

        [Category("Forget Password")]
        [Test]
        public void GivenIAmOnTheRecoveryPage_AndIEnterAnInvalidEmailAddress_WhenIClickTheRetrievePasswordButton_ThenIShouldGetAnErrorMessage()
        {
            AP_Website.AP_RecoveryPage.VisitRecoveryPage();
            Thread.Sleep(5000);
            AP_Website.AP_RecoveryPage.EnterEmail("dylancole@enron.com");
            Thread.Sleep(5000);
            AP_Website.AP_RecoveryPage.Submit();
            Thread.Sleep(5000);
            Assert.That(AP_Website.AP_RecoveryPage.RecoveryAlert(), Does.Contain("no account registered"));
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            AP_Website.SeleniumDriver.Quit();
            AP_Website.SeleniumDriver.Dispose();
        }
    }
}