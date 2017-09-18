using TechTalk.SpecFlow;
using Fourth.Mobile.Framework.PageObject;
using NUnit.Framework;
using System;
using Fourth.Automation.Framework.Core;
using System.ServiceModel.Channels;

namespace Fourth.Mobile.Framework
{
	[Binding]
	public class MessageSteps
	{

		private MainPage MainPage;
		private MentionUserModal MentionUserModal;
		private MessagePage MessagePage;
		private FeedPage FeedPage;

		public MessageSteps(MainPage mainPage, MentionUserModal mentionUserModal, MessagePage messagePage, FeedPage feedPage)
		{

			MainPage = mainPage;
			MentionUserModal = mentionUserModal;
			MessagePage = messagePage;
			FeedPage = feedPage;
		}

		[Given(@"I click on Add new message")]
		public void GivenIClickOnAddNewMessage()
		{
			MainPage.ClickAddMessageButton();
		}

		[Then(@"search result should be empty")]

		public void ThenSearchResultShouldBeEmpty()
		{
			MentionUserModal.VerifyEmptyAtMentionList();
		}

		[When(@"I write (.*) in the message body")]

		public void WhenIWriteThisIsAPrivateMessageInTheMessageBody(string messageBody)
		{
			MessagePage.WriteMessageBody(messageBody);
		}

		[Then(@"I verify message body to contain (.*) and last updated Time to be (.*)")]

		public void ThenIVerifyMessageBodyToContainThisIsAPrivateMessageAndLastUpdatedTimeToBeLastUpdatedJustNow(string messageText, string LastUpdatedTime)
		{
			MessagePage.GetMessageTextAndLastUpdatedTime(messageText);
			MessagePage.VerifyMessageTextAndLastUpdatedTime(messageText, LastUpdatedTime);
		}
	}
}
