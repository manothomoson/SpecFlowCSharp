using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace ConductorTest
{
    [Binding]
    public class ProductCustomizationSteps
    {
        private readonly ProductCustomizationPage Page;

        public ProductCustomizationSteps(IWebDriver driver)
        {
            this.Page = new ProductCustomizationPage(driver);
        }

        [When(@"Navigate to the first product")]
        public void WhenNavigateToTheFirstProduct()
        {
            Page.NavigateToFirstProduct();
        }
        [Then(@"Navigate from Produt details page to product Customization page")]
        public void ThenNavigateFromProdutDetailsPageToProductCustomizationPage()
        {
            Page.NavigateToProductCustomizationPage();
        }
        [When(@"Fill product customization fields for (.*)")]
        public void WhenFillProductCustomizationFields(string productType)
        {
            Page.FillProductCustomizationFields(productType);
        }

        [Then(@"Preview and approve from customization")]
        public void ThenPreviewAndApproveFromCustomization()
        {
            Page.PreviewAndApproveFromCustomization();
        }


    }
}
