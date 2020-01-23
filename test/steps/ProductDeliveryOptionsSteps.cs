using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace ConductorTest
{
    [Binding]
    public class ProductDeliveryOptionsSteps
    {
        private readonly ProductDeliveryOptionsPage Page;

        public ProductDeliveryOptionsSteps(IWebDriver driver)
        {
            this.Page = new ProductDeliveryOptionsPage(driver);
        }

        [When(@"Fill Delivery Options page details for (.*)")]
        public void WhenFillDeliveryOptionsPageDetails(string shipType)
        {
            Page.FillDeliveryOptionsDetails(shipType);
        }

        [Then(@"Navigate from Delivery Options page to Shopping cart page")]
        public void ThenNavigateFromDeliveryOptionsPageToShoppingCartPage()
        {
            Page.ContinueFromDeliveryOptions();
        }


    }
}
