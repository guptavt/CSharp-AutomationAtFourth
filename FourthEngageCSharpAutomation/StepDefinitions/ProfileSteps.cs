using System;
using TechTalk.SpecFlow;
using Fourth.Mobile.Framework.PageObject;
using System.Threading;
using NUnit.Framework;

namespace FourthEngageCSharpAutomation.StepDefinitions
{
    [Binding]
    public class ProfileSteps
    {

        private MainPage _mainPage;
        private ProfilePage _profilePage;
        private string _tempLastName,_tempBeforeModifyName;

        public ProfileSteps(MainPage mainPage,ProfilePage profilePage)
        {
            _mainPage = mainPage;
            _profilePage = profilePage;
        }

        [Given(@"I click the user profile button")]
        public void GivenIClickTheUserProfileButton()
        {
            _profilePage.ClickProfileButton();
        }

        [Given(@"I click the ""(.*)"" right side button")]
        public void GivenIClickTheRightSideButton(string buttonLabel)
        {
            Thread.Sleep(5000);
            _profilePage.ClickEditButton(buttonLabel);
        }
               
        [Given(@"I modify the ""(.*)"" Lastname")]
        public void GivenIModifyTheLastname(string lastName)
        {
            _tempLastName = lastName + DateTime.Now.ToString("dd-MM-yyyy HH:mm");
            _profilePage.EnterLastName(_tempLastName);
        }

        [Then(@"I able to see the modified lastname")]
        public void ThenIAbleToSeeTheModifiedLastname()
        {
            Thread.Sleep(5000);
            Assert.True(_tempLastName.Equals(_profilePage.GetLastName()));
        }

        [Given(@"I copied the user lastname")]
        public void GivenICopiedTheUserLastname()
        {
            Thread.Sleep(5000);
            _tempBeforeModifyName = _profilePage.GetLastName();
        }

        [Then(@"I able to compare the before modified name")]
        public void ThenIAbleToCompareTheBeforeModifiedName()
        {
            Thread.Sleep(5000);
            //It is system defect and need to fix
            Assert.True(_tempBeforeModifyName.Equals(_profilePage.GetLastName()));
        }

        [Given(@"I click the left cancel button")]
        public void GivenIClickTheLeftCancelButton()
        {
            _mainPage.ClickBackbutton();
            Thread.Sleep(5000);
            _mainPage.RefreshPage();
            
        }



    }
}



