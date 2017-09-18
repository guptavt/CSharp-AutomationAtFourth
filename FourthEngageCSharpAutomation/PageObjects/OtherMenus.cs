
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Fourth.Automation.Framework.Page;
using Fourth.Automation.Framework.Extension;
using System.Threading;

namespace Fourth.Mobile.Framework.PageObject
{
    public class OtherMenus : BasePage
	{
        #region Constructor
        public OtherMenus(IWebDriver webDriver) : base(webDriver)
		{
        }
        #endregion

   
        #region PageObjects

        public void ClickLeftButton(string buttonLabel)
        {
            Driver.FindElement(By.XPath(string.Format("//ion-item[@ng-click=\"navigateTo('app.{0}')\"]", buttonLabel))).Click();
        }

        [FindsBy(How = How.ClassName, Using = "conent-list-header")]
        public IWebElement GetContentHeaderText { get; set; }

       
        #endregion
        #region methods

        public void ClickLeftSideMenuButton(string buttonName)
        {
            Thread.Sleep(8000);
            ClickLeftButton(buttonName);
            Thread.Sleep(5000);
        }

        public string GetSectionHeader(string contentHeader)
        {
            return GetContentHeaderText.Text;
        }
        #endregion
    }
}


