using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Configuration;
using Fourth.Automation.Framework.Core;
using Fourth.Automation.Framework.Mobile.Resolvers;
using BoDi;

namespace Fourth.Mobile.Framework
{
	[Binding]
	public sealed class Hooks
	{
		private readonly IObjectContainer objectContainer;
		private IWebDriver driver;

		public Hooks(IObjectContainer container)
		{
			this.objectContainer = container;
		}

		[BeforeTestRun]
		public static void BeforeTestRun()
		{
			DriverFactory.Resolvers.Add(new AndroidResolver());
			DriverFactory.Resolvers.Add(new IOSResolver());
		}

		[BeforeScenario]
		public void BeforeScenario()
		{
			driver = DriverFactory.Create();
			objectContainer.RegisterInstanceAs<IWebDriver>(driver);
		}

		[AfterScenario]
		public void AfterScenario()
		{
			driver.Quit();
		}
	}
}
