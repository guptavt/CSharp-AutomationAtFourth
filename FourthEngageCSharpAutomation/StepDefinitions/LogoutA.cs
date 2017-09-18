using TechTalk.SpecFlow;
using Fourth.Mobile.Framework.PageObject;
using NUnit.Framework;
using System;
using Fourth.Automation.Framework.Core;

namespace Fourth.Mobile.Framework
{
	[Binding]
	public class LogoutSteps
	{
		private Login Login;
		private MainPage MainPage;
		private SignOutModal SignOutModal;

		public LogoutSteps(Login login, MainPage mainPage, SignOutModal signOutModal)
		{
			Login = login;
			MainPage = mainPage;
			SignOutModal = signOutModal;
		}

		[When(@"I click the (.*) modal button")]
		public void WhenIClickTheModalButton(string modalButton)
		{
			SignOutModal.WaitForButtons();
			SignOutModal.ClickModalButton(modalButton);
		}

		[Then(@"I see the (.*) side panel button")]
		public void ThenISeeSidePanelButton(string sidePanelButton)
		{
			MainPage.VerifySidePanelButton(sidePanelButton);
		}

		[Then(@"I see Fourth footer")]
		public void ThenISeeFourthFooter()
		{
			Login.VerifyFourthFooter();
		}
	}
}