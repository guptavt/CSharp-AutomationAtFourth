using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Fourth.Automation.Framework.Core;
using Fourth.Automation.Framework.Mobile;
using Fourth.Automation.Framework.Page;
using Fourth.Automation.Framework.Extension;
using System.Configuration;
using NUnit.Framework;
using System;
using System.Threading;

namespace Fourth.Mobile.Framework.PageObject
{
	public class MentionUserModal : BasePage
	{
		#region Constructor
		public MentionUserModal(IWebDriver webDriver) : base(webDriver)
		{
		}
		#endregion

		#region PageObjects
		[FindsBy(How = How.CssSelector, Using = "input[type='search']")]
		public IWebElement SearchInputField { get; set; }

		[FindsBy(How = How.CssSelector, Using = "span.autocomplete-label")]
		public IWebElement SearchResults { get; set; }

		[FindsBy(How = How.CssSelector, Using = ".search-people-modal .modal-content .mention-search")]
		public IWebElement emptySearchresult { get; set; }

		#endregion

		#region Methods
		public void WaitForInput()
		{
			Driver.WaitForDomToLoad();
			Driver.WaitIsClickable(SearchInputField);
		}

		public void SearchForUser(string username)
		{
			// TODO: Investigate on whether you could get rid of WaitForInput and put it inside this one method only. 
			switch (username)
			{
				case "myself":
					// TODO: Go to Profile and get data from there for this particular case only (based on App.config).
					WaitForInput();
					SearchInputField.ClearAndSendKeys("approver testington");
					Thread.Sleep(2000);
					Driver.WaitIsClickable(SearchResults);
					Driver.FindElement(By.XPath("//span[.='approver testington']")).Click();
					break;

				default:
					// TODO: Exactly as Vinita does it.
					break;
			}
		}

		public void FindMyself()
		{
			WaitForInput();
			SearchInputField.ClearAndSendKeys("approver testington");
			Thread.Sleep(5000);
		}
		public void FindAnotherUser()
		{
			Thread.Sleep(2000);
			WaitForInput();
			//SearchInputField.ClearAndSendKeys("Dont Disturb me 3");approver testington
			SearchInputField.ClearAndSendKeys("approver testington");
			Thread.Sleep(2000);
			Driver.WaitIsClickable(SearchResults);
			Driver.FindElement(By.XPath("//span[.='approver testington']")).Click();

		}

		public void VerifyEmptyAtMentionList()
		{
			Assert.IsFalse(emptySearchresult.Exist());
		}
		#endregion
	}
}