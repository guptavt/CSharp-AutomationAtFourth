using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Fourth.Automation.Framework.Core;
using Fourth.Automation.Framework.Mobile;
using Fourth.Automation.Framework.Page;
using Fourth.Automation.Framework.Extension;
using System.Configuration;
using NUnit.Framework;
using System;

namespace Fourth.Mobile.Framework.PageObject
{
	public class SignOutModal : BasePage
	{
		#region Constructor
		public SignOutModal(IWebDriver webDriver) : base(webDriver)
		{
		}
		#endregion

		#region PageObjects
		[FindsBy(How = How.ClassName, Using = "popup-buttons")]
		public IWebElement SignOutModalButtons { get; set; }
		#endregion

		#region Methods
		public void WaitForButtons()
		{
			Driver.WaitIsClickable(SignOutModalButtons);
		}

		public void ClickModalButton(string buttonLabel)
		{
			Driver.FindElement(By.XPath("//button[.=" + buttonLabel + "]")).Click();
		}
		#endregion
	}
}