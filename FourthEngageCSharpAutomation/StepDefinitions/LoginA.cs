using TechTalk.SpecFlow;
using Fourth.Mobile.Framework.PageObject;
using NUnit.Framework;
using System;
using Fourth.Automation.Framework.Core;

namespace Fourth.Mobile.Framework
{
	[Binding]
	public class LoginSteps
	{
		private Login Login;
		private MainPage MainPage;

		public LoginSteps(Login login, MainPage mainPage)
		{
			Login = login;
			MainPage = mainPage;
		}

		[Given(@"I log in with (.*) credentials")]
		public void GivenILoginWithCredentials(string credentials)
		{
			Login.OpenLoginPage();
			Login.PerformLogin(credentials);
		}

		[Then(@"I see the Hamburger Menu button")]
		public void ThenISeeTheHamburgerMenuIcon()
		{
			MainPage.VerifyHamburgerButton();
		}

		[Then(@"I see the (.*) credentials error message")]
		public void ThenISeeError(string credentialType)
		{
			Login.VerifyError(credentialType);
		}
	}
}