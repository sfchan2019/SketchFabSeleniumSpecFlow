using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace SketchFabSeleniumSpecFlow.Pages
{
    class HomePage
    {
        IWebDriver driver;
        IWebElement signUpForm;
        //IWebElement signUpWindow;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/header/div/div[2]/a[2]")]
        IWebElement signUpLink;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void GotoPage()
        {
            driver.Navigate().GoToUrl("https://sketchfab.com/");
        }

        public void ClickSignUpLink()
        {
            signUpLink.Click();
        }

        public void InitSignUpWindow()
        {
            //signUpWindow = driver.FindElement(By.ClassName("popup-container"));
            signUpForm = driver.FindElement(By.ClassName("c-authenticate"));
        }

        public void FillUsername(string username)
        {
            //First text field is username
            IWebElement usernameField = signUpForm.FindElements(By.ClassName("form-input"))[0];
            usernameField.SendKeys(username);
        }

        public void FillEmail(string email)
        {
            //Second text field is email
            IWebElement passwordField = signUpForm.FindElements(By.ClassName("form-input"))[1];
            passwordField.SendKeys(email);
        }

        public void FillPassword(string password)
        {
            //Third text field is password
            IWebElement passwordField = signUpForm.FindElements(By.ClassName("form-input"))[2];
            passwordField.SendKeys(password);
        }

        public void ClickCreateAccount()
        {
            //First button in the form is Create Account
            IWebElement createAccountButton = signUpForm.FindElement(By.TagName("button"));
            createAccountButton.Click();
        }

        public string GetPrivacyPolicyErrorMessage()
        {
            //Privacy Policy error message should be the last item of the list if it existed
            //because it is under Privacy Policy which is the last input item of the form
            IList<IWebElement> errorMessages = signUpForm.FindElements(By.ClassName("form-error"));
            int length = errorMessages.Count;
            return errorMessages[length - 1].Text;
        }
    }
}
