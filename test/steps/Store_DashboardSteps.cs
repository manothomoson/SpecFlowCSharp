using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace ConductorTest
{
    [Binding]
    public class SF_DashboardSteps
    {
        private readonly SF_DashboardPage Page;

        public SF_DashboardSteps(IWebDriver driver)
        {
            this.Page = new SF_DashboardPage(driver);
        }

        [Given(@"I have launched the KLIC test site")]
        public void LaunchConductorSite()
        {
            Page.LaunchConductorSite();
        }

        [When(@"I have logged in with (.*)")]
        public void LogginValidUser(string userType)
        {
            Page.Login(userType);
        }

        [When(@"assert KLIC logo on upper left corner of the page")]
        public void AssertLogo()
        {
            Page.AssertLogo();
        }

        [Then(@"assert upper right for shoppingCart, CoFund, Profile icons")]
        public void AssertIcons()
        {
            Page.AssertIcons();
        }

        [Then(@"signout the application")]
        public void Signout()
        {
            Page.Signout();
        }
        
        [When(@"navigate to products menu")]
        public void NavigateToProducts()
        {
            Page.NavigateToProducts();
        }

        [Then(@"search the product (.*)")]
        public void ThenSearchTheProduct(string productName)
        {
            Page.SearchProduct(productName);
        }

        [When(@"assert the main menu widgets and product search form")]
        public void AssertMainMenuWidgets()
        {
            Page.AssertMainMenuWidgets();
        }
        [When(@"assert home page layer")]
        public void AssertHomePageLayer()
        {
            Page.AssertHomePageLayer();
        }
        [When(@"assert the footer sections")]
        public void AssertFooterSections()
        {
            Page.AssertFooterSections();
        }
        [When(@"assert MyTools footer section links")]
        public void AssertMyToolsFooterSections()
        {
            Page.AssertMyToolsFooterSections();
        }

        [When(@"assert Products footer section links")]
        public void AssertProductsFooterSections()
        {
            Page.AssertProductsFooterSections();
        }
        [When(@"assert Compaigns footer section links")]
        public void AssertCompaignsFooterSections()
        {
            Page.AssertCompaignsFooterSections();
        }
                
        [When(@"assert Contacts footer section links")]
        public void AssertContactsFooterSections()
        {
            Page.AssertContactsFooterSections();
        }
        

    }
}
