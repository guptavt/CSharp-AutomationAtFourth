
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Fourth.Automation.Framework.Page;
using Fourth.Automation.Framework.Extension;
using System.Threading;

namespace Fourth.Mobile.Framework.PageObject
{
    public class ProfilePage : BasePage
	{
		#region Constructor
		public ProfilePage(IWebDriver webDriver) : base(webDriver)
		{
		}
		#endregion


        #region PageObjects

        [FindsBy(How = How.Id, Using = "menu-image")]
        public IWebElement ProfileButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@ng-model='user.LastName']")]
        public IWebElement TextPhone { get; set; }


        public void ClickUserButton(string buttonLabel)
        {
            Driver.FindElement(By.CssSelector(string.Format(".{0}", buttonLabel))).Click();
        }

        public By ArticleFeedText = By.CssSelector(".content-text");

        [FindsBy(How = How.CssSelector, Using = ".last-name")]
        public IWebElement LebelLastName { get; set; }
        #endregion
        #region methods

        public void WaitToBeReady()
        {
            Thread.Sleep(5000);
        }
        public void ClickProfileButton()
        {
            WaitToBeReady();
            ProfileButton.Click();
        }

        public void ClickEditButton(string buttonName)
        {
            ClickUserButton(buttonName);

        }

        public void EnterLastName(string lastName)
        {
            TextPhone.ClearAndSendKeys(lastName);
        }

        public string GetLastName()
        {
            return LebelLastName.Text;
        }
        #endregion
    }
}


