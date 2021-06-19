using CSharpSpecFlow.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSpecFlow.PageObject
{
    class SignUpPage
    {
        IWebDriver driver;

        public SignUpPage ()
        {
            driver = Hooks1.driver;
        }

        IWebElement username => driver.FindElement(By.XPath(".//input[@placeholder='Username']"));
        IWebElement email => driver.FindElement(By.XPath(".//input[@placeholder='Email']"));
        IWebElement password => driver.FindElement(By.XPath(".//input[@placeholder='Password']"));
        IWebElement signUp => driver.FindElement(By.CssSelector(".btn.btn-lg.btn-primary.pull-xs-right.ng-binding"));
        IWebElement popularTags => driver.FindElement(By.XPath(".//p[text()='Popular Tags']"));

        int randomInt = 0;

        public void EnterUsername()
        {
            Random randomGenerator = new Random();
            randomInt = randomGenerator.Next(1000);
            username.SendKeys("udemy"+randomInt+"@yahoo.com");
        }

        public void EnterEmail()
        {
            email.SendKeys("udemy"+randomInt+"@yahoo.com");
        }

        public void EnterPassword()
        {
            password.SendKeys("BDDtestCucumber123!");
        }

        public void SignUp()
        {
            signUp.Click();
        }

        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("http://angularjs.realworld.io/#/register");
        }

        public bool IsPopularTagsDisplayed()
        {
            return popularTags.Displayed;
        }
    }
}
