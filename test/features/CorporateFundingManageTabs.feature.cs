// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace ConductorPOC.Test.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Storefront: Corporate Funding", SourceFile="test\\features\\CorporateFundingManageTabs.feature", SourceLine=6)]
    public partial class StorefrontCorporateFundingFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CorporateFundingManageTabs.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Storefront: Corporate Funding", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Corporate Funding - Check the new tabs", new string[] {
                "SmokeTest"}, SourceLine=9)]
        public virtual void CorporateFunding_CheckTheNewTabs()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Corporate Funding - Check the new tabs", null, new string[] {
                        "SmokeTest"});
#line 10
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 11
 testRunner.Given("I have launched the KLIC test site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 12
 testRunner.When("I have logged in with FundAdministrator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
  testRunner.When("Navigate to Corporate Funding page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
  testRunner.Then("Validate the new tabs in CoFunding page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Corporate Funding - Validating the default view for Fund Administrator", new string[] {
                "SmokeTest"}, SourceLine=17)]
        public virtual void CorporateFunding_ValidatingTheDefaultViewForFundAdministrator()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Corporate Funding - Validating the default view for Fund Administrator", null, new string[] {
                        "SmokeTest"});
#line 18
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 19
 testRunner.Given("I have launched the KLIC test site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 20
 testRunner.When("I have logged in with FundAdministrator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
  testRunner.When("Navigate to Corporate Funding page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
  testRunner.Then("Validate the new tabs in CoFunding page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Corporate Funding - Validate default view and Total funds Allocated to users", new string[] {
                "SmokeTest"}, SourceLine=33)]
        public virtual void CorporateFunding_ValidateDefaultViewAndTotalFundsAllocatedToUsers()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Corporate Funding - Validate default view and Total funds Allocated to users", null, new string[] {
                        "SmokeTest"});
#line 34
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 35
 testRunner.Given("I have launched the KLIC test site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 36
 testRunner.When("I have logged in with FundAdministrator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
  testRunner.When("Navigate to Corporate Funding page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
  testRunner.When("Validate MyFunding Account tab as default view for Non Fund Administrator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
  testRunner.When("Navigate to Manage Funding tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
  testRunner.Then("Validate the sections in manage funding tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 43
  testRunner.When("Validate Total funds Allocated to users in CoFunding Balance section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Corporate Funding - Validate Add, reset and transfer fund buttons", new string[] {
                "SmokeTest"}, SourceLine=46)]
        public virtual void CorporateFunding_ValidateAddResetAndTransferFundButtons()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Corporate Funding - Validate Add, reset and transfer fund buttons", null, new string[] {
                        "SmokeTest"});
#line 47
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 48
 testRunner.Given("I have launched the KLIC test site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 49
 testRunner.When("I have logged in with AdminUser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
  testRunner.When("Navigate to Corporate Funding page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
  testRunner.When("Navigate to Manage Funding tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 52
  testRunner.Then("Validate AddMoreFund, ResetFund and TransferFund buttons", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Manage Funding tab - Check Search feature in Manage Individual Funding Account", new string[] {
                "SmokeTest"}, SourceLine=56)]
        public virtual void ManageFundingTab_CheckSearchFeatureInManageIndividualFundingAccount()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Manage Funding tab - Check Search feature in Manage Individual Funding Account", null, new string[] {
                        "SmokeTest"});
#line 57
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 58
 testRunner.Given("I have launched the KLIC test site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 59
 testRunner.When("I have logged in with FundAdministrator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
  testRunner.When("Navigate to Corporate Funding page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 61
  testRunner.When("Navigate to Manage Funding tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 62
  testRunner.Then("Validate Name search field and label", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 63
  testRunner.When("Assert column names and tooltips in manage individual funding table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 64
  testRunner.Then("Search for a name Mano in manage individual funding accounts", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 65
  testRunner.Then("Assert search results matching for Mano", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Manage Funding tab - Check Indicator for User Activity in search result table", new string[] {
                "SmokeTest"}, SourceLine=67)]
        public virtual void ManageFundingTab_CheckIndicatorForUserActivityInSearchResultTable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Manage Funding tab - Check Indicator for User Activity in search result table", null, new string[] {
                        "SmokeTest"});
#line 68
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 69
 testRunner.Given("I have launched the KLIC test site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 70
 testRunner.When("I have logged in with FundAdministrator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 71
  testRunner.When("Navigate to Corporate Funding page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 72
  testRunner.When("Navigate to Manage Funding tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 73
  testRunner.Then("Validate Name search field and label", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 74
  testRunner.When("Assert column names and tooltips in manage individual funding table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 75
  testRunner.Then("Validate Username AvailableBalance and CurrentBalance columns and hovers", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 76
  testRunner.Then("Search for a name Mano in manage individual funding accounts", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 77
  testRunner.When("Check indicator column for activity of the each user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 78
  testRunner.When("Click on the indicator and drilldown to first record of the table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 79
  testRunner.Then("Validate the row expaned in light blue and its row details wih dark blue border", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 80
  testRunner.Then("Validate the Indicator table columns for user activity", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Manage Funding tab - Check Add action and add balance to user", new string[] {
                "SmokeTest"}, SourceLine=82)]
        public virtual void ManageFundingTab_CheckAddActionAndAddBalanceToUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Manage Funding tab - Check Add action and add balance to user", null, new string[] {
                        "SmokeTest"});
#line 83
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 84
 testRunner.Given("I have launched the KLIC test site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 85
 testRunner.When("I have logged in with FundAdministrator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 86
  testRunner.When("Navigate to Corporate Funding page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 87
  testRunner.When("Navigate to Manage Funding tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 88
  testRunner.Then("Validate Name search field and label", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 89
  testRunner.Then("Search for a name Mano Thomson in manage individual funding accounts", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 90
  testRunner.Then("Validate Add and Reset links available", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 91
  testRunner.When("Add balance 10 to first user record and assert", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Manage Funding tab - Check Reset action and reset balance to user", new string[] {
                "SmokeTest"}, SourceLine=94)]
        public virtual void ManageFundingTab_CheckResetActionAndResetBalanceToUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Manage Funding tab - Check Reset action and reset balance to user", null, new string[] {
                        "SmokeTest"});
#line 95
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 96
 testRunner.Given("I have launched the KLIC test site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 97
 testRunner.When("I have logged in with FundAdministrator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 98
  testRunner.When("Navigate to Corporate Funding page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 99
  testRunner.When("Navigate to Manage Funding tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 100
  testRunner.Then("Validate Name search field and label", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 101
  testRunner.Then("Search for a name Mano Thomson in manage individual funding accounts", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 102
  testRunner.Then("Validate Add and Reset links available", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 103
  testRunner.When("Reset balance 5 to first user record and assert", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion