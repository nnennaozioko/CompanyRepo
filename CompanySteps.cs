using GuideProject.PageObjects;
using System;
using System.Security.Policy;
using TechTalk.SpecFlow;

namespace GuideProject
{
    [Binding]
    public class CompanySteps
    {
        CompanyPage companyPage;

        [Given(@"I navigate to the ""([^""]*)""")]
        public void GivenINavigateToThe(string url)
        {
            companyPage.Navigate(url);
        }

        [Then(@"HTML Table is display")]
        public void ThenHTMLTableIsDisplay()
        {
            throw new PendingStepException();
        }

        [When(@"I enter the <company>")]
        public void WhenIEnterTheCompany()
        {
            throw new PendingStepException();
        }

        [When(@"I enter Francisco chang")]
        public void WhenIEnterFranciscoChang()
        {
            throw new PendingStepException();
        }

        [When(@"I enter the Germany")]
        public void WhenIEnterTheGermany()
        {
            throw new PendingStepException();
        }

        [Then(@"the <compay> Francisco chang Germany is displayed")]
        public void ThenTheCompayFranciscoChangGermanyIsDisplayed()
        {
            throw new PendingStepException();
        }

                [When(@"I enter Roland Mendel")]
        public void WhenIEnterRolandMendel()
        {
            throw new PendingStepException();
        }

        [When(@"I enter the Mexico")]
        public void WhenIEnterTheMexico()
        {
            throw new PendingStepException();
        }

        [Then(@"the <compay> Francisco chang Mexico is displayed")]
        public void ThenTheCompayFranciscoChangMexicoIsDisplayed()
        {
            throw new PendingStepException();
        }


    }
}
