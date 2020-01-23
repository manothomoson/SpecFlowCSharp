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

    class ProductOrderConfirmationPage : Page
    {
        IWebDriver driver;
        public static dynamic jsonObj;
        //ProductDeliveryOptionsPage deliveryOptionsPage;
        //public static int itemCountFromCart;
        public ProductOrderConfirmationPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            jsonObj = getJson();
            //this.deliveryOptionsPage = new ProductDeliveryOptionsPage(driver);
        }

        //Page title
        public IWebElement OrderConfirmationPageTitle => driver.FindElement(By.XPath("//h1[text()='Order Confirmation']"));
        //Order confirmation Page
        public IWebElement ThankUMsgForOrder => driver.FindElement(By.XPath("//h3[text()='Thank You, your order has been placed.']"));
        public IWebElement OrderPageLink => driver.FindElement(By.XPath("//a[text()='Orders page']"));
        public IWebElement OrderNumberLink => driver.FindElement(By.XPath("//a[contains(@href,'ReviewOrder?orderNumber=')]"));
        public IWebElement DateTimeStampOfOrder => driver.FindElement(By.XPath("//span[@id='orderDate']"));

        //Order Details Page
        
        public IWebElement OrderDetailsPageTitle => driver.FindElement(By.XPath("//h1[text()='Order Details']"));
        public IWebElement CopyOrderBtn => driver.FindElement(By.XPath("//button[@id='Copyorder']"));
        public IWebElement CancelOrderBtn => driver.FindElement(By.XPath("//button[@id='CancelOrderButton']"));
        public IWebElement OrderHistoryBrdCrmb => driver.FindElement(By.XPath("//ul[@class='breadcrumb']//li[contains(text(),'Order')]"));
        public IWebElement ItemsCount => driver.FindElement(By.XPath("//span[text()='Items']"));
        public IWebElement PreviewImage => driver.FindElement(By.XPath("//img[@class='cart-thumb img-responsive']"));
        public IWebElement SKUforProduct => driver.FindElement(By.XPath("//p[@class='sku hidden-sm hidden-xs']"));
        public IWebElement EstimatedDeliveryAndScheduleCost => driver.FindElement(By.Id("ScheduleCost"));
        public IWebElement EstimatedDlvryLink => driver.FindElement(By.XPath("//a[contains(text(),'Estimated Delivery Schedule & Cost')]"));
        public IWebElement ShippingDateInEstdDelivery => driver.FindElement(By.XPath("//strong[text()='SHIPPING DATE']/following-sibling::span[@class='order-details-value']"));
        public IWebElement ShippingIDInEstdDelivery => driver.FindElement(By.XPath("//div[contains(text(),'ID')]//following-sibling::span[@class='order-details-value']"));
        public IWebElement ShippingStatusInEstdDelivery => driver.FindElement(By.XPath("//a[contains(@data-original-title,'Order') or contains(@data-original-title,'order')]"));
        public IWebElement ShippingMethodInEstdDelivery => driver.FindElement(By.XPath("//span[contains(text(),'Shipping Method:')]"));
        public IWebElement ShippingAddressInEstdDelivery => driver.FindElement(By.XPath("//span[contains(text(),'Shipping Address:')]"));
        public IWebElement TrackingInEstdDelivery => driver.FindElement(By.XPath("//span[contains(text(),'Tracking Number:')]"));
        public IWebElement QuantityInEstdDelivery => driver.FindElement(By.XPath("//span[contains(text(),'Quantity:')]"));
        public IWebElement DeliveryCostInEstdDelivery => driver.FindElement(By.XPath("//span[contains(text(),'Delivery Cost:')]"));
        //public IWebElement 
                     
        public IWebElement SendToVendorBtn => driver.FindElement(By.XPath("//button[contains(text(),'Send to Vendor')]"));
        public IWebElement CancelAllFutureDeliveriesLink => driver.FindElement(By.XPath("//a[contains(@href,'cancelAll=True')]"));        
        public IWebElement CancelDeliveryBtn => driver.FindElement(By.XPath("//a[text()='Cancel Delivery']"));
        public IWebElement PaymentBreakdownLink => driver.FindElement(By.XPath("//a[text()='Payment Breakdown']"));
        public IWebElement PaymentMethodInBrkdwnModal => driver.FindElement(By.XPath("//div[@id='paymentBreakdownDialog']//div[@class='clearfix']//span[contains(@class,'fa fa')]"));
        public IWebElement CloseBtnBrkdwnModal => driver.FindElement(By.XPath("//div[@id='paymentBreakdownDialog']//button[text()='Close']"));

        
        public IWebElement StatusOfOrderProductDtls => driver.FindElement(By.XPath("//div[contains(@class,'item-price-details hidden-sm hidden-xs')]//div[contains(@class,'status')]"));
        public IWebElement UnitPrice => driver.FindElement(By.XPath("//div[contains(@class,'item-price-details hidden-sm hidden-xs')]//p[contains(text(),'Unit Price:')]"));
        public IWebElement QuantityProduct => driver.FindElement(By.XPath("//div[contains(@class,'item-price-details hidden-sm hidden-xs')]//p[contains(text(),'Quantity:')]"));
        public IWebElement TotalPrice => driver.FindElement(By.XPath("//div[contains(@class,'item-price-details hidden-sm hidden-xs')]//span[contains(text(),'TOTAL:')]"));


        //Order Summary panel
        public IWebElement OrderSummaryTitle => driver.FindElement(By.XPath("//div[@id='summary-wrap']//h3[text()='Order Summary']"));
        public IWebElement OrderStatusInSummary => driver.FindElement(By.XPath("//div[@id='summary-wrap']//div[contains(@class,'status')]"));
        public IWebElement OrderNumberInSummary => driver.FindElement(By.XPath("//div[@id='summary-wrap']//strong[contains(text(),'Order Number:')]"));
        public IWebElement OrderedDateInSummary => driver.FindElement(By.XPath("//div[@id='summary-wrap']//p[contains(text(),'Ordered on')]"));
        public IWebElement OrderedByInSummary => driver.FindElement(By.XPath("//div[@id='summary-wrap']//p[contains(text(),'Ordered by')]"));
        public IWebElement SubTotalInSummary => driver.FindElement(By.XPath("//div[@id='summary-wrap']//div[contains(text(),'Subtotal:')]"));
        public IWebElement TaxesInSummary => driver.FindElement(By.XPath("//div[@id='summary-wrap']//div[contains(text(),'Taxes:')]"));
        public IWebElement EstDeliveryInSummary => driver.FindElement(By.XPath("//div[@id='summary-wrap']//div[contains(text(),'Est. Delivery:')]"));
        public IWebElement TotalInSummary => driver.FindElement(By.XPath("//div[@id='summary-wrap']//div[contains(text(),'Total:')]"));
        public IWebElement FinalCostDisclaimerInSummary => driver.FindElement(By.XPath("//div[@id='summary-wrap']//p[contains(text(),'All costs display on this page are estimates for the first fulfillment.')]"));

        public void NavigateToOrderDetailsPage()
        {
            waitForPageLoad();
            OrderNumberLink.Click();
        }

        public void ValidateOrderNumberLinkAndOtherElements()
        {
            Assert.IsTrue(OrderConfirmationPageTitle.Displayed, "OrderConfirmationPageTitle is not displayed");
            Assert.IsTrue(ThankUMsgForOrder.Displayed, "ThankUMsgForOrder is not displayed");
            Assert.IsTrue(OrderPageLink.Displayed, "OrderPageLink is not displayed");
            Assert.IsTrue(OrderNumberLink.Displayed, "OrderNumberLink is not displayed");
            Assert.IsTrue(DateTimeStampOfOrder.Displayed, "DateTimeStampOfOrder is not displayed");
        }
        public void ValidateOrderDetailPageElements()
        {
            Assert.IsTrue(OrderDetailsPageTitle.Displayed, "OrderDetailsPageTitle is not displayed");
            Assert.IsTrue(OrderHistoryBrdCrmb.Displayed, "OrderHistoryBrdCrmb is not displayed");
            Assert.IsTrue(ItemsCount.Displayed, "ItemsCount is not displayed");
            Assert.IsTrue(PreviewImage.Displayed, "PreviewImage is not displayed");
            Assert.IsTrue(SKUforProduct.Displayed, "SKUforProduct is not displayed");

            Assert.IsTrue(EstimatedDeliveryAndScheduleCost.Displayed, "EstimatedDeliveryAndScheduleCost is not displayed");
            Assert.IsTrue(StatusOfOrderProductDtls.Displayed, "StatusOfOrderProductDtls is not displayed");
            Assert.IsTrue(UnitPrice.Displayed, "UnitPrice is not displayed");
            Assert.IsTrue(QuantityProduct.Displayed, "QuantityProduct is not displayed");
            Assert.IsTrue(TotalPrice.Displayed, "TotalPrice is not displayed");
        }
        
        public void ValidateOrderSummaryPanel()
        {
            Assert.IsTrue(SubTotalInSummary.Displayed, "SubTotalInSummary is not displayed");
            Assert.IsTrue(TaxesInSummary.Displayed, "TaxesInSummary is not displayed");
            Assert.IsTrue(EstDeliveryInSummary.Displayed, "EstDeliveryInSummary is not displayed");
            Assert.IsTrue(TotalInSummary.Displayed, "TotalInSummary is not displayed");
            Assert.IsTrue(FinalCostDisclaimerInSummary.Displayed, "FinalCostDisclaimerInSummary is not displayed");

            Assert.IsTrue(OrderSummaryTitle.Displayed, "OrderSummaryTitle is not displayed");
            Assert.IsTrue(OrderStatusInSummary.Displayed, "OrderStatusInSummary is not displayed");
            Assert.IsTrue(OrderNumberInSummary.Displayed, "OrderNumberInSummary is not displayed");
            Assert.IsTrue(OrderedDateInSummary.Displayed, "OrderedDateInSummary is not displayed");
            Assert.IsTrue(OrderedByInSummary.Displayed, "OrderedByInSummary is not displayed");
        }

        public void ValidateEstimatedDelivery()
        {
            //EstimatedDeliveryAndScheduleCost.Click();
            EstimatedDlvryLink.Click();
            waitForPageLoad();
            Assert.IsTrue(ShippingDateInEstdDelivery.Displayed, "ShippingDateInEstdDelivery is not displayed");
            Assert.IsTrue(ShippingIDInEstdDelivery.Displayed, "ShippingIDInEstdDelivery is not displayed");
            Assert.IsTrue(ShippingStatusInEstdDelivery.Displayed, "ShippingStatusInEstdDelivery is not displayed");
            Assert.IsTrue(ShippingMethodInEstdDelivery.Displayed, "ShippingMethodInEstdDelivery is not displayed");
            Assert.IsTrue(ShippingAddressInEstdDelivery.Displayed, "ShippingAddressInEstdDelivery is not displayed");

            Assert.IsTrue(TrackingInEstdDelivery.Displayed, "TrackingInEstdDelivery is not displayed");
            Assert.IsTrue(QuantityInEstdDelivery.Displayed, "QuantityInEstdDelivery is not displayed");
            Assert.IsTrue(DeliveryCostInEstdDelivery.Displayed, "DeliveryCostInEstdDelivery is not displayed");
        }

        public void ValidatePaymentBreakdownModal()
        {
            PaymentBreakdownLink.Click();
            waitForPageLoad();
            Thread.Sleep(2000);
            Assert.IsTrue(PaymentMethodInBrkdwnModal.Displayed, "PaymentMethodInBrkdwnModal is not displayed");
            CloseBtnBrkdwnModal.Click();
        }

        public void CancelDelivery()
        {
            waitForPageLoad();
            driver.FindElement(By.XPath("//a[contains(text(),'Cancel Delivery')]")).Click();
            waitForPageLoad();
            Thread.Sleep(2000);
        }



    }
}

