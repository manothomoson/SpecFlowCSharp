using ConductorTest.src.pages;
using ConductorTest.test.support;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
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

    class ProductCreationPage : Page
    {
        IWebDriver driver;
        public static dynamic jsonObj;
        public static string FinalProductName;

        public IWebElement ProfileDrpDwn => driver.FindElement(By.Id("profile-dropdown"));
        public IWebElement AdministrationLink => driver.FindElement(By.XPath("//a[text()='Administration']"));
        public IWebElement AddEditProductsBtn => driver.FindElement(By.XPath("//a[text()='Add/Edit Products']"));
        public IWebElement AddNewProductBtn => driver.FindElement(By.Id("btnAddNewProduct"));

        // Print Product
        public IWebElement PrintProductTypeFromModal => driver.FindElement(By.XPath("//div[@id='productDialog']//a[text()='Print ']"));
        // General
        public IWebElement ProductNameTxt => driver.FindElement(By.XPath("//input[@id='Title_Title']"));
        public IWebElement ProductSKUTxt => driver.FindElement(By.XPath("//input[@id='ProductCommon_Sku']"));
        public IWebElement ProductDescriptionTxt => driver.FindElement(By.XPath("//body[@id='tinymce']"));
        // Images
        public IWebElement ImagesTab => driver.FindElement(By.XPath("//a[text()='Images']"));
        public IWebElement CatalogThumbnailImageAddBtn => driver.FindElement(By.XPath("//span[@id='btn-ProductCommonPart_SmallImage_Field_Ids']"));
        public IWebElement ProductDetailImagesAddBtn => driver.FindElement(By.XPath("//span[@id='btn-ProductCommonPart_MediumImage_Field_Ids']"));
        public IWebElement CustomizationImageAddBtn => driver.FindElement(By.XPath("//span[@id='btn-ProductCommonPart_LargeImage_Field_Ids']"));

        public IWebElement VisibilityTab => driver.FindElement(By.XPath("//a[text()='Visibility']"));
        public IWebElement PricingAndDeliveryTab => driver.FindElement(By.XPath("//a[text()='Pricing & Delivery']"));
        public IWebElement CustomizationTab => driver.FindElement(By.XPath("//a[text()='Customization']"));
        // Visibility
        public IWebElement ProductApprovalChckBx => driver.FindElement(By.Id("ProductCommonPart_ApprovalRequired_Value"));
        public IWebElement ProductInCatalogChckBx => driver.FindElement(By.Id("ProductCommonPart_IsShowInCatalog_Value"));
        public IWebElement ProductInCompaigCatalogChckBx => driver.FindElement(By.Id("ProductCommonPart_IsShowInCampaign_Value"));
        public IWebElement ProductTypePrint => driver.FindElement(By.XPath("//label[@class='forcheckbox' and text()='Print']"));
        public IWebElement UnitWeightProductTxt => driver.FindElement(By.XPath("//input[@id='PrintProduct_Weight']"));
        public IWebElement ExpirationOptionONRadio => driver.FindElement(By.XPath("//input[@id='ProductCommon_isActiveExpiryOn']"));
        public IWebElement ExpirationOptionOFFRadio => driver.FindElement(By.XPath("//input[@id='ProductCommon_isActiveExpiryOff']"));

        // Pricing & Delivery
        public IWebElement DeliveryOptionStandardRadio => driver.FindElement(By.XPath("//input[@id='printDeliveryMethods']"));
        public IWebElement MailDeliveryPrintPrdct => driver.FindElement(By.XPath("//input[@id='ProductPrintPart_DeliveryMail_Value']"));
        public IWebElement ShippedDeliveryPrintPrdct => driver.FindElement(By.XPath("//input[@id='ProductPrintPart_DeliveryShip_Value']"));
        public IWebElement DownloadedDeliveryPrintPrdct => driver.FindElement(By.XPath("//input[@id='ProductPrintPart_DeliveryElectronic_Value']"));
        public IWebElement CreateProductionRdyFiles => driver.FindElement(By.XPath("//input[@id='ProductCommonPart_CreateProductionReadyFiles_Value']"));
        public IWebElement PostageUSPSRate => driver.FindElement(By.XPath("//input[@id='ProductCommonUSPSId']"));
        public IWebElement CustomPostageRate => driver.FindElement(By.XPath("//input[@id='ProductCommonCustompostageId']"));
        public IWebElement AdvancedPostageRate => driver.FindElement(By.XPath("//input[@id='ProductCommonAdvancedPostageId']"));
       
        public IWebElement FreeShippingChkBx => driver.FindElement(By.XPath("//input[@id='ProductCommon_FreeShipping']"));
        public IWebElement ShipToMultipleAddressChkBx => driver.FindElement(By.XPath("//input[@id='ProductCommon_ConfiguratorSettings_ShipToMultipleAddress']"));

        public IWebElement SimplePricingRadioBtn => driver.FindElement(By.XPath("//input[@id='ProductCommonAdvancePricingFalse']"));
        public IWebElement AdvancedPricingRadioBtn => driver.FindElement(By.XPath("//input[@id='ProductCommonAdvancePricingTrue']"));
        public IWebElement UnitPriceSimpleTxt => driver.FindElement(By.XPath("//input[@id='ProductCommon_UnitPrice']"));
        public IWebElement DiscountUnitPriceTxt => driver.FindElement(By.XPath("//input[@id='ProductCommon_DiscountUnitPrice']"));

        //Customization
        
        public IWebElement AddCustomizationFieldBtn => driver.FindElement(By.Id("AddCustomizationFieldRow"));
        public IWebElement NameCustField => driver.FindElement(By.XPath("//input[contains(@id,'ProductCommon_NewFields') and not(@disabled)]"));
        public IWebElement DisplayTextField => driver.FindElement(By.XPath("//input[contains(@id,'FieldDisplayText') and not(@disabled)]"));
        public IWebElement TargetFieldSectionDrpDwn => driver.FindElement(By.XPath("//select[contains(@id,'TargetFieldSection') and not(@disabled)]"));
        public IWebElement DisplayTextLabel => driver.FindElement(By.XPath("//th[text()='Display Text']"));
        public IWebElement TargetFieldDrpdwn => driver.FindElement(By.XPath("//select[contains(@id,'TargetField') and @class='TargetField' and not(@disabled)]"));
        public IWebElement FieldTypeDrpdwn => driver.FindElement(By.XPath("//select[contains(@id,'_Type') and not(@disabled)]"));
        public IWebElement IsRequiredChkBx => driver.FindElement(By.XPath("//input[contains(@id,'IsRequired') and not(@disabled)]"));

        public IWebElement CoFundingPriceTxt => driver.FindElement(By.XPath("//input[@id='ProductCommonPart_CofundingAmount_Value']"));
        public IWebElement PublishNowBtn => driver.FindElement(By.XPath("//button[@id='submit_Publish']"));
        public IWebElement SaveBtn => driver.FindElement(By.XPath("//button[@value='submit.Save']"));
        public IWebElement productSavedSuccessMsg => driver.FindElement(By.XPath("//div[text()='Your Print Product has been saved.' or text()='Your Print Product has been created.']"));
        public IWebElement productPublishedSuccessMsg => driver.FindElement(By.XPath("//div[text()='Your Print Product has been published.']"));

        //SOLR
        public IWebElement SettingsExpandIcon => driver.FindElement(By.XPath("//li[@class='section-settings last collapsed']//span[@class='expando-glyph']"));
        public IWebElement SOLRLink => driver.FindElement(By.XPath("//a[text()='SOLR']"));
        public IWebElement SearchUsersTxt => driver.FindElement(By.Id("tagsUsers"));
        public IWebElement SelectUserList => driver.FindElement(By.Id("solrUsers"));
        public IWebElement SelectProductsList => driver.FindElement(By.Id("solrProducts"));
        public IWebElement UserAddBtnArrw => driver.FindElement(By.Id("UsersbtnAdd"));        
        public IWebElement SearchProductsTxt => driver.FindElement(By.Id("tagsProducts"));
        public IWebElement ProductsAddBtnArrw => driver.FindElement(By.Id("ProductsbtnAdd"));
        public IWebElement RefreshProductsBtn => driver.FindElement(By.Id("importButton"));
        
        public ProductCreationPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            jsonObj = getJson();
        }

       

       

        public void NavigateToAdministration()
        {
            waitForPageLoad();
            WaitForId("profile-dropdown");
            ProfileDrpDwn.Click();
            Thread.Sleep(2000);
            AdministrationLink.Click();
            waitForPageLoad();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            waitForPageLoad();
        }

        public void NavigateToSubMenu(string subMenu)
        {
            waitForPageLoad();
            driver.FindElement(By.XPath("//a[text()='" + subMenu + "']")).Click();
            waitForPageLoad();
        }
        public void AddProductFromProductsPage(string productType)
        {
            waitForPageLoad();
            AddNewProductBtn.Click();
            waitForPageLoad();
            driver.FindElement(By.XPath("//div[@id='productDialog']//a[contains(text(),'" + productType + "')]")).Click();
            waitForPageLoad();
        }
        public void FillGeneralProductsDetails(string productType)
        {
            waitForPageLoad();
            var PrintProductJson = jsonObj.ProductGeneralTabDetails[productType];
            //Address1ProdCust.SendKeys(PrintProductJson.Address1.ToString());
            FinalProductName = PrintProductJson.ProductName.ToString() + GenerateRandomNumber();
            ProductNameTxt.SendKeys(FinalProductName);
            Console.WriteLine("New product name for creation is: " + FinalProductName);
            driver.SwitchTo().Frame("Body_Text_ifr");
            ProductDescriptionTxt.Click();
            ProductDescriptionTxt.SendKeys(PrintProductJson.ProductDescription.ToString());
            driver.SwitchTo().DefaultContent();
            UnitWeightProductTxt.SendKeys(PrintProductJson.UnitWeight.ToString());
            //SaveBtn.Click();
        }

        public void FillDetailsForCustmization(string prodType)
        {
            var PrintProductJson = jsonObj.ProductCustomizationTabDetails[prodType];
            waitForPageLoad();
            AddCustomizationFieldBtn.Click();
            waitForPageLoad();
            NameCustField.SendKeys(PrintProductJson.FieldName.ToString());
            DisplayTextLabel.Click();
            Thread.Sleep(2000);
            waitForPageLoad();
            //DisplayTextField.Click();
            //Thread.Sleep(2000);
            waitForPageLoad();
            selectElement(TargetFieldSectionDrpDwn,"ByText", PrintProductJson.TargetFieldSelection.ToString());

            Thread.Sleep(3000);
            waitForPageLoad();

            //TargetFieldDrpdwn.Click();
            //Thread.Sleep(3000);
            waitForPageLoad();
            selectElement(TargetFieldDrpdwn, "ByText", PrintProductJson.TargetField.ToString());
            //FieldTypeDrpdwn.Click();
            waitForPageLoad();
            selectElement(FieldTypeDrpdwn, "ByText", PrintProductJson.FieldType.ToString());
            checkFlagAndClick(IsRequiredChkBx, PrintProductJson.Required.ToString());
        }

        public void NavigateToImages()
        {
            waitForPageLoad();
            ImagesTab.Click();
            waitForPageLoad();
        }
        public void NavigateToVisibility()
        {
            waitForPageLoad();
            VisibilityTab.Click();
            waitForPageLoad();
        }
        public void NavigateToSOLRForIndex()
        {
            IJavaScriptExecutor je = (IJavaScriptExecutor)driver;
            je.ExecuteScript("arguments[0].scrollIntoView(true);", SettingsExpandIcon);
            SettingsExpandIcon.Click();
            waitForPageLoad();
            SOLRLink.Click();
            waitForPageLoad();
        }
        public void RefreshProductsSOLR(string product, string user)
        {

            waitForPageLoad();
            string userName = jsonObj.Users[user].UserName.ToString();
            SearchUsersTxt.SendKeys(userName);
            selectElement(SelectUserList, "ByText", userName);
            UserAddBtnArrw.Click();
            //waitForPageLoad();

            if (product.Equals("createdProduct"))
            {
                SearchProductsTxt.SendKeys(FinalProductName);
            }
            else
            {
                SearchProductsTxt.SendKeys(product);
            }
            selectElement(SelectProductsList, "ByIndex", "0");
            ProductsAddBtnArrw.Click();
            //waitForPageLoad();
            RefreshProductsBtn.Click();
            Thread.Sleep(1000);
            driver.SwitchTo().Alert().Accept();
            waitForPageLoad();
        }
        public void UploadImageForCatagory(string imageToUploadCatagory)
        {
            switch (imageToUploadCatagory)
            {
                case "Catalog Thumbnail":
                    CatalogThumbnailImageAddBtn.Click();
                    waitForPageLoad();
                    selectImageFromTestDirectory("lion.jpg");
                    break;
                case "Product Details":
                    ProductDetailImagesAddBtn.Click();
                    waitForPageLoad();
                    selectImageFromTestDirectory("lion.jpg");
                    break;
                case "Customization Default":
                    CustomizationImageAddBtn.Click();
                    waitForPageLoad();
                    selectImageFromTestDirectory("lion.jpg");
                    break;
            }
            //SaveBtn.Click();
        }

        //public IWebElement TestAutofolder => driver.FindElement(By.XPath("//span[text()='TestAutomation']"));
        public void selectImageFromTestDirectory(string imageName)
        {
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@class='cboxIframe']")));
            waitForPageLoad();
            Thread.Sleep(4000);            
            if (TryFindElement(By.XPath("//span[text()='TestAutomation']"), out IWebElement element))
            {
                //bool visible = IsElementVisible(element);
                //Thread.Sleep(2000);
                //if (visible)
                //{
                element.Click();
                Thread.Sleep(4000);
                //}

            }
            else
            {
                driver.FindElement(By.XPath("//span[text()='My Assets']")).Click();
                Thread.Sleep(4000);
                driver.FindElement(By.XPath("//span[text()='Images']")).Click();
                Thread.Sleep(4000);
                driver.FindElement(By.XPath("//span[text()='TestAutomation']")).Click();
                Thread.Sleep(4000);
            }

            driver.FindElement(By.XPath("//div[@id='media-library-main-list']//img[contains(@src,'" + imageName + "')]")).Click();
            driver.FindElement(By.XPath("//button[text()='Select']")).Click();
            driver.SwitchTo().DefaultContent();
        }

        public void SetVisibilityProductAndCompaign()
        {
            ProductInCatalogChckBx.Click();
            ProductInCompaigCatalogChckBx.Click();
        }

        public void SelectProductCatogory(string prodCatagory)
        {
            var VisibilityJson = jsonObj.ProductVisibilityTabDetails[prodCatagory];
            checkFlagAndClick(ProductApprovalChckBx, VisibilityJson.VisibilityOptions.RequireOrderApproval);
            checkFlagAndClick(ProductInCatalogChckBx, VisibilityJson.VisibilityOptions.AppearProductCatalog);
            checkFlagAndClick(ProductInCompaigCatalogChckBx, VisibilityJson.VisibilityOptions.AppearCampaignCatalog);
            string productType = VisibilityJson.ProductCatagories.ProductCatagory.ToString();
            driver.FindElement(By.XPath("//label[text()='" + productType + "']")).Click();
        }

        public void NavigateToPricingAndDeliveryTab()
        {
            PricingAndDeliveryTab.Click();
            waitForPageLoad();
        }

        public void NavigateToCustomizationTab()
        {
            CustomizationTab.Click();
            waitForPageLoad();
        }

        public void FillDetailsForPricingAndDelivery(string prodType)
        {
            waitForPageLoad();
            var PricingAndDeliveryJson = jsonObj.ProductPricingAndDeliveryTabDetails[prodType];

            //DeliveryOptions
            DeliveryOptionStandardRadio.Click();
            checkFlagAndClick(MailDeliveryPrintPrdct, PricingAndDeliveryJson.StandardOptions.ProductMailed);
            checkFlagAndClick(ShippedDeliveryPrintPrdct, PricingAndDeliveryJson.StandardOptions.ProductShipped);
            checkFlagAndClick(DownloadedDeliveryPrintPrdct, PricingAndDeliveryJson.StandardOptions.ProductDownloaded);

            //Fulfillment
            checkFlagAndClick(CreateProductionRdyFiles, PricingAndDeliveryJson.Fulfillment.CreateProductionReadyfiles);

            //Postage
            checkFlagAndClick(PostageUSPSRate, PricingAndDeliveryJson.Postage.UseUSPSPublishedRate);
            checkFlagAndClick(CustomPostageRate, PricingAndDeliveryJson.Postage.UseCustomPostageRate);
            checkFlagAndClick(PostageUSPSRate, PricingAndDeliveryJson.Postage.UseAdvancedPostageRates);

            //Shipping
            checkFlagAndClick(FreeShippingChkBx, PricingAndDeliveryJson.Shipping.Freeshipping);
            checkFlagAndClick(ShipToMultipleAddressChkBx, PricingAndDeliveryJson.Shipping.ShipToMultipleAddresses);

            //Pricing
            checkFlagAndClick(SimplePricingRadioBtn, PricingAndDeliveryJson.Pricing.SimplePricing);
            UnitPriceSimpleTxt.Clear();
            UnitPriceSimpleTxt.SendKeys(PricingAndDeliveryJson.Pricing.UnitPrice.ToString());
            DiscountUnitPriceTxt.Clear();
            DiscountUnitPriceTxt.SendKeys(PricingAndDeliveryJson.Pricing.DiscountUnitPrice.ToString());            
            checkFlagAndClick(AdvancedPricingRadioBtn, PricingAndDeliveryJson.Pricing.AdvancedPricing);

            //CoFunding
            CoFundingPriceTxt.SendKeys(PricingAndDeliveryJson.CoFunding.CofundingAmount.ToString());
        }
        
        public void SaveAndPublishNowProduct()
        {
            waitForPageLoad();
            SaveBtn.Click();
            waitForPageLoad();
            Assert.IsTrue(IsElementVisible(productSavedSuccessMsg), "Product did not saved successfully.");
            PublishNowBtn.Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();
            Assert.IsTrue(IsElementVisible(productPublishedSuccessMsg), "Product did not published successfully.");
        }
    }
}
