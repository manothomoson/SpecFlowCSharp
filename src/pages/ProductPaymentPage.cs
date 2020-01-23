using ConductorTest.src.pages;
using ConductorTest.test.support;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading;

namespace ConductorTest
{

    class ProductPaymentPage : Page
    {
        IWebDriver driver;
        public static dynamic jsonObj;
        //ProductDeliveryOptionsPage deliveryOptionsPage;
        //public static int itemCountFromCart;
        public ProductPaymentPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            jsonObj = getJson();
            //this.deliveryOptionsPage = new ProductDeliveryOptionsPage(driver);
        }

        //Page title
        public IWebElement PaymentPageTitle => driver.FindElement(By.XPath("//h1[text()='Payment']"));

        public IWebElement ShoppingCartTitle => driver.FindElement(By.XPath("//h1[text()='Shopping Cart']"));
        public IWebElement ProductDetailsTitle => driver.FindElement(By.XPath("//h1[contains(text(),'Product Details')]"));

        //Payment Method Links
        public IWebElement CreditCardLink => driver.FindElement(By.Id("creditCard"));
        public IWebElement InvoiceLink => driver.FindElement(By.Id("invoice"));
        public IWebElement CofundingLink => driver.FindElement(By.Id("cofund"));
        public IWebElement CofundAndCreditCardLink => driver.FindElement(By.Id("cofundCreditCard"));
        public IWebElement CofundAndInvoiceLink => driver.FindElement(By.Id("cofundInvoice"));

        //Payment Summary section
        public IWebElement SubTotalInPaymentSummary => driver.FindElement(By.XPath("//div[@id='summary-wrap']//div[contains(text(),'Subtotal:')]/following-sibling::div"));
        public IWebElement TaxesInPaymentSummary => driver.FindElement(By.XPath("//div[@id='summary-wrap']//div[contains(text(),'Taxes:')]"));
        public IWebElement DeliveryInPaymentSummary => driver.FindElement(By.XPath("//div[@id='summary-wrap']//div[contains(text(),'Delivery:')]"));
        public IWebElement TotalCartInPaymentSummary => driver.FindElement(By.XPath("//div[@id='summary-wrap']//div[contains(text(),'Total:')]/following-sibling::div"));

        public IWebElement TermsOfUseCheckBox => driver.FindElement(By.Id("termsCheckbox"));
        public IWebElement PlaceOrderBtn => driver.FindElement(By.Id("placeOrderButton"));


        // Credit card payment

        public IWebElement CreditCrdBalanceToBePaid => driver.FindElement(By.Id("ccPaymentAmount"));
        public IWebElement CreditCardTypeDrpdwn => driver.FindElement(By.Id("creditCardType"));
        public IWebElement VisaRadioBtn => driver.FindElement(By.Id("visa"));
        public IWebElement MasterCardRadioBtn => driver.FindElement(By.Id("mastercard"));
        public IWebElement NameOnCardTxt => driver.FindElement(By.Id("cardName"));
        public IWebElement CardNumberTxt => driver.FindElement(By.Id("cardNumber"));
        public IWebElement CardExpiryDateTxt => driver.FindElement(By.Id("expDate"));
        public IWebElement CardSecurityCodeTxt => driver.FindElement(By.Id("securityCodeOneTime"));
        public IWebElement CardSecurityCodeSavedTxt => driver.FindElement(By.Id("securityCodeSaved"));
        
        public IWebElement SaveToPaymentProfile => driver.FindElement(By.Name("SaveToPaymentProfile"));
        public IWebElement BillingInfoAddressDrpdwn => driver.FindElement(By.Id("addressSelect"));
        public IWebElement SecurityCodeMessageHint => driver.FindElement(By.XPath("//div[@class='oneTimePayment' or @class='form-group savedCreditCard']//span[@data-original-title='The last 3 digits at the back of your credit card.']"));
        public IWebElement PaymentProfileMessageHint => driver.FindElement(By.XPath("//span[@data-original-title='This order contains multiple delivery dates and credit card must be saved to profile.']"));


        //Billing Info New Address

        public IWebElement Address1Txt => driver.FindElement(By.Id("addressLine1"));
        public IWebElement Address2Txt => driver.FindElement(By.Id("addressLine2"));
        public IWebElement CityTxt => driver.FindElement(By.Id("City"));
        public IWebElement StateDrpdwn => driver.FindElement(By.Id("state"));
        public IWebElement CountryDrpdwn => driver.FindElement(By.Id("country"));
        public IWebElement ZipTxt => driver.FindElement(By.Id("PostalCode"));
        public IWebElement SaveToAddressProfile => driver.FindElement(By.Name("SaveToProfile"));
        

        //Invoice Payment

        public IWebElement InvoiceBalanceToBePaid => driver.FindElement(By.Id("invoicePaymentAmount"));

        //Co funding
        public IWebElement CofundingBalanceToBePaid => driver.FindElement(By.XPath("//div[@id='balancePaidCofund']/span"));
        public IWebElement AccountCoFundingDrpdwn => driver.FindElement(By.Id("cofundAccountPartial"));

        //Co funding + CC
        public IWebElement CofundAmountTxt => driver.FindElement(By.Id("cofundAmount"));
        public IWebElement AccountCoFunding_CreditCardDrpdwn => driver.FindElement(By.Id("cofundAccount"));

        //Co funding + Invoice

        public IWebElement ProductSummaryTotalPrice => driver.FindElement(By.XPath("//div[contains(@class,'text-right amount')]"));

        public IWebElement SaveAsDraftLink => driver.FindElement(By.XPath("//div[@style='display: block;']//a[contains(@id,'SaveDraft')]"));
        public IWebElement DeleteDeliveryIcon => driver.FindElement(By.XPath("//div[@style='display: block;']//a[contains(@class,'link deleteDeliveryButton')]"));

        public void ValidatePaymentMethodsAvailable()
        {
            Assert.IsTrue(CreditCardLink.Displayed, "CreditCardLink is not displayed");
            Assert.IsTrue(InvoiceLink.Displayed, "InvoiceLink is not displayed");
            Assert.IsTrue(CofundingLink.Displayed, "CofundingLink is not displayed");
            Assert.IsTrue(CofundAndCreditCardLink.Displayed, "CofundAndCreditCardLink is not displayed");
            Assert.IsTrue(CofundAndInvoiceLink.Displayed, "CofundAndInvoiceLink is not displayed");
        }

        public void ValidatePaymentSummarySection()
        {
            Assert.IsTrue(PaymentPageTitle.Displayed, "PaymentPageTitle is not displayed");
            Assert.IsTrue(SubTotalInPaymentSummary.Displayed, "SubTotalPrice is not displayed");
            Assert.IsTrue(TaxesInPaymentSummary.Displayed, "TaxesInPaymentSummary is not displayed");
            Assert.IsTrue(DeliveryInPaymentSummary.Displayed, "DeliveryInPaymentSummary is not displayed");
            Assert.IsTrue(TotalCartInPaymentSummary.Displayed, "TotalInPaymentSummary btn is not displayed");
            Assert.IsTrue(PlaceOrderBtn.Displayed, "PlaceOrderBtn btn is not displayed");
        }

        public void ValidateSecurityCodeMessageHint()
        {
            Assert.IsTrue(SecurityCodeMessageHint.Displayed, "Message hint for security code is not displayed");
        }

        public void ValidatePaymentProfileMessageHint()
        {

            Assert.IsTrue(PaymentProfileMessageHint.Displayed, "Message hint for payment profile is not displayed");
        }
        public void CheckTermsOfUseCheckBox()
        {
            TermsOfUseCheckBox.Click();
            waitForPageLoad();
        }

        public void PlaceTheOrderFromPaymentPage()
        {
            PlaceOrderBtn.Click();
            waitForPageLoad();
        }

        public void NavigateToInvoicePaymentMethod()
        {
            InvoiceLink.Click();
            waitForPageLoad();
        }
        public void NavigateToCofundingPaymentMethod()
        {
            CofundingLink.Click();
            waitForPageLoad();
        }

        public void NavigateToCofundingAndCreditCardPaymentMethod()
        {
            CofundAndCreditCardLink.Click();
            waitForPageLoad();
        }
        public void NavigateToCofundingAndInvoicePaymentMethod()
        {
            CofundAndInvoiceLink.Click();
            waitForPageLoad();
        }
        public void ValidateInvoiceAmountToBePaid()
        {
            Assert.IsTrue(InvoiceBalanceToBePaid.Displayed, "Invoice amount to be paid");
        }

        public void ValidateCofundingAmountToBePaid()
        {
            Assert.IsTrue(CofundingBalanceToBePaid.Displayed, "Invoice amount to be paid");
        }

        public void FillOneTimePaymentCreditCardDetails()
        {
            var PaymentDetailsForCC = jsonObj.SFPaymentMethods.CreditCard;
            Assert.IsTrue(CreditCrdBalanceToBePaid.Displayed, "Balance to be paid is not displayed");
            selectElement(CreditCardTypeDrpdwn, "ByText", PaymentDetailsForCC.PaymentType.ToString());
            waitForPageLoad();
            if ((PaymentDetailsForCC.CardType.ToString()) == "visa")
            {
                VisaRadioBtn.Click();
                waitForPageLoad();
            }
            else { MasterCardRadioBtn.Click(); }
            Thread.Sleep(2000);
            NameOnCardTxt.SendKeys(PaymentDetailsForCC.NameOnCard.ToString());
            CardNumberTxt.SendKeys(PaymentDetailsForCC.CardNumber.ToString());
            CardExpiryDateTxt.SendKeys(PaymentDetailsForCC.ExpiryDate.ToString());
            CardSecurityCodeTxt.SendKeys(PaymentDetailsForCC.SecurityCode.ToString());
            checkFlagAndClick(SaveToPaymentProfile, PaymentDetailsForCC.SaveToPaymentProfile.ToString());
            waitForPageLoad();
        }


        public void FillExistingCreditCardDetails()
        {
            var PaymentDetailsForCC = jsonObj.SFPaymentMethods.ExistingCreditCard;
            selectElement(CreditCardTypeDrpdwn, "ByText", PaymentDetailsForCC.ToString());
            waitForPageLoad();
            CardSecurityCodeSavedTxt.SendKeys("123");
        }

        public void FillCofundingAmountWithCCPayment()
        {
            CofundAmountTxt.SendKeys("1");
        }

        public void FillBillingInformationExisitingAddress()
        {
            var BillingInfoForCC = jsonObj.SFPaymentMethods.ExistingBillingAddress;
            if(BillingInfoForCC.ToString()== "FirstAvailableAddress")
            {
                selectElement(BillingInfoAddressDrpdwn, "ByIndex", "1");
            }
            else
            {
                selectElement(BillingInfoAddressDrpdwn, "ByText", BillingInfoForCC.ToString());
            }            
        }

        public IWebElement CreditCardPaymntBrkup => driver.FindElement(By.Id("ccSidePanel"));
        public IWebElement InvoicePaymntBrkup => driver.FindElement(By.Id("invoiceSidePanel"));
        public IWebElement CofundingPaymntBrkup => driver.FindElement(By.Id("cofundSidePanel"));

        public void ValidatePaymentBreakdown(string paymentType)
        {
            switch (paymentType)
            {
                case "CreditCard":
                    Assert.IsTrue(CreditCardPaymntBrkup.Displayed, "Payment breakup for Credit card is not displayed");                    
                break;
                case "Invoice":
                    Assert.IsTrue(InvoicePaymntBrkup.Displayed, "Payment breakup for Invoice is not displayed");
                    break;
                case "CoFunding":
                    Assert.IsTrue(CofundingPaymntBrkup.Displayed, "Payment breakup for Co funding is not displayed");
                    break;
                case "CoFundingAndCreditCard":
                    Assert.IsTrue(CreditCardPaymntBrkup.Displayed, "Payment breakup for Credit card is not displayed");
                    Assert.IsTrue(CofundingPaymntBrkup.Displayed, "Payment breakup for Co funding is not displayed");
                    break;
                case "CoFundingAndInvoice":
                    Assert.IsTrue(CofundingPaymntBrkup.Displayed, "Payment breakup for Co funding is not displayed");
                    Assert.IsTrue(InvoicePaymntBrkup.Displayed, "Payment breakup for Invoice is not displayed");
                    break;
            }

        }

        public void FillBillingInformationNewAddress()
        {
            var PaymentDetailsBillingInfo = jsonObj.SFPaymentMethods.BillingInformation.NewAddress;
            selectElement(BillingInfoAddressDrpdwn, "ByText", "New Address");
            waitForPageLoad();
            Address1Txt.SendKeys(PaymentDetailsBillingInfo.Address1.ToString());
            Address2Txt.SendKeys(PaymentDetailsBillingInfo.Address2.ToString());
            CityTxt.SendKeys(PaymentDetailsBillingInfo.City.ToString());
            selectElement(StateDrpdwn,"ByText", PaymentDetailsBillingInfo.State.ToString());
            waitForPageLoad();
            ZipTxt.SendKeys(PaymentDetailsBillingInfo.ZIP.ToString());
            selectElement(CountryDrpdwn, "ByText", PaymentDetailsBillingInfo.Country.ToString());
            waitForPageLoad();
            checkFlagAndClick(SaveToAddressProfile, PaymentDetailsBillingInfo.SaveToProfile.ToString());
        }
    }
}

