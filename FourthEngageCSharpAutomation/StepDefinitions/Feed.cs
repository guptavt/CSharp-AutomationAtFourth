using TechTalk.SpecFlow;
using Fourth.Mobile.Framework.PageObject;
using NUnit.Framework;
using System;
using Fourth.Automation.Framework.Core;

namespace Fourth.Mobile.Framework
{
	[Binding]
	public class FeedSteps
	{
		private FeedPage FeedPage;


		public FeedSteps(FeedPage feedPage)
		{
			FeedPage = feedPage;

		}

		[Then(@"I verify Feed body to contain (.*) and last updated Time to be (.*)")]
		public void ThenIVerifyFeedBodyToContainAndLastUpdatedTimeToBe(String FeedText, String LastUpdatedTime)
		{
			FeedPage.GetFeedTextAndLastUpdatedTime(FeedText);
			FeedPage.VerifyFeedTextAndLastUpdatedTime(FeedText, LastUpdatedTime);
		}

		[When(@"I add reply (.*)")]
		public void WhenIAddReply(string ReplyText)
		{
			FeedPage.WriteReply(ReplyText);
		}


		[When(@"I click on ""(.*)"" button")]

		public void WhenIClickOnButton(string Post)
		{
			FeedPage.ClickReplyPostButton();
		}


		[Then(@"I verify that (.*) appears on the message trail")]

		public void ThenIVerifyThatReplyAppearsOnTheMessageTrail(string replyText)
		{
			FeedPage.VerifyReplyPost(replyText);
		}


		[Then(@"number of replies text updated to ""(.*)""")]

		public void ThenNumberOfRepliesTextUpdatedTo(String replyCount)
		{
			FeedPage.VerifyReplyCount(replyCount);
		}


	}
}