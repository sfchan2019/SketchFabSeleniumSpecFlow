using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using SketchFabSeleniumSpecFlow.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SketchFabSeleniumSpecFlow
{
    [Binding]
    public class SketchFabSignUpSteps
    {
        IWebDriver driver;
        HomePage homePage;

        [Scope(Feature = "SketchFabSignUp")]
        [BeforeScenario]
        public void Setup()
        {
            driver = new ChromeDriver();
            homePage = new HomePage(driver);
        }

        [Scope(Feature = "SketchFabSignUp")]
        [AfterScenario]
        public void TearDown()
        {
            driver.Close();
        }

        [Scope(Feature = "SketchFabSignUp")]
        [Given(@"I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
            homePage.GotoPage();
        }

        [Scope(Feature = "SketchFabSignUp")]
        [Given(@"I click on the sign up button")]
        public void GivenIClickOnTheSignUpButton()
        {
            homePage.ClickSignUpLink();
        }

        [Scope(Feature = "SketchFabSignUp")]
        [Given(@"the sign up window pop up")]
        public void GivenTheSignUpWindowPopUp()
        {
            homePage.InitSignUpWindow();
        }

        [Scope(Feature = "SketchFabSignUp")]
        [When(@"I enter a valid username")]
        public void WhenIEnterAValidUsername()
        {
            homePage.FillUsername("sfchan2019");
        }

        [Scope(Feature = "SketchFabSignUp")]
        [When(@"I enter a valid email")]
        public void WhenIEnterAValidEmail()
        {
            homePage.FillEmail("schan@spartaglobal.com");
        }

        [Scope(Feature = "SketchFabSignUp")]
        [When(@"I enter a valid password")]
        public void WhenIEnterAValidPassword()
        {
            homePage.FillPassword("a123456789");
        }

        [Scope(Feature = "SketchFabSignUp")]
        [When(@"I click the create account button")]
        public void WhenIClickTheCreateAccountButton()
        {
            homePage.ClickCreateAccount();
        }

        [Scope(Feature = "SketchFabSignUp")]
        [Then(@"An error message should appear under privacy policy")]
        public void ThenTheErrorMessageShouldReturnThisFieldIsRequired()
        {
            Assert.AreEqual("This field is required", homePage.GetPrivacyPolicyErrorMessage());
        }
    }
}
