using TechTalk.SpecFlow;
using Fourth.Mobile.Framework.PageObject;
using NUnit.Framework;
using System;
using Fourth.Automation.Framework.Core;
using System.Threading.Tasks;
using Fourth.Automation.Framework.Extension;
using System.Threading;

namespace Fourth.Mobile.Framework
{
	[Binding]
	public class NotificationsSteps
	{
		private MainPage MainPage;
		private AddPostModal AddPostModal;
		private MentionUserModal MentionUserModal;
		private NotificationsPage NotificationsPage;

		public NotificationsSteps(MainPage mainPage, AddPostModal addPostModal, MentionUserModal mentionUserModal, NotificationsPage notificationsPage)
		{
			MainPage = mainPage;
			AddPostModal = addPostModal;
			MentionUserModal = mentionUserModal;
			NotificationsPage = notificationsPage;
		}

		[Then(@"I see the count of unread notifications (.*)")]
		public void ThenISeeTheCountOfUnreadNotificationsChange(string change)
		{
			switch (change)
			{
				case "increment":
					MainPage.WaitToBeReady();
					MainPage.WaitForClickBlock();
					MainPage.AssertNotificationsGreaterByOne();
					break;
				case "decrement":
					MainPage.WaitToBeReady();
					MainPage.WaitForClickBlock();
					MainPage.AssertNotificationsLowerByOne();
					break;
			}
		}
	}
}
