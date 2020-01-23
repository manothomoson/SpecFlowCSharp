using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace ConductorTest
{
    [Binding]
    public class ProductCatalogSteps
    {
        private readonly ProductCatalogPage Page;

        public ProductCatalogSteps(IWebDriver driver)
        {
            this.Page = new ProductCatalogPage(driver);
        }
               
        [Then(@"Check Filter By catagories")]
        public void CheckFilterByCatagories()
        {
            Page.CheckFilterByCatagories();
        }

        [When(@"Select the filter from catagory (.*)")]
        public void WhenSelectTheFilterFromCatagory(string filterCatagory)
        {
            Page.SelectFilterByCatagory(filterCatagory);
        }

        [When(@"Sort the products by (.*)")]
        public void WhenSortTheProductsBy(string sortProdctBy)
        {
            Page.SelectSortByCatagory(sortProdctBy); 
        }

        [Then(@"Assert the products sorted in (.*)")]
        public void ThenAssertTheProductsSortedInPriceHigh_Low(string sortProdctBy)
        {
            Page.AssertSortedProducts(sortProdctBy);
        }

        [When(@"Validate Grid view and List view icons")]
        public void WhenValidateGridViewAndListViewIcons()
        {
            Page.ValidateGridListView();
        }

        [When(@"Navigate to the product (.*)")]
        public void WhenNavigateToTheProduct(string productName)
        {
            Page.NavigateToProduct(productName);
        }

        [Then(@"Assert product details thumbnail, name, SKU, delivery methods and Price")]
        public void ThenAssertProductDetailsThumbnailNameSKUDeliveryMethodsAndPrice()
        {
            Page.AssertProductDetails();
        }

    }
}
