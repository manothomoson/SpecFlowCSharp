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
    
    class ProductShoppingCartPage : Page
    {
        IWebDriver driver;
        public static dynamic jsonObj;
        ProductDeliveryOptionsPage deliveryOptionsPage;
        public static int itemCountFromCart;
        public ProductShoppingCartPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            jsonObj = getJson();
            this.deliveryOptionsPage = new ProductDeliveryOptionsPage(driver);
        }

        public IWebElement ShoppingCartTitle => driver.FindElement(By.XPath("//h1[text()='Shopping Cart']"));
        public IWebElement ProductDetailsTitle => driver.FindElement(By.XPath("//h1[contains(text(),'Product Details')]"));

        //Cart Summary
        public IWebElement SubTotalPrice => driver.FindElement(By.XPath("//div[@id='pricing-Sumamry-Cart-Summary']//div[contains(text(),'Subtotal:')]/following-sibling::div"));
        public IWebElement TaxesInCartSummary => driver.FindElement(By.XPath("//div[@id='pricing-Sumamry-Cart-Summary']//div[contains(text(),'Taxes:')]"));
        public IWebElement DeliveryInCartSummary => driver.FindElement(By.XPath("//div[@id='pricing-Sumamry-Cart-Summary']//div[contains(text(),'Delivery:')]"));
        public IWebElement TotalCartSummary => driver.FindElement(By.XPath("//div[@id='pricing-Sumamry-Cart-Summary']//div[contains(text(),'Total:')]/following-sibling::div"));
        public IWebElement ProceedToCheckout => driver.FindElement(By.XPath("//div[@id='summary-wrap']//a[text()='Proceed to Checkout']"));
        public IWebElement ContinueShoppingLink => driver.FindElement(By.XPath("//div[@id='summary-wrap']//a[@id='aContinueShopping']"));
        public IWebElement CartDisclaimerMsg => driver.FindElement(By.XPath("//div[@id='summary-wrap']//p[@class='small']"));

        //product section
        public IWebElement ProductTitleCart => driver.FindElement(By.XPath("//h4[@class='product-title-catalog hidden-sm hidden-xs']"));
        public IWebElement ProductSkuCart => driver.FindElement(By.XPath("//p[@class='sku hidden-sm hidden-xs']"));
        public IWebElement ItemsCountCart => driver.FindElement(By.XPath("//h2[@class='count-header item-count']"));
        public IWebElement PreviewProductLink => driver.FindElement(By.Id("prev_Pageflex"));
        public IWebElement ProductNickNameTxt => driver.FindElement(By.XPath("//input[contains(@id,'inputProductNickname')]"));
        public IWebElement NickNameAddBtn => driver.FindElement(By.XPath("//a[contains(text(),'Add') and contains(@onclick,'addNickName')]"));
        public IWebElement NickNameRemoveBtn => driver.FindElement(By.XPath("//a[@class='link deleteProductNicknameButton']"));
        public IWebElement EditProductBtnInCart => driver.FindElement(By.XPath("//i[@class='fa fa-pencil' and @aria-hidden]"));
        public IWebElement CopyProductBtnInCart => driver.FindElement(By.XPath("//i[@class='fa fa-copy' and @aria-hidden]"));
        public IWebElement RemoveProductBtnInCart => driver.FindElement(By.XPath("//i[@class='fa fa-trash' and @aria-hidden]"));
        public IWebElement SaveForLaterBtnInCart => driver.FindElement(By.XPath("//i[@class='fa fa-floppy-o' and @aria-hidden]"));
        public IWebElement EstimatedDeliveryCostExpandBtn => driver.FindElement(By.XPath("//a[contains(text(),'Estimated Delivery Schedule & Cost')]"));
        
        //item-price-details

        public IWebElement UnitPriceItem => driver.FindElement(By.XPath("//div[contains(@class,'item-price-details hidden-sm hidden-xs')]//p[contains(text(),'Unit Price:')]"));
        public IWebElement QuanitityItem => driver.FindElement(By.XPath("//div[contains(@class,'item-price-details hidden-sm hidden-xs')]//p[contains(text(),'Quantity:')]"));
        public IWebElement TotalPriceItem => driver.FindElement(By.XPath("//p[contains(@class,'text-right total')]//span[contains(text(),'TOTAL:')]"));

        //GL Code

        public IWebElement GeneralLedgerCodeExpand => driver.FindElement(By.XPath("//a[contains(text(),'General Ledger Codes')]"));
        public IWebElement ProductGLManageLink => driver.FindElement(By.XPath("//a[contains(text(),'Manage')]"));
        public IWebElement UserGLManageLink => driver.FindElement(By.XPath("//div[@data-level='Manage User General Ledger Codes']//a[contains(text(),'Manage')]"));
        public IWebElement OrderGLManageLink => driver.FindElement(By.XPath("//div[@data-level='Manage Order General Ledger Codes']//a[contains(text(),'Manage')]"));
        public IWebElement NewGLCodeTxtBox => driver.FindElement(By.XPath("//input[@name='newCode']"));
        public IWebElement AddBtnGLCode => driver.FindElement(By.XPath("//button[@name='addCode']"));
        public IWebElement UpdateBtnGLCode => driver.FindElement(By.XPath("//button[text()='Update']"));

        //Save for Later

       public IWebElement SaveForLaterTitle => driver.FindElement(By.XPath("//div[@id='savedDiv']//h3[contains(text(),'Saved for Later')]"));
       public IWebElement AddToCartBtn => driver.FindElement(By.XPath(" //a[contains(text(),'Add to Cart')]"));
       public IWebElement CopyProductBtnSaveLater => driver.FindElement(By.XPath("//div[@id='savedDiv']//i[@class='fa fa-copy' and @aria-hidden]"));

       public IWebElement RemoveProdectBtnSaveLater => driver.FindElement(By.XPath("//div[@id='savedDiv']//i[@class='fa fa-trash' and @aria-hidden]"));
        //  --------
        //-------------------

        public IWebElement ProductSummaryTotalPrice => driver.FindElement(By.XPath("//div[contains(@class,'text-right amount')]"));

       
        public IWebElement SaveAsDraftLink => driver.FindElement(By.XPath("//div[@style='display: block;']//a[contains(@id,'SaveDraft')]"));
        public IWebElement DeleteDeliveryIcon => driver.FindElement(By.XPath("//div[@style='display: block;']//a[contains(@class,'link deleteDeliveryButton')]"));

        public void ValidateCartSummarySection()
        {
            waitForPageLoad();
            Assert.IsTrue(ShoppingCartTitle.Displayed, "ShoppingCartTitle is not displayed");
            Assert.IsTrue(SubTotalPrice.Displayed, "SubTotalPrice is not displayed");
            Assert.IsTrue(TaxesInCartSummary.Displayed, "TaxesInCartSummary is not displayed");
            Assert.IsTrue(DeliveryInCartSummary.Displayed, "DeliveryInCartSummary is not displayed");
            Assert.IsTrue(ProceedToCheckout.Displayed, "ProceedToCheckout btn is not displayed");
            Assert.IsTrue(ContinueShoppingLink.Displayed, "ContinueShoppingLink btn is not displayed");
            Assert.IsTrue(CartDisclaimerMsg.Displayed, "ContinueShoppingLink btn is not displayed");
        }

        public void ValidateProductDetailsFromCartSection()
        {
            waitForPageLoad();
            Assert.IsTrue(ItemsCountCart.Displayed, "ProductSkuCart is not displayed");
            Assert.IsTrue(ProductTitleCart.Displayed, "ProductTitleCart is not displayed");
            Assert.IsTrue(ProductSkuCart.Displayed, "ProductSkuCart is not displayed");
            //Assert.IsTrue(PreviewProductLink.Displayed, "ProductSkuCart is not displayed");
            Assert.IsTrue(ProductNickNameTxt.Displayed, "ProductNickNameTxt is not displayed");
            Assert.IsTrue(EstimatedDeliveryCostExpandBtn.Displayed, "EstimatedDeliveryCostExpandBtn is not displayed");
            Assert.IsTrue(UnitPriceItem.Displayed, "UnitPriceItem is not displayed");
            Assert.IsTrue(QuanitityItem.Displayed, "QuanitityItem is not displayed");
            Assert.IsTrue(TotalPriceItem.Displayed, "TotalPriceItem is not displayed");
        }

        public void ValidateEstimatedDeliveryAndCostSection()
        {
            EstimatedDeliveryCostExpandBtn.Click();
            waitForPageLoad();
            Assert.IsTrue(driver.FindElement(By.XPath("//td[@data-title='shipping date']/span")).Displayed, "Shipping date not displayed");
            Assert.IsTrue(driver.FindElement(By.XPath("//td[@data-title='delivery method']/span")).Displayed, "Delivery method not displayed");
            Assert.IsTrue(driver.FindElement(By.XPath("//td[@data-title='cost ']/span")).Displayed, "Delivery cost not displayed");

        }

        public void AddGeneralLedgerCodeToTheProduct()
        {
            var GLCodeJson = jsonObj.SFGeneralLedgerCode; 
            if (IsElementVisible(GeneralLedgerCodeExpand)){
                GeneralLedgerCodeExpand.Click();
                waitForPageLoad();
                ProductGLManageLink.Click();
                waitForPageLoad();
                NewGLCodeTxtBox.SendKeys(GLCodeJson.ProductGLCode.ToString());
                AddBtnGLCode.Click();
                UpdateBtnGLCode.Click();
                waitForPageLoad();                
            }
            
        }

        public void AddProductNickName(string prodNickName)
        {
            if (IsElementVisible(NickNameRemoveBtn))
            {
                NickNameRemoveBtn.Click();
                Thread.Sleep(2000);
                waitForPageLoad();

            }
            waitForPageLoad();
            ProductNickNameTxt.SendKeys(prodNickName);
            NickNameAddBtn.Click();
            waitForPageLoad();
            Thread.Sleep(2000);
        }

        public void NavigateFromCartPageToPaymentPage()
        {
            waitForPageLoad();
            ProceedToCheckout.Click();
            waitForPageLoad();
        }

        public void EditProductFromCart()
        {
            EditProductBtnInCart.Click();
            waitForPageLoad();
            Assert.IsTrue(ProductDetailsTitle.Displayed, "Product details page not displayed");
        }

        public void UpdateDeliveryOptionsPageDetails(string ShipType)
        {
            deliveryOptionsPage.FillDeliveryOptionsDetails(ShipType);
        }

        public void GetCurrentItemCountFromCart()
        {
            itemCountFromCart = 0;
            string itemcount = ItemsCountCart.Text;
            itemcount = itemcount.Split(' ')[0];
            Console.WriteLine("item count.." + itemcount);
            bool flag = int.TryParse(itemcount, out itemCountFromCart);
            if (!flag)
            {
                Assert.Fail("Item count from cart retrieved successfully");                
            }
        }

        public void ValidateCartCountAfterEditProduct()
        {
            int itemCountAfterEdit = 0;
            string itemcount = ItemsCountCart.Text;
            itemcount = itemcount.Split(' ')[0];
            Console.WriteLine("item count.." + itemcount);
            if (int.TryParse(itemcount, out itemCountAfterEdit))
            {
                if (!(itemCountFromCart == itemCountAfterEdit))
                {
                    Assert.Fail("Product not copied from cart successfully");
                }
            }
        }

        public void CopyProductFromTheShoppingCartPage()
        {
            //itemCountFromCart = 0;
            //string itemcount = ItemsCountCart.Text;
            //itemcount = itemcount.Split(' ')[0];
            //Console.WriteLine("item count.." + itemcount);
            //bool flag = int.TryParse(itemcount, out itemCountFromCart);
            //if (flag) { 
            CopyProductBtnInCart.Click();
            waitForPageLoad();
            //}
            Assert.IsTrue(ProductDetailsTitle.Displayed, "Product details page not displayed");
        }

        public void ValidateCartItemsAfterCopyProduct()
        {
            int itemCountAfterCopy = 0;
            string itemcount = ItemsCountCart.Text;
            itemcount = itemcount.Split(' ')[0];
            Console.WriteLine("item count.." + itemcount);
            if (int.TryParse(itemcount, out itemCountAfterCopy)) { 
                if(!(itemCountFromCart < itemCountAfterCopy))
                {
                    Assert.Fail("Product not copied from cart successfully");
                }
            }
        }

        public void SaveForLaterProductFrmCart()
        {
            waitForPageLoad();
            SaveForLaterBtnInCart.Click();
            waitForPageLoad();
            Assert.IsTrue(SaveForLaterTitle.Displayed, "Save for later section not displayed");

        }

        public void ValidateCopyRemoveAddToCartButton()
        {
            Assert.IsTrue(AddToCartBtn.Displayed, "Add to cart button not displayed");
            Assert.IsTrue(CopyProductBtnSaveLater.Displayed, "Copy button not displayed");
            Assert.IsTrue(RemoveProdectBtnSaveLater.Displayed, "Remove button not displayed");
        }

        public void ValidateCartCountAfterSaveAProductForLater()
        {
            int itemCountAfterSaveForLater = 0;
            string itemcount = ItemsCountCart.Text;
            itemcount = itemcount.Split(' ')[0];
            if (int.TryParse(itemcount, out itemCountAfterSaveForLater))
            {
                if (!(itemCountFromCart > itemCountAfterSaveForLater))
                {
                    Assert.Fail("Product not copied from cart successfully");
                }
            }

        }

        public void RemoveTheProductFromTheCart()
        {
            waitForPageLoad();
            RemoveProductBtnInCart.Click();
            //waitForPageLoad();
            Thread.Sleep(1000);
            driver.SwitchTo().Alert().Accept();
            waitForPageLoad();
        }


        public void ValidateCartCountAfterRemovingAProduct()
        {
            int itemCountAfterRemove = 0;
            string itemcount = ItemsCountCart.Text;
            itemcount = itemcount.Split(' ')[0];
            if (int.TryParse(itemcount, out itemCountAfterRemove))
            {
                if (!(itemCountFromCart > itemCountAfterRemove))
                {
                    Assert.Fail("Product not copied from cart successfully");
                }
            }
        }

        public void RemoveExistingItemsFromShoppingCart()
        {
            string noOfItems = driver.FindElement(By.XPath("//button[@id='linkShoppingCart']/span[@class='badge']")).Text;
            int intItems = Int32.Parse(noOfItems);
            if (intItems > 0)
            {
                driver.FindElement(By.XPath("//button[@id='linkShoppingCart']/span[@class='badge']")).Click();
                waitForPageLoad();
                for(int i=0; i < intItems; i++) {
                    RemoveTheProductFromTheCart();
                }

            }
        }
    }
}

