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
	public class AddPostModal : BasePage
	{
		#region Constructor
		public AddPostModal(IWebDriver webDriver) : base(webDriver)
		{
		}
		#endregion

		#region PageObjects
		[FindsBy(How = How.XPath, Using = "/html/body/div[4]")]
		public IWebElement ClickBlocker { get; set; }

		[FindsBy(How = How.Id, Using = "post-textarea")]
		public IWebElement PostTextArea { get; set; }

		[FindsBy(How = How.ClassName, Using = "icon-user-single-add")]
		public IWebElement MentionButton { get; set; }

		[FindsBy(How = How.CssSelector, Using = "button[ng-click='cancelModalAction()']")]
		public IWebElement ModalCancelButton { get; set; }

		[FindsBy(How = How.CssSelector, Using = "button[ng-click='submitModalAction()']")]
		public IWebElement ModalSubmitButton { get; set; }
		#endregion

		#region Methods
		private void WaitToBeReady()
		{
			Driver.WaitIsClickable(PostTextArea);
		}

		public void AddText(string text)
		{
			WaitToBeReady();
			PostTextArea.ClearAndSendKeys(text);
		}

		public void WaitAndClickToMention()
		{
			WaitToBeReady();
			MentionButton.Click();
		}

		public void WaitAndSubmit()
		{
			WaitToBeReady();
			ModalSubmitButton.Click();
		}
		#endregion
	}
}