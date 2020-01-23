using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace ConductorTest
{
    [Binding]
    public class ProductCreationSteps
    {
        private readonly ProductCreationPage Page;

        public ProductCreationSteps(IWebDriver driver)
        {
            this.Page = new ProductCreationPage(driver);
        }

        [When(@"Navigate to Administration menu")]
        public void WhenNavigateToAdministrationMenu()
        {
            Page.NavigateToAdministration();
        }

        [Then(@"Navigate to (.*) from Admin page")]
        public void ThenNavigateToAddEditProductsFromAdminPage(string menuType)
        {
           Page.NavigateToSubMenu(menuType);
        }

        [When(@"Add product for type (.*)")]
        public void WhenAddProductForTypePrint(string prodType)
        {
            Page.AddProductFromProductsPage(prodType);
        }

        [When(@"Fill General details for (.*) product")]
        public void WhenFillGeneralDetailsForProduct(string prodType)
        {
            Page.FillGeneralProductsDetails(prodType);
        }

        [When(@"Navigate to Images tab")]
        public void WhenNavigateToImagesTabAndUploadImagesForProduct()
        {
            Page.NavigateToImages();
        }

        [Then(@"Upload image for (.*)")]
        public void ThenUploadImageForCatagory(string imageCatagory)
        {
            Page.UploadImageForCatagory(imageCatagory);
        }

        [When(@"Navigate to Visibility tab")]
        public void WhenNavigateToVisibilityTab()
        {
            Page.NavigateToVisibility();
        }

        [Then(@"Set visiblity for product and compaign catalog")]
        public void ThenSetVisiblityForProductAndCompaignCatalog()
        {
            Page.SetVisibilityProductAndCompaign();
        }

        [Then(@"Fill visiblity details for (.*) product")]
        public void WhenSelectProductCatagoriesAsPrint(string productCatagory)
        {
            Page.SelectProductCatogory(productCatagory);
        }

        [When(@"Navigate to Pricing and Delivery tab")]
        public void WhenNavigateToPricingAndDeliveryTab()
        {
            Page.NavigateToPricingAndDeliveryTab(); 
        }

        [Then(@"Fill Pricing and Delivery details for (.*) product")]
        public void ThenFillPricingAndDeliveryDetailsForPrintProduct(string prodType)
        {
            Page.FillDetailsForPricingAndDelivery(prodType);
        }

        [When(@"Navigate to Customization tab")]
        public void WhenNavigateToCustomizationTab()
        {
            Page.NavigateToCustomizationTab();
        }

        [Then(@"Fill Customization tab fields for (.*) product")]
        public void ThenFillCustomizationTabFieldsForPrintProduct(string prodType)
        {
            Page.FillDetailsForCustmization(prodType);
        }

        [Then(@"Save and publish now the product")]
        public void ThenSaveAndPublishNowTheProduct()
        {
            Page.SaveAndPublishNowProduct();
        }

        [When(@"Navigate to SOLR for index")]
        public void WhenNavigateToSOLRForIndex()
        {
            Page.NavigateToSOLRForIndex();
        }

        [Then(@"Refresh the product (.*) for (.*)")]
        public void ThenRefreshTheProductCreatedProductForCurrentUser(string productName, string User)
        {
            Page.RefreshProductsSOLR(productName, User);
        }




    }
}
