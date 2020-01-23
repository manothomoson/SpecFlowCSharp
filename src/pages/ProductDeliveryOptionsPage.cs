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
    
    class ProductDeliveryOptionsPage : Page
    {
        IWebDriver driver;
        public static dynamic jsonObj;

        public ProductDeliveryOptionsPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            jsonObj = getJson();
        }
        public IWebElement ProductDetailsTitleRslt => driver.FindElement(By.XPath("//h1[@id='pageTitle' and contains(text(),'Product Details')]"));
        public IWebElement ContinueBtnInProductDetails => driver.FindElement(By.Id("continueButton"));
        public IWebElement ProductCustomizationPanel => driver.FindElement(By.Id("fieldscontentcontainer"));
        public IWebElement Address1ProdCust => driver.FindElement(By.XPath("//input[@title='Address1']//following-sibling::div/input[@type='text']"));
        public IWebElement Address2ProdCust => driver.FindElement(By.XPath("//input[@title='Address2']//following-sibling::div/input[@type='text']"));
        public IWebElement CityProdCust => driver.FindElement(By.XPath("//input[@title='City']//following-sibling::div/input[@type='text']"));
        public IWebElement ZipProdCust => driver.FindElement(By.XPath("//input[@title='Zip']//following-sibling::div/input[@type='text']"));

        //Delivery Options
       
        public IWebElement ProductSummaryTable => driver.FindElement(By.Id("summary-wrap"));
        public IWebElement ProductImage => driver.FindElement(By.XPath("//img[@class='img-responsive product-image' and contains(@src,'jpg')]"));
        public IWebElement ProductTitle => driver.FindElement(By.ClassName("product-title-catalog"));
        public IWebElement ProductSku => driver.FindElement(By.ClassName("sku"));
        public IWebElement ProductStartingPricingDetails => driver.FindElement(By.ClassName("pricing-details"));
        public IWebElement ProductQuantityDetails => driver.FindElement(By.XPath("//div[contains(@class,'text-right quantity')]"));
        public IWebElement ProductUnitPrice => driver.FindElement(By.XPath("//div[contains(@class,'text-right unitprice')]"));
        public IWebElement ProductDeliveryCost => driver.FindElement(By.XPath("//div[contains(@class,'text-right deliveryCost')]"));
        public IWebElement ProductSummaryTotalPrice => driver.FindElement(By.XPath("//div[contains(@class,'text-right amount')]"));

        public IWebElement DeliveryMethodSelect => driver.FindElement(By.Name("deliveryOptions"));
        public IWebElement QuantityTxt => driver.FindElement(By.Id("quantity"));
        public IWebElement AddressListRadioBtn => driver.FindElement(By.XPath("//div[contains(@class,'addressRow')]//input[@type='radio']"));
        public IWebElement AddShipDateButton => driver.FindElement(By.XPath("//div[@style='display: block;']//button[@class='btn btn-secondary addDeliveryModalButton']"));
        public IWebElement FrequencyDropdown => driver.FindElement(By.XPath("//div[@style='display: block;']//select[contains(@id,'frequency')]"));
        public IWebElement StartDateShipping => driver.FindElement(By.XPath("//div[@style='display: block;']//input[contains(@id,'newStartDate')]"));
        public IWebElement EndDateShipping => driver.FindElement(By.XPath("//div[@style='display: block;']//input[contains(@id,'newEndDate')]"));        
        public IWebElement DatePickerModal => driver.FindElement(By.Id("ui-datepicker-div"));
        public IWebElement FirstAvailableDate => driver.FindElement(By.XPath("//td[@data-handler='selectDay']/a[@class='ui-state-default']"));
        public IWebElement LastAvailableDate => driver.FindElement(By.XPath("(//td[@data-handler='selectDay'])[last()]//a"));
        public IWebElement AddShipDateBtnDateModal => driver.FindElement(By.XPath("//div[@style='display: block;']//button[contains(@id,'DeliveryButton')]"));
        public IWebElement NextArrwDatePicker => driver.FindElement(By.XPath("//a[@title='Next']"));
        public IWebElement DeliveryMethodShipDrpdwn => driver.FindElement(By.Id("deliveryMethodShip"));
        public IWebElement DeliveryTypeShipDrpdwn => driver.FindElement(By.Id("deliveryTypeShip"));
        public IWebElement DeliveryCostShipping => driver.FindElement(By.XPath("//div[@id='shipContainer']//div[@class='estimated-charges']//b"));
        public IWebElement ContinueBtnDeliveryOptionPage => driver.FindElement(By.XPath("//div[@style='display: block;']//button[contains(@id,'ContinueButton')]"));
        public IWebElement ShoppingCartPageTitle => driver.FindElement(By.XPath("//h1[@id='pageTitle' and text()='Shopping Cart']"));
        //DeliveryOptions - Mail to Recipient List

        public IWebElement AddListBtn => driver.FindElement(By.XPath("//a[@class='AddList btn btn-secondary']"));
        public IWebElement FirstRecipientListChkBx => driver.FindElement(By.XPath("//td//input[@id='checkbox' and @onclick='setListId();']"));
        public IWebElement UseSelectedListBtn => driver.FindElement(By.XPath("//button[text()='Use Selected Lists']"));
        public IWebElement AddMailDateButton => driver.FindElement(By.XPath("//div[@style='display: block;']//button[@data-target='.addDeliveryModalOptionsMail']"));
        public IWebElement AddedRecipientList => driver.FindElement(By.XPath("//div[contains(@class,'recipient-list-info')]"));
        public IWebElement DeleteRecipientListBtn => driver.FindElement(By.XPath("//a[contains(@class,'deleteRecipientList')]"));
        public IWebElement ManageListLink => driver.FindElement(By.XPath("//a[text()='Manage List']"));
        public IWebElement DeliveryMethodMailDrpdwn => driver.FindElement(By.Id("deliveryMethodMail"));
        public IWebElement DeliveryTypeMailDrpdwn => driver.FindElement(By.Id("deliveryTypeMail"));
        public IWebElement DeliveryCostMailing => driver.FindElement(By.XPath("//div[@id='mailContainer']//div[@class='estimated-charges']//b"));
        public IWebElement SaveAsDraftLink => driver.FindElement(By.XPath("//div[@style='display: block;']//a[contains(@id,'SaveDraft')]"));
        public IWebElement DeleteDeliveryIcon => driver.FindElement(By.XPath("//div[@style='display: block;']//a[contains(@class,'link deleteDeliveryButton')]"));

        public void NavigateToProduct(string productName)
        {
            waitForPageLoad();
            driver.FindElement(By.XPath("//div[@id='productList']//a[text()='"+productName+ "']")).Click();
            waitForPageLoad();
            Assert.IsTrue(ProductDetailsTitleRslt.Displayed, "Product details page does not displayed");
        }
        public void FillProductCustomizationFields(string productType)
        {
            var PrintProductJson = jsonObj.ProductCustomization.PrintProduct;
            Console.WriteLine("json data.."+ PrintProductJson.Address1.ToString());
            Address1ProdCust.SendKeys(PrintProductJson.Address1.ToString());
        }

        public void FillDeliveryOptionsDetails(string shipType)
        {
            var DeliveryOptionsJson = jsonObj.SFProductDeliveryOptionsDetails[shipType];
            
            switch (shipType)
            {
                case "ShipToAnAddress":

                    selectMethodOfDelivery(DeliveryOptionsJson.PreferredDeliveryMethod.ToString());
                    QuantityTxt.Clear();
                    QuantityTxt.SendKeys(DeliveryOptionsJson.Quantity.ToString());
                    Thread.Sleep(3000);
                    waitForPageLoad();
                    AddressListRadioBtn.Click();
                    IJavaScriptExecutor je = (IJavaScriptExecutor)driver;
                    je.ExecuteScript("arguments[0].scrollIntoView(true);", AddShipDateButton);
                    Thread.Sleep(2000);
                    AddShipDateButton.Click();
                    string frequency = DeliveryOptionsJson.ShipDateFrequency.ToString();
                    FillFrequencyDateModal(frequency);
                    waitForPageLoad();
                    selectElement(DeliveryMethodShipDrpdwn, "ByText", DeliveryOptionsJson.DeliveryMethod.ToString());
                    Thread.Sleep(2000);
                    selectElement(DeliveryTypeShipDrpdwn, "ByText", DeliveryOptionsJson.DeliveryType.ToString());
                    Thread.Sleep(1000);
                    Assert.IsTrue(DeliveryCostShipping.Displayed, "Failed to estimate Delivery cost");
                    break;

                case "MailToRecipientList":

                    selectMethodOfDelivery(DeliveryOptionsJson.PreferredDeliveryMethod.ToString());
                    waitForPageLoad();
                    AddListBtn.Click();
                    waitForPageLoad();
                    Thread.Sleep(4000);
                    driver.SwitchTo().Frame("addRecipientList");
                    FirstRecipientListChkBx.Click();
                    waitForPageLoad();
                    UseSelectedListBtn.Click();
                    waitForPageLoad();
                    driver.SwitchTo().DefaultContent();
                    Assert.IsTrue(AddedRecipientList.Displayed, "Failed to add recipient list");
                    Assert.IsTrue(DeleteRecipientListBtn.Displayed, "Delete button not enabled");
                    Assert.IsTrue(ManageListLink.Displayed, "Manage list link not displayd");

                    AddMailDateButton.Click();
                    frequency = DeliveryOptionsJson.ShipDateFrequency.ToString();

                    FillFrequencyDateModal(frequency);

                    waitForPageLoad();
                    selectElement(DeliveryMethodMailDrpdwn, "ByText", DeliveryOptionsJson.DeliveryMethod.ToString());
                    Thread.Sleep(2000);
                    selectElement(DeliveryTypeMailDrpdwn, "ByText", DeliveryOptionsJson.DeliveryType.ToString());
                    Thread.Sleep(1000);
                    Assert.IsTrue(DeliveryCostMailing.Displayed, "Failed to estimate Delivery cost");
                    break;

                case "Download":
                    selectMethodOfDelivery(DeliveryOptionsJson.PreferredDeliveryMethod.ToString());
                    waitForPageLoad();
                    //Assert.IsTrue(SaveAsDraftLink.Displayed, "Save as draft link not displayed");
                    break;
            }
            
            
        }

        public void FillFrequencyDateModal(string frequency)
        {
            
            waitForPageLoad();
            Thread.Sleep(2000);
            selectElement(FrequencyDropdown, "ByValue", frequency);
            StartDateShipping.Click();
            Thread.Sleep(1000);
            FirstAvailableDate.Click();
            if (!(frequency == "Single"))
            {
                Thread.Sleep(2000);
                EndDateShipping.Click();
                switch (frequency)
                {
                    case "Daily":
                        LastAvailableDate.Click();
                        break;
                    case "Weekly":
                        Thread.Sleep(1000);
                        NextArrwDatePicker.Click();
                        Thread.Sleep(1000);
                        LastAvailableDate.Click();
                        break;
                    case "Monthly":
                        NextArrwDatePicker.Click();
                        NextArrwDatePicker.Click();
                        Thread.Sleep(1000);
                        LastAvailableDate.Click();
                        break;
                }

            }
            Thread.Sleep(2000);
            AddShipDateBtnDateModal.Click();

            waitForPageLoad();
            Assert.IsTrue(DeleteDeliveryIcon.Displayed, "Delete link for delivery option not displayed");
        }
        public void selectMethodOfDelivery(string methodDelivery)
        {
            selectElement(DeliveryMethodSelect, "ByText", methodDelivery);
        }

        public void ContinueFromDeliveryOptions()
        {
            ContinueBtnDeliveryOptionPage.Click();
            waitForPageLoad();

        }
    }
}
