// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace FourthEngageCSharpAutomation.Features.Notifications
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Engage -- Notifications -- A")]
    public partial class Engage_Notifications_AFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "NotificationsA.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Engage -- Notifications -- A", "\tAs an Engage user\n\tI expect to have notifications inside the Dashboard\n\tSo that I can be kept up to date on in-app events that interest me", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Notification counter incrementing")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        [NUnit.Framework.TestCaseAttribute("The following user is notified:", new string[0])]
        public virtual void NotificationCounterIncrementing(string message, string[] exampleTags)
        {
            string[] __tags = new string[]
            {
                    "smoke"};
            if ((exampleTags != null))
            {
                __tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Notification counter incrementing", __tags);
#line 7
 this.ScenarioSetup(scenarioInfo);
#line 8
  testRunner.Given("I log in with valid credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
  testRunner.And("I remember the count of unread notifications", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
  testRunner.When("I start writing a new post", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
  testRunner.And(string.Format("I add {0} text", message), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
  testRunner.And("I mention myself", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
  testRunner.And("I click the Submit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
  testRunner.Then("I see the count of unread notifications increment", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Notification counter decrementing")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        [NUnit.Framework.TestCaseAttribute("The following user is notified:", new string[0])]
        public virtual void NotificationCounterDecrementing(string message, string[] exampleTags)
        {
            string[] __tags = new string[]
            {
                    "smoke"};
            if ((exampleTags != null))
            {
                __tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Notification counter decrementing", __tags);
#line 21
 this.ScenarioSetup(scenarioInfo);
#line 22
  testRunner.Given("I log in with valid credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 23
  testRunner.And("I start writing a new post", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
  testRunner.And(string.Format("I add {0} text", message), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
  testRunner.And("I mention myself", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
  testRunner.And("I click the Submit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
  testRunner.When("I remember the count of unread notifications", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
  testRunner.And("I click the \"Notifications\" side panel button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
  testRunner.And("I click the latest notification", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
  testRunner.Then("I see the count of unread notifications decrement", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
