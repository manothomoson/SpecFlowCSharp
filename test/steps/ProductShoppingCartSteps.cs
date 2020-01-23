using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace ConductorTest
{
    [Binding]
    public class ProductShoppingCartSteps
    {
        private readonly ProductShoppingCartPage Page;

        public ProductShoppingCartSteps(IWebDriver driver)
        {
            this.Page = new ProductShoppingCartPage(driver);

        }

        [Then(@"Validate cart summary section")]
        public void ThenValidateCartSummarySection()
        {
            Page.ValidateCartSummarySection();
        }

        [Then(@"Validate product details from cart section")]
        public void ThenValidateProductDetailsFromCartSection()
        {
            Page.ValidateProductDetailsFromCartSection();
        }

        [Then(@"Validate estimated Delivery and Cost section")]
        public void ThenValidateEstimatedDeliveryAndCostSection()
        {
            Page.ValidateEstimatedDeliveryAndCostSection();
        }

        [When(@"Add General Ledger code to the product")]
        public void WhenAddGeneralLedgerCodeToTheProduct()
        {
            Page.AddGeneralLedgerCodeToTheProduct();
        }

        [When(@"Add Product NickName (.*) to the product")]
        public void WhenAddProductNickNameTestNickNameToTheProduct(string productNickName)
        {
            Page.AddProductNickName(productNickName);
        }

        [Then(@"Navigate from Shopping cart page to Payment page")]
        public void ThenNavigateFromShoppingCartPageToPaymentPage()
        {
            Page.NavigateFromCartPageToPaymentPage();
        }

        [When(@"Edit product from the shopping cart page")]
        public void WhenEditProductFromTheShoppingCartPage()
        {
            Page.EditProductFromCart();
        }

        [When(@"Update Delivery Options page details for (.*)")]
        public void WhenUpdateDeliveryOptionsPageDetailsForShipToAnAddress(string ShipType)
        {
            Page.UpdateDeliveryOptionsPageDetails(ShipType);
        }

        [When(@"Copy product from the shopping cart page")]
        public void WhenCopyProductFromTheShoppingCartPage()
        {
            Page.CopyProductFromTheShoppingCartPage();
        }

        [Then(@"Validate cart items after copy the product")]
        public void ThenValidateCartItemsAfterCopyProduct()
        {
            Page.ValidateCartItemsAfterCopyProduct();
        }

        [When(@"Get current item count from cart")]
        public void WhenGetCurrentItemCountFromCart()
        {
            Page.GetCurrentItemCountFromCart();
        }

        [Then(@"Validate cart count after edit product")]
        public void ThenValidateCartCountAfterEditProduct()
        {
            Page.ValidateCartCountAfterEditProduct();
        }

        [When(@"Save for Later product from the shopping cart page")]
        public void WhenSaveForLaterProductFromTheShoppingCartPage()
        {
            Page.SaveForLaterProductFrmCart();
        }

        [Then(@"Validate copy, remove, add to cart button of Save Later section")]
        public void ThenValidateCopyRemoveAddToCartButtonOfSaveLaterSection()
        {
            Page.ValidateCopyRemoveAddToCartButton();
        }

        [Then(@"Validate cart count after Save a product for Later")]
        public void ThenValidateCartCountAfterSaveAProductForLater()
        {
           Page.ValidateCartCountAfterSaveAProductForLater();
        }

        [When(@"Remove the product from the cart")]
        public void WhenRemoveTheProductFromTheCart()
        {
            Page.RemoveTheProductFromTheCart();
        }

        [Then(@"Validate cart count after removing a product")]
        public void ThenValidateCartCountAfterRemovingAProduct()
        {
            Page.ValidateCartCountAfterRemovingAProduct();
        }

        [When(@"Remove existing items from shopping cart")]
        public void WhenRemoveExistingItemsFromShoppingCart()
        {
            Page.RemoveExistingItemsFromShoppingCart();
        }


    }
}
