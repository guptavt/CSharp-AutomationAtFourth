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
namespace FourthEngageCSharpAutomation.Features.Message
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Engage -- Messages")]
    public partial class Engage_MessagesFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Message.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Engage -- Messages", "    As an Engage user\n    I want Message functionality\n    So that people can send me private messages and vice versa", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void FeatureBackground()
        {
#line 7
    #line 8
     testRunner.Given("I log in with valid credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
     testRunner.And("I click the \"Messages\" side panel button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify a user can't @mention himself in the message")]
        public virtual void VerifyAUserCanTMentionHimselfInTheMessage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify a user can't @mention himself in the message", ((string[])(null)));
#line 11
    this.ScenarioSetup(scenarioInfo);
#line 7
    this.FeatureBackground();
#line 13
     testRunner.Given("I click on Add new message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 14
        testRunner.When("I do a @mention in message for myself", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
        testRunner.Then("search result should be empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify generation of a new message")]
        [NUnit.Framework.TestCaseAttribute("this is a private message", "a minute ago", new string[0])]
        public virtual void VerifyGenerationOfANewMessage(string messageText, string messageAfterTime, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify generation of a new message", exampleTags);
#line 17
    this.ScenarioSetup(scenarioInfo);
#line 7
    this.FeatureBackground();
#line 19
     testRunner.Given("I click on Add new message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 20
  testRunner.When("I do a @mention in message for another user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
        testRunner.When(string.Format("I write {0} in the message body", messageText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
        testRunner.And("I click the Submit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
        testRunner.Then(string.Format("I verify message body to contain {0} and last updated Time to be {1}", messageText, messageAfterTime), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify generation of reply on new message")]
        [NUnit.Framework.TestCaseAttribute("New Message expecting reply", "Replying to your message", new string[0])]
        public virtual void VerifyGenerationOfReplyOnNewMessage(string messageText, string replyText, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify generation of reply on new message", exampleTags);
#line 30
   this.ScenarioSetup(scenarioInfo);
#line 7
    this.FeatureBackground();
#line 32
    testRunner.Given("I click on Add new message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 33
  testRunner.When("I do a @mention in message for another user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
        testRunner.When(string.Format("I write {0} in the message body", messageText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
        testRunner.And("I click the Submit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
  testRunner.And("I click the latest message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
        testRunner.When(string.Format("I add reply {0}", replyText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
        testRunner.And("I click on \"Post\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
        testRunner.Then(string.Format("I verify that {0} appears on the message trail", replyText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 40
        testRunner.And("number of replies text updated to \"1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
