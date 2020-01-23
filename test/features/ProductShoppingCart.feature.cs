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
    [TechTalk.SpecRun.FeatureAttribute("StoreFront - Product Shopping Cart", SourceFile="test\\features\\ProductShoppingCart.feature", SourceLine=6)]
    public partial class StoreFront_ProductShoppingCartFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ProductShoppingCart.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "StoreFront - Product Shopping Cart", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [TechTalk.SpecRun.ScenarioAttribute("Order Workflow -  Product Shopping Cart", new string[] {
                "SmokeTest"}, SourceLine=9)]
        public virtual void OrderWorkflow_ProductShoppingCart()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Order Workflow -  Product Shopping Cart", null, new string[] {
                        "SmokeTest"});
#line 10
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
 testRunner.Given("I have launched the KLIC test site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 13
 testRunner.When("I have logged in with AdminUser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
  testRunner.When("Remove existing items from shopping cart", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.When("navigate to products menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.Then("search the product testAuto3333", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
  testRunner.When("Navigate to the product testAuto3333", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
  testRunner.Then("Navigate from Produt details page to product Customization page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
  testRunner.When("Fill Delivery Options page details for ShipToAnAddress", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
  testRunner.Then("Navigate from Delivery Options page to Shopping cart page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
  testRunner.Then("Validate cart summary section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 24
  testRunner.Then("Validate product details from cart section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
  testRunner.Then("Validate estimated Delivery and Cost section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 26
  testRunner.When("Add General Ledger code to the product", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
  testRunner.When("Add Product NickName TestNickName to the product", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
  testRunner.Then("Navigate from Shopping cart page to Payment page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 29
 testRunner.Then("signout the application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Order Workflow -  Product Shopping Cart (Edit Button)", new string[] {
                "SmokeTest"}, SourceLine=31)]
        public virtual void OrderWorkflow_ProductShoppingCartEditButton()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Order Workflow -  Product Shopping Cart (Edit Button)", null, new string[] {
                        "SmokeTest"});
#line 32
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 34
 testRunner.Given("I have launched the KLIC test site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 35
 testRunner.When("I have logged in with AdminUser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
  testRunner.When("Remove existing items from shopping cart", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.When("navigate to products menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
 testRunner.Then("search the product testAuto3333", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 39
  testRunner.When("Navigate to the product testAuto3333", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
  testRunner.Then("Navigate from Produt details page to product Customization page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 43
  testRunner.When("Fill Delivery Options page details for ShipToAnAddress", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
  testRunner.Then("Navigate from Delivery Options page to Shopping cart page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 45
  testRunner.When("Get current item count from cart", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
  testRunner.When("Edit product from the shopping cart page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 47
  testRunner.Then("Navigate from Produt details page to product Customization page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 48
  testRunner.When("Update Delivery Options page details for MailToRecipientList", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 49
  testRunner.Then("Navigate from Delivery Options page to Shopping cart page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 50
  testRunner.Then("Validate cart summary section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 51
  testRunner.Then("Validate product details from cart section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 52
  testRunner.Then("Validate cart count after edit product", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Order Workflow -  Product Shopping Cart (Copy Button)", new string[] {
                "SmokeTest"}, SourceLine=54)]
        public virtual void OrderWorkflow_ProductShoppingCartCopyButton()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Order Workflow -  Product Shopping Cart (Copy Button)", null, new string[] {
                        "SmokeTest"});
#line 55
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 57
 testRunner.Given("I have launched the KLIC test site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 58
 testRunner.When("I have logged in with AdminUser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 59
  testRunner.When("Remove existing items from shopping cart", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
 testRunner.When("navigate to products menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 61
 testRunner.Then("search the product testAuto3333", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 62
  testRunner.When("Navigate to the product testAuto3333", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 63
  testRunner.Then("Navigate from Produt details page to product Customization page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 66
  testRunner.When("Fill Delivery Options page details for ShipToAnAddress", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 67
  testRunner.Then("Navigate from Delivery Options page to Shopping cart page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 68
  testRunner.When("Get current item count from cart", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 69
  testRunner.Then("Validate cart summary section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 70
  testRunner.When("Copy product from the shopping cart page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 71
  testRunner.Then("Navigate from Produt details page to product Customization page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 72
  testRunner.When("Update Delivery Options page details for ShipToAnAddress", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 73
  testRunner.Then("Navigate from Delivery Options page to Shopping cart page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 74
  testRunner.Then("Validate cart summary section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 75
  testRunner.Then("Validate product details from cart section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 76
  testRunner.Then("Validate cart items after copy the product", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Order Workflow -  Product Shopping Cart (Save for Later Button)", new string[] {
                "SmokeTest"}, SourceLine=78)]
        public virtual void OrderWorkflow_ProductShoppingCartSaveForLaterButton()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Order Workflow -  Product Shopping Cart (Save for Later Button)", null, new string[] {
                        "SmokeTest"});
#line 79
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 81
 testRunner.Given("I have launched the KLIC test site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 82
 testRunner.When("I have logged in with AdminUser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 83
  testRunner.When("Remove existing items from shopping cart", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 84
 testRunner.When("navigate to products menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 85
 testRunner.Then("search the product testAuto3333", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 86
  testRunner.When("Navigate to the product testAuto3333", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 87
  testRunner.Then("Navigate from Produt details page to product Customization page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 90
  testRunner.When("Fill Delivery Options page details for ShipToAnAddress", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 91
  testRunner.Then("Navigate from Delivery Options page to Shopping cart page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 92
  testRunner.Then("Validate cart summary section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 93
  testRunner.When("Get current item count from cart", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 94
  testRunner.When("Save for Later product from the shopping cart page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 95
  testRunner.Then("Validate copy, remove, add to cart button of Save Later section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 96
  testRunner.Then("Validate cart count after Save a product for Later", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Order Workflow -  Product Shopping Cart (Remove Button)", new string[] {
                "SmokeTest"}, SourceLine=98)]
        public virtual void OrderWorkflow_ProductShoppingCartRemoveButton()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Order Workflow -  Product Shopping Cart (Remove Button)", null, new string[] {
                        "SmokeTest"});
#line 99
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 101
 testRunner.Given("I have launched the KLIC test site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 102
 testRunner.When("I have logged in with AdminUser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 103
  testRunner.When("Remove existing items from shopping cart", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 104
 testRunner.When("navigate to products menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 105
 testRunner.Then("search the product testAuto3333", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 106
  testRunner.When("Navigate to the product testAuto3333", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 107
  testRunner.Then("Navigate from Produt details page to product Customization page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 110
  testRunner.When("Fill Delivery Options page details for ShipToAnAddress", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 111
  testRunner.Then("Navigate from Delivery Options page to Shopping cart page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 112
  testRunner.Then("Validate cart summary section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 113
  testRunner.When("Get current item count from cart", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 114
  testRunner.When("Remove the product from the cart", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 115
  testRunner.Then("Validate cart count after removing a product", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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