using TechTalk.SpecFlow;
using Fourth.Mobile.Framework.PageObject;
using NUnit.Framework;
using System;
using Fourth.Automation.Framework.Core;
using System.Threading;

namespace Fourth.Mobile.Framework
{
	[Binding]
	public class CommonSteps
	{
		private MainPage MainPage;
		private AddPostModal AddPostModal;
		private MentionUserModal MentionUserModal;
		private NotificationsPage NotificationsPage;
		private FeedPage FeedPage;
		private MessagePage MessagePage;

		public CommonSteps(FeedPage feedPage, MainPage mainPage, AddPostModal addPostModal, MentionUserModal mentionUserModal, NotificationsPage notificationsPage, MessagePage messagePage)
		{
			MainPage = mainPage;
			AddPostModal = addPostModal;
			MentionUserModal = mentionUserModal;
			NotificationsPage = notificationsPage;
			FeedPage = feedPage;
			MessagePage = messagePage;

		}

		[StepDefinition(@"I remember the count of unread notifications")]
		public void RememberTheCountOfUnreadNotifications()
		{
			MainPage.WaitToBeReady();
			MainPage.WaitForClickBlock(); // FIXME: Shouldn't always be a WaitForClickBlock, as if it's run before any "actionable" step, there is no click-block element on-screen.
			MainPage.RememberCurrentNotifications();
		}

		[StepDefinition(@"I start writing a new post")]
		public void StartWritingANewPost()
		{
			MainPage.WaitToBeReady();
			MainPage.WriteNewFeedButton.Click();
		}

		[StepDefinition(@"I add (.*) text")]
		public void AddTextToTheAddPostModal(string text)
		{
			AddPostModal.AddText(text);
		}

		[StepDefinition(@"I click the Submit button")]
		public void SubmitTheAddPostModal()
		{
			MainPage.WaitForClickBlock();
			AddPostModal.WaitAndSubmit();
		}

		[StepDefinition(@"I mention (.*)")]
		public void MentionInAddPost(string username)
		{
			AddPostModal.WaitAndClickToMention();
			MentionUserModal.SearchForUser(username);
		}

		[StepDefinition(@"I click the (.*) side panel button")]
		public void WhenIClickTheSidePanelButton(string buttonLabel)
		{
			Thread.Sleep(5000);
			MainPage.ScrollToSidePanelButton(buttonLabel);
			MainPage.ClickSidePanelButton(buttonLabel);
		}

		[StepDefinition("I click the latest (.*)")]
		public void ThenISeeLoaded(string FeedNotification)
		{
			Thread.Sleep(8000);
			switch (FeedNotification)
			{
				case "notification":
					NotificationsPage.WaitForLoad();
					NotificationsPage.VisitLatestNotification();
					break;

				case "feed":
					FeedPage.ClickLatestFeed();
					break;
				case "message":
					//Thread.Sleep(8000);
					MessagePage.ClickLatestMessage();
					break;

			}
		}

		[StepDefinition(@"I do a @mention in message for (.*)")]
		public void WhenIDoAMentionInMessageFor(string username)
		{
			switch (username)
			{
				case "myself":
					MentionUserModal.FindMyself();
					break;
				case "another user":
					MentionUserModal.FindAnotherUser();
					break;
			}
		}
	}
}