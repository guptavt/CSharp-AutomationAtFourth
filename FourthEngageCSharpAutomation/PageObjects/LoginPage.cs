using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Fourth.Automation.Framework.Core;
using Fourth.Automation.Framework.Mobile;
using Fourth.Automation.Framework.Page;
using Fourth.Automation.Framework.Extension;
using System.Configuration;
using NUnit.Framework;
using System;

namespace Fourth.Mobile.Framework.PageObject
{
	public class Login : BasePage
	{
		#region Constructor
		public Login(IWebDriver webDriver) : base(webDriver)
		{
			SetMobileContext();
		}
		#endregion

		#region PageObjects
		[FindsBy(How = How.CssSelector, Using = "input[id*='username']")]
		public IWebElement UserNameInput { get; set; }

		[FindsBy(How = How.CssSelector, Using = "input[type='password']")]
		public IWebElement PasswordInput { get; set; }

		[FindsBy(How = How.CssSelector, Using = "input[type='submit']")]
		public IWebElement SignInButton { get; set; }

		[FindsBy(How = How.CssSelector, Using = ".error-msg")]
		public IWebElement ErrorMessage { get; set; }

		[FindsBy(How = How.CssSelector, Using = ".fourth-link")]
		public IWebElement FourthFooter { get; set; }
		#endregion

		#region Methods
		public void OpenLoginPage()
		{
			if (!Driver.IsMobile())
			{
				Driver.Navigate().GoToUrl(ConfigurationSettings.AppSettings["WebSite.Url"]);
			}
		}

		public void PerformLogin(string credentials)
		{
			WaitForPageToLoad();
			switch (credentials)
			{
				case "valid":
					UserNameInput.ClearAndSendKeys(ConfigurationSettings.AppSettings["User"]);
					PasswordInput.ClearAndSendKeys(ConfigurationSettings.AppSettings["Password"]);
					break;
				case "blank":
					UserNameInput.ClearAndSendKeys("");
					PasswordInput.ClearAndSendKeys("");
					break;
				case "invalid":
					UserNameInput.ClearAndSendKeys("improper@user.com");
					PasswordInput.ClearAndSendKeys("password");
					break;
			}
			SignInButton.Click();
		}

		public void VerifyError(string credentialType)
		{
			if (Driver.IsMobile())
			{
				Driver.WaitElementToExists(ErrorMessage);
				Assert.True("Your username and/or password is not correct.".Equals(ErrorMessage.Text.Trim()));
			}
			else
			{
				switch (credentialType)
				{
					case "blank":
						Assert.True("Your username and/or password is not correct.".Equals(ErrorMessage.Text.Trim()));
						break;
					case "invalid":
						Assert.True("Your login attempt has failed. Make sure the username and password are correct.".Equals(ErrorMessage.Text.Trim()));
						break;
				}
			}
		}

		public void VerifyFourthFooter()
		{
			WaitForPageToLoad();
			Assert.True(FourthFooter.Exist());
		}

		public void WaitForPageToLoad()
		{
			Driver.WaitIsClickable(PasswordInput);
		}

		public void SetMobileContext()
		{
			if (Driver.IsMobile())
			{
				Driver.AsMobile().Context = Driver.AsMobile().Contexts[1];
			}
		}
		#endregion
	}
}