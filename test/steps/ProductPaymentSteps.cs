using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace ConductorTest
{
    [Binding]
    public class ProductPaymentSteps
    {
        private readonly ProductPaymentPage Page;

        public ProductPaymentSteps(IWebDriver driver)
        {
            this.Page = new ProductPaymentPage(driver);

        }
        [Then(@"Validate payment methods available")]
        public void ThenValidatePaymentMethodsAvailable()
        {
           Page.ValidatePaymentMethodsAvailable();
        }

        [Then(@"Validate payment summary section")]
        public void ThenValidatePaymentSummarySection()
        {
           Page.ValidatePaymentSummarySection();
        }

        [Then(@"Validate payment breakdown for (.*) from summary")]
        public void ThenValidatePaymentBreakdownForCreditcardFromSummary(string paymentType)
        {
            Page.ValidatePaymentBreakdown(paymentType);
        }

        [When(@"check Terms of Use check box before placing order")]
        public void WhenCheckTermsOfUseCheckBoxBeforePlacingOrder()
        {
            Page.CheckTermsOfUseCheckBox();
        }

        [Then(@"Place the order from payment page")]
        public void ThenPlaceTheOrderFromPaymentPage()
        {
            Page.PlaceTheOrderFromPaymentPage();
        }

        [When(@"Fill one time payment Credit card details for payment")]
        public void WhenFillOneTimePaymentCreditCardDetailsForPayment()
        {
            Page.FillOneTimePaymentCreditCardDetails();
        }

        [When(@"Fill billing information new Address")]
        public void WhenFillBillingInformationNewAddress()
        {
            Page.FillBillingInformationNewAddress();
        }

        [Then(@"Validate security code message hint")]
        public void ThenValidateSecurityCodeMessageHint()
        {
            Page.ValidateSecurityCodeMessageHint();
        }

        [Then(@"Validate Payment profile message hint")]
        public void ThenValidatePaymentProfileMessageHint()
        {
            Page.ValidatePaymentProfileMessageHint();
        }
        [When(@"Fill existing Credit card details for payment")]
        public void WhenFillExistingCreditCardDetailsForPayment()
        {
            Page.FillExistingCreditCardDetails();
        }

        [When(@"Fill billing information exisiting Address")]
        public void WhenFillBillingInformationExisitingAddress()
        {
            Page.FillBillingInformationExisitingAddress();
        }

        [When(@"Navigate to Invoice payment method")]
        public void WhenNavigateToInvoicePaymentMethod()
        {
            Page.NavigateToInvoicePaymentMethod();
        }

        [Then(@"Validate Invoice amount to be paid")]
        public void ThenValidateInvoiceAmountToBePaid()
        {
            Page.ValidateInvoiceAmountToBePaid();
        }

        [When(@"Navigate to Cofunding payment method")]
        public void WhenNavigateToCofundingPaymentMethod()
        {
            Page.NavigateToCofundingPaymentMethod();
        }

        [Then(@"Validate Cofunding amount to be paid")]
        public void ThenValidateCofundingAmountToBePaid()
        {
            Page.ValidateCofundingAmountToBePaid();
        }

        [When(@"Navigate to CofundingAndCreditCard payment method")]
        public void WhenNavigateToCofundingAndCreditCardPaymentMethod()
        {
            Page.NavigateToCofundingAndCreditCardPaymentMethod();
        }

        [When(@"Fill Cofunding amount with credit card payment")]
        public void WhenFillCofundingAmountWithCreditCardPayment()
        {
            Page.FillCofundingAmountWithCCPayment();
        }

        [When(@"Fill Cofunding amount with Invoice payment")]
        public void WhenFillCofundingAmountWithInvoicePayment()
        {
            Page.FillCofundingAmountWithCCPayment();
        }

        [When(@"Navigate to CofundingAndInvoice payment method")]
        public void WhenNavigateToCofundingAndInvoicePaymentMethod()
        {
            Page.NavigateToCofundingAndInvoicePaymentMethod();
        }

    }
}
