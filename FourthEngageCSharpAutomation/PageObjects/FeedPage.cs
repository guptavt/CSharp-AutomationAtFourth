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
	public class FeedPage : BasePage
	{
		#region Constructor
		public FeedPage(IWebDriver webDriver) : base(webDriver)
		{
		}
		#endregion

		#region GlobalVariables

		public String myText;

		#endregion

		#region PageObjects

		[FindsBy(How = How.CssSelector, Using = "article")]
		public IList<IWebElement> ArticlesList { get; set; }

		public By ArticleFeedText = By.CssSelector(".content-text");

		[FindsBy(How = How.CssSelector, Using = ".list .item:first-child")]
		public IWebElement FirstFeed { get; set; }

		[FindsBy(How = How.CssSelector, Using = "#post-textarea")]
		public IWebElement messageTextArea { get; set; }

		[FindsBy(How = How.CssSelector, Using = ".primary-button")]
		public IWebElement ReplyPostButton { get; set; }

		[FindsBy(How = How.CssSelector, Using = ".comment-item")]
		public IWebElement CommentItem { get; set; }

		[FindsBy(How = How.CssSelector, Using = ".order-content .comment-counter")]
		public IWebElement CommentCount { get; set; }
		#endregion

		#region Methods

		public void WaitToBeReady()
		{
			Thread.Sleep(5000);
		}

		public void GetFeedTextAndLastUpdatedTime(String FeedText)
		{
			WaitToBeReady();
			myText = ArticlesList.First(article => article.FindElement(ArticleFeedText).Text == FeedText).Text;

		}
		public void VerifyFeedTextAndLastUpdatedTime(String FeedText, String LastUpdatedTime)
		{
			Assert.True(myText.Contains(FeedText));
			Assert.True(myText.Contains(LastUpdatedTime));
		}
		public void ClickLatestFeed()
		{
			WaitToBeReady();
			FirstFeed.Click();

		}
		public void WriteReply(String ReplyText)
		{
			WaitToBeReady();
			messageTextArea.SendKeys(ReplyText);
		}

		public void ClickReplyPostButton()
		{
			WaitToBeReady();
			ReplyPostButton.Click();
			//Thread.Sleep(5000);
		}

		public void VerifyReplyPost(String ReplyPost)
		{
			WaitToBeReady();
			Assert.True(CommentItem.Text.Contains(ReplyPost));
		}

		public void VerifyReplyCount(String ReplyCount)
		{
			Assert.True(CommentCount.Text.EndsWith(ReplyCount, StringComparison.Ordinal));
		}
		#endregion

	}
}