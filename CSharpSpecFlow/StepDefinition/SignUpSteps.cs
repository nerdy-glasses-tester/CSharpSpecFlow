using CSharpSpecFlow.PageObject;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace CSharpSpecFlow.StepDefinition
{
    [Binding]
    public class SignUpSteps
    {
        SignUpPage signUpPage;

        public SignUpSteps()
        {
            signUpPage = new SignUpPage();
        }

        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            signUpPage.NavigateToWebsite();

        }
        
        [Given(@"I enter my username")]
        public void GivenIEnterMyUsername()
        {
            signUpPage.EnterUsername();
        }
        
        [Given(@"I enter my email")]
        public void GivenIEnterMyEmail()
        {
            signUpPage.EnterEmail();
        }
        
        [Given(@"I enter my password")]
        public void GivenIEnterMyPassword()
        {
            signUpPage.EnterPassword();
        }
        
        [When(@"I click on Sign Up")]
        public void WhenIClickOnSignUp()
        {
            signUpPage.SignUp();
        }
        
        [Then(@"I should be able to register successfully")]
        public void ThenIShouldBeAbleToRegisterSuccessfully()
        {
            Thread.Sleep(5000);
            Assert.That(signUpPage.IsPopularTagsDisplayed());
        }
    }
}
