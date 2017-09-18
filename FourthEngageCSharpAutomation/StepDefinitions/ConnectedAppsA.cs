using TechTalk.SpecFlow;
using Fourth.Mobile.Framework.PageObject;
using NUnit.Framework;
using System;
using Fourth.Automation.Framework.Core;

namespace Fourth.Mobile.Framework
{
	[Binding]
	public class ConnectedAppsSteps
	{
		private MainPage MainPage;
		private AllApplicationsModal AllApplicationsModal;

		private ESSConnectedApp ESSConnectedApp;

		public ConnectedAppsSteps(MainPage mainPage, AllApplicationsModal allApplicationsModal, ESSConnectedApp essConnectedApp)
		{
			MainPage = mainPage;
			AllApplicationsModal = allApplicationsModal;

			ESSConnectedApp = essConnectedApp;
		}

		[When("I select the (.*) Connected App")]
		public void WhenISelectConnectedApp(string connectedAppName)
		{
			MainPage.OpenAllApplications();
			AllApplicationsModal.WaitForButtons();
			AllApplicationsModal.ClickModalButton(connectedAppName);
		}

		[Then("I see (.*) has loaded")]
		public void ThenISeeLoaded(string connectedAppName)
		{
			switch (connectedAppName)
			{
				case "ESS":
					ESSConnectedApp.ValidatePageOpen();
					break;
			}
		}
	}
}
