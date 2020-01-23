using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace ConductorTest
{
    [Binding]
    public class ProductOrderConfirmationSteps
    {
        private readonly ProductOrderConfirmationPage Page;

        public ProductOrderConfirmationSteps(IWebDriver driver)
        {
            this.Page = new ProductOrderConfirmationPage(driver);

        }

        [When(@"Navigate from order confirmation page to Order details page")]
        public void WhenNavigateFromOrderConfirmationPageToOrderDetailsPage()
        {
            Page.NavigateToOrderDetailsPage();
        }

        [Then(@"Validate Order number link, thankyou message and disclaimer")]
        public void ThenValidateOrderNumberLinkThankyouMessageAndDisclaimer()
        {
            Page.ValidateOrderNumberLinkAndOtherElements();
        }

        [Then(@"Validate Order detail page elements from product section")]
        public void ThenValidateOrderDetailPageElementsFromProductSection()
        {
            Page.ValidateOrderDetailPageElements();
        }

        [Then(@"Validate the order details from order summary panel")]
        public void ThenValidateTheOrderDetailsFromOrderSummaryPanel()
        {
            Page.ValidateOrderSummaryPanel();
        }

        [Then(@"Validate Estimated delivery and its elements")]
        public void ThenValidateEstimatedDeliveryAndItsElements()
        {
            Page.ValidateEstimatedDelivery();
        }

        [Then(@"Validate payment breakdown modal under Estd delivery and Cost")]
        public void ThenValidatePaymentBreakdownModalUnderEstdDeliveryAndCost()
        {
            Page.ValidatePaymentBreakdownModal();
        }

        [Then(@"Cancel Delivery for estimated section")]
        public void ThenCancelDeliveryForEstimatedSection()
        {

            Page.CancelDelivery();
        }



    }
}
