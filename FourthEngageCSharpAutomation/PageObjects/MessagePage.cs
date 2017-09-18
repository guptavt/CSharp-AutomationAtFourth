using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Fourth.Automation.Framework.Infrastructure;
using Fourth.Automation.Framework.Mobile;
using Fourth.Automation.Framework.Page;
using Fourth.Automation.Framework.Extension;
using System.Configuration;
using NUnit.Framework;
using System.Threading.Tasks;
using System.Linq;
using System.Text.RegularExpressions;
using System;
using System.Threading;
using System.Collections.Generic;
using System.Collections;
using System.Security.AccessControl;

namespace Fourth.Mobile.Framework.PageObject
{
	public class MessagePage : BasePage
	{
		#region Constructor
		public MessagePage(IWebDriver webDriver) : base(webDriver)
		{
		}
		#endregion
		#region GlobalVariables

		public String myText;

		#endregion

		#region PageObjects
		[FindsBy(How = How.CssSelector, Using = "article")]
		public IList<IWebElement> ArticlesList { get; set; }

		public By ArticleMessageText = By.CssSelector(".content-text");


		[FindsBy(How = How.CssSelector, Using = "textarea#post-textarea")]
		public IWebElement MessageBox { get; set; }


		[FindsBy(How = How.CssSelector, Using = ".message-element")]
		public IWebElement FirstMessage { get; set; }

		#endregion

		#region Methods

		public void WaitToBeReady()
		{
			Thread.Sleep(8000);
		}

		public void WriteMessageBody(String MessageText)
		{
			WaitToBeReady();
			MessageBox.ClearAndSendKeys(MessageText);
		}

		public void ClickLatestMessage()
		{
			WaitToBeReady();
			Console.WriteLine("----------" + FirstMessage);
			FirstMessage.Click();
		}


		public void GetMessageTextAndLastUpdatedTime(String FeedText)
		{
			WaitToBeReady();
			myText = ArticlesList.First(article => article.FindElement(ArticleMessageText).Text == FeedText).Text;

		}
		public void VerifyMessageTextAndLastUpdatedTime(String FeedText, String LastUpdatedTime)
		{
			WaitToBeReady();
			Assert.True(myText.Contains(FeedText));
			Assert.True(myText.Contains(LastUpdatedTime));
		}

		#endregion

	}
}
