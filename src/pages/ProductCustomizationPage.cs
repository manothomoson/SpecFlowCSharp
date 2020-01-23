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
    
    class ProductCustomizationPage : Page
    {
        IWebDriver driver;
        public static dynamic jsonObj;

        public ProductCustomizationPage(IWebDriver driver) : base(driver)
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
        public IWebElement FirstNameProdCust => driver.FindElement(By.XPath("//input[@type='text' and contains(@class,'field-is-editable field-is-visible field-is-active')]")); ////input[@title='FirstName']//following-sibling::div/input[@type='text']
        public IWebElement LastNameProdCust => driver.FindElement(By.XPath("//input[@title='LastName']//following-sibling::div/input[@type='text']"));
        public IWebElement MobilePhoneProdCust => driver.FindElement(By.XPath("//input[@title='MobilePhone']//following-sibling::div/input[@type='text']"));
        public IWebElement OfficePhoneProdCust => driver.FindElement(By.XPath("//input[@title='OfficePhone']//following-sibling::div/input[@type='text']"));
        public IWebElement StateProdCust => driver.FindElement(By.XPath("//input[@title='State']//following-sibling::div/input[@type='text']"));
        public IWebElement WebsiteProdCust => driver.FindElement(By.XPath("//input[@title='Website']//following-sibling::div/input[@type='text']"));
        public IWebElement PreviewBtnProdCust => driver.FindElement(By.XPath("//div[@class='productCustomizationBtns']//button[text()='Preview']"));
        public IWebElement ZipProdCust => driver.FindElement(By.XPath("//input[@title='Zip']//following-sibling::div/input[@type='text']"));
        public IWebElement SaveDraftLinkProdCust => driver.FindElement(By.Id("saveCustomizeDraft"));
        public IWebElement errorInPreviewMsg => driver.FindElement(By.XPath("//span[@class='message-Message' and text()='An error occured while generating preview.']"));
        public IWebElement ApproveAndContinueBtn => driver.FindElement(By.Id("NextStepLink"));
        public IWebElement SaveCustomizeDraftBtn => driver.FindElement(By.Id("saveCustomizeDraft"));
        
        //public List<string> getTextFromWebElements(ReadOnlyCollection<IWebElement> webElements)
        //{
        //    List<string> listOfString = new List<string>();
        //    foreach (IWebElement element in webElements)
        //    {                
        //        string strTxtFrmElemnt = element.Text;
        //        listOfString.Add(strTxtFrmElemnt);
        //    }
        //    return listOfString;
        //}

        public void NavigateToProduct(string productName)
        {
            waitForPageLoad();
            driver.FindElement(By.XPath("//div[@id='productList']//a[text()='"+productName+ "']")).Click();
            waitForPageLoad();
            Assert.IsTrue(ProductDetailsTitleRslt.Displayed, "Product details page does not displayed");
        }
        public void NavigateToFirstProduct()
        {
            waitForPageLoad();
            driver.FindElement(By.XPath("//div[@id='productList']//a[@class='productLink']")).Click();
            waitForPageLoad();
            Assert.IsTrue(ProductDetailsTitleRslt.Displayed, "Product details page does not displayed");
        }

        public void NavigateToProductCustomizationPage()
        {
            waitForPageLoad();
            ContinueBtnInProductDetails.Click();
            waitForPageLoad();
        }
        public void FillProductCustomizationFields(string productType)
        {
            var PrintProductJson = jsonObj.SFProductCustomizationDetails[productType];
            Console.WriteLine("json data.."+ PrintProductJson.Address1.ToString());
            //Address1ProdCust.SendKeys(PrintProductJson.Address1.ToString());
            FirstNameProdCust.SendKeys(PrintProductJson.FirstName.ToString());
        }
        public void PreviewAndApproveFromCustomization()
        {
            
            PreviewBtnProdCust.Click();
            waitForPageLoad();
            //yet Code 
            Assert.IsFalse(errorInPreviewMsg.Displayed, "Error in Preview");
            Assert.IsTrue(SaveCustomizeDraftBtn.Displayed, "Save as draft not displayed");
            Assert.IsTrue(ApproveAndContinueBtn.Displayed, "Approve and continue button not displayed");
            ApproveAndContinueBtn.Click();

        }
    }
}
