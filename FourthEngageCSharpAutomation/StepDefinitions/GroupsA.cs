

//Given I start writing a new post
//-> skipped because of previous errors
//And I add "New group post to verify like" text
//-> skipped because of previous errors
//And I click the Submit button
//-> skipped because of previous errors
//And I refresh the groups feed page
//-> No matching step definition found for the step.Use the following code to create one:

//		[Given(@"I refresh the groups feed page")]

//		public void GivenIRefreshTheGroupsFeedPage()
//{
//	ScenarioContext.Current.Pending();
//}

//When I click on Like button
//-> No matching step definition found for the step.Use the following code to create one:

//		[When(@"I click on Like button")]

//		public void WhenIClickOnLikeButton()
//{
//	ScenarioContext.Current.Pending();
//}

//Then I verify that number of likes on the post become 1
//-> No matching step definition found for the step.Use the following code to create one:

//		[Then(@"I verify that number of likes on the post become (.*)")]

//		public void ThenIVerifyThatNumberOfLikesOnThePostBecome(int p0)
//{
//	ScenarioContext.Current.Pending();
//}


using TechTalk.SpecFlow;
using Fourth.Mobile.Framework.PageObject;
using NUnit.Framework;
using System;
using Fourth.Automation.Framework.Core;

namespace Fourth.Mobile.Framework
{
	[Binding]
	public class Feed
	{
		private FeedPage FeedPage;


		public Feed(FeedPage FeedPag)
		{
			FeedPage = FeedPag;

		}

		[When(@"I visit the ""(.*)"" group")]
		public void WhenIVisitTheGroup(string p0)
		{
			ScenarioContext.Current.Pending();
		}
	}
}