using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Fourth.Automation.Framework.Mobile;
using Fourth.Automation.Framework.Page;
using Fourth.Automation.Framework.Extension;
using System.Configuration;
using NUnit.Framework;
using System;
using System.Threading;

namespace Fourth.Mobile.Framework.PageObject
{
    public class MainPage : BasePage
	{
		#region Constructor
		public MainPage(IWebDriver webDriver) : base(webDriver)
		{
		}
		#endregion

		#region GlobalVariables
		public int unreadNotifications;
		#endregion

		#region PageObjects
		[FindsBy(How = How.XPath, Using = "//span[@class='left-buttons']")]
		public IWebElement HamburgerButton { get; set; }

		[FindsBy(How = How.CssSelector, Using = "ion-side-menu[side='left']")]
		public IWebElement SidePanel { get; set; }

		[FindsBy(How = How.CssSelector, Using = "ion-item[ng-click=\"navigateTo('openApp', app)\"]")]
		public IWebElement ConnectedAppsListOfThree { get; set; }

		[FindsBy(How = How.ClassName, Using = "icon-layout-grid")]
		public IWebElement AllApplicationsButton { get; set; }

		[FindsBy(How = How.CssSelector, Using = "span.badge.right")]
		public IWebElement UnreadNotifications { get; set; }

		[FindsBy(How = How.ClassName, Using = "icon-editorial-pencil-write")]
		public IWebElement WriteNewFeedButton { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[4]")]
		public IWebElement ClickBlock { get; set; }

		[FindsBy(How = How.CssSelector, Using = ".icon-uniE90C")]
		public IWebElement addNewMessageButton { get; set; }

		#endregion

		#region Methods
		private void SetMobileContext()
		{
			if (Driver.IsMobile())
			{
				Driver.AsMobile().Context = "NATIVE_APP";
				Driver.AsMobile().Context = ConfigurationSettings.AppSettings["WebviewName"];
			}
		}

		public void WaitToBeReady()
		{
			SetMobileContext();
			Driver.WaitForDomToLoad();
			Driver.WaitElementToExists(SidePanel);
		}

		//public void WaitForHamburgerButton()
		//{
		//	SetMobileContext();
		//	Driver.WaitElementToExists(HamburgerButton);
		//}

		//public void WaitForSidePanel()
		//{
		//	SetMobileContext();
		//	Driver.WaitElementToExists(SidePanel);
		//}

		public void WaitForClickBlock()
		{
			// TODO: This method is currently a placeholder until more functionality is added into the automation framework.
			// NOTE: This method is also flaky. 
			Thread.Sleep(8000);
		}

		public void OpenAllApplications()
		{
			SetMobileContext();
			Driver.WaitElementToExists(ConnectedAppsListOfThree);
			AllApplicationsButton.Click();
		}

		public void ScrollToSidePanelButton(string buttonLabel)
		{
			WaitToBeReady();
			if (Driver.IsMobile())
			{
				HamburgerButton.Click();
				((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView()", FindXPathLabelledItem(buttonLabel));
			}
			else
			{
				((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView()", FindXPathLabelledItem(buttonLabel));
			}
		}

		public void ClickSidePanelButton(string buttonLabel)
		{
			WaitToBeReady();
			FindXPathLabelledItem(buttonLabel).Click();
		}

		public void VerifySidePanelButton(string sidePanelButtonLabel)
		{
			WaitToBeReady();
			Assert.True(FindXPathLabelledItem(sidePanelButtonLabel).Exist());
		}

		public IWebElement FindXPathLabelledItem(string itemLabel)
		{
			WaitToBeReady();
			return Driver.FindElement(By.XPath("//span[.=" + itemLabel + "]"));
		}

		public void RememberCurrentNotifications()
		{
			try
			{
				Driver.WaitElementToExists(UnreadNotifications);
				unreadNotifications = int.Parse(UnreadNotifications.Text.Trim());
			}
			catch (Exception ex)
			{
				unreadNotifications = 0;
				throw ex;
			}
		}

		public void AssertNotificationsGreaterByOne()
		{
			int currentNotifications = int.Parse(UnreadNotifications.Text.Trim());
			Assert.True(currentNotifications == ++unreadNotifications, "The current notification count was not incremented.");
		}

		public void AssertNotificationsLowerByOne()
		{
			int currentNotifications = int.Parse(UnreadNotifications.Text.Trim());
			Assert.True(currentNotifications == --unreadNotifications, "The current notification count was not decremented.");
		}

		public void VerifyHamburgerButton()
		{
			WaitToBeReady();
			Assert.True(HamburgerButton.Exist());
		}

		public void ClickAddMessageButton()
		{
			Thread.Sleep(3000);
			addNewMessageButton.Click();
		}

        public void ClickBackbutton()
        {
            HamburgerButton.Click();
        }

        public void RefreshPage()
        {
            Driver.Navigate().Refresh();
        }
		#endregion
	}
}