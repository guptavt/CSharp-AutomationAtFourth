using TechTalk.SpecFlow;
using Fourth.Mobile.Framework.PageObject;
using NUnit.Framework;

namespace FourthEngageCSharpAutomation.StepDefinitions
{
    [Binding]
    public class OtherMenusSteps
    {
        private OtherMenus _otherMenus;

        public OtherMenusSteps( OtherMenus othermenus)
        {
            _otherMenus = othermenus;
        }
       
        [Given(@"I click the ""(.*)"" left side menu")]
        public void GivenIClickTheLeftSideMenu(string menuName)
        {
            _otherMenus.ClickLeftSideMenuButton(menuName);
        }

        [When(@"I able to capture the header content")]
        public void WhenIAbleToCaptureTheHeaderContent()
        {
            // Add later necessary content
           // ScenarioContext.Current.Pending();
        }

        [Then(@"I validate the header ""(.*)"" content")]
        public void ThenIValidateTheHeaderContent(string itemName)
        {
            Assert.True(_otherMenus.GetSectionHeader(itemName).Contains(itemName));
        }


    }
}
