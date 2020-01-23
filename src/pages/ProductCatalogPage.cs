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
    
    class ProductCatalogPage : Page
    {
        IWebDriver driver;
        public static dynamic jsonObj;
         
        public IWebElement ProductsMenu => driver.FindElement(By.Id("link-Products2"));
        public IWebElement ProductSearchTxt => driver.FindElement(By.Id("productSearchBox"));
        public IWebElement ProductSearchBtn => driver.FindElement(By.XPath("//span[@class='glyphicon glyphicon-search']"));
        public IWebElement ProductsTitleRslt => driver.FindElement(By.XPath("//h1[@id='pageTitle' and text()='Products']"));
        public IWebElement ProductDetailsTitleRslt => driver.FindElement(By.XPath("//h1[@id='pageTitle' and contains(text(),'Product Details')]"));
        public IWebElement ProductsSortByDrpdwn => driver.FindElement(By.Id("sortBy"));
        public IWebElement FilterGrpMediaType => driver.FindElement(By.Id("Media_TypeGroup"));
        public IWebElement FilterGrpPurpose => driver.FindElement(By.Id("PurposeGroup"));
        public IWebElement FilterGrpLine => driver.FindElement(By.Id("LineGroup"));
        public IWebElement FilterGrpFeatured => driver.FindElement(By.Id("FeaturedGroup"));
        public IWebElement FilterGrpProductType => driver.FindElement(By.Id("Product_TypeGroup"));
        public IWebElement FilterGrpPageType => driver.FindElement(By.Id("Page_TypeGroup"));
        public IWebElement FilterGrpDeliveryType => driver.FindElement(By.Id("Delivery_TypeGroup"));
        public IWebElement FilterGrpVendors => driver.FindElement(By.Id("VendorsGroup"));
        public IWebElement productGridView => driver.FindElement(By.Id("productGridView"));
        public IWebElement productListView => driver.FindElement(By.Id("productListView"));
        public IWebElement productNameFrmDetail => driver.FindElement(By.XPath("//h2[@class='product-title-details']"));
        public IWebElement productSKUFrmDetail => driver.FindElement(By.XPath("//p[@class='sku']"));
        public IWebElement productPriceFrmDetail => driver.FindElement(By.XPath("//span[@class='price']"));
        public IWebElement productDeliveryMethods => driver.FindElement(By.Id("delivery-method"));


        public ProductCatalogPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
             jsonObj = getJson();
        }

 
        public void CheckFilterByCatagories()
        {
            List<string> elementToValidate = new List<string>();
            List<string> txtFrmWebPage = new List<string>();
            string[] filterTypes = { "Media Type", "Purpose", "Line", "Featured", "Product Type", "Page Type", "Delivery Type", "Vendors" };
            elementToValidate.AddRange(filterTypes);
            ReadOnlyCollection<IWebElement> filterByWebElements = driver.FindElements(By.XPath("//a[@class='toggle-link expanded']"));
            //foreach (IWebElement element in filterByWebElements)
            //{
            //    string strFilterByCatagory = element.Text;
            //    txtFrmWebPage.Add(strFilterByCatagory);
            //}
            txtFrmWebPage = getTextFromWebElements(filterByWebElements);
            bool flag = elementToValidate.SequenceEqual(txtFrmWebPage);          
            Assert.IsTrue(flag, "Filter By catagories missing in product catalog page." );
        }

        public void SelectFilterByCatagory(string filterCatagory)
        {
            waitForPageLoad();
            driver.FindElement(By.XPath("//div[@id='facetsCol']//input[@type='checkbox' and @value='" + filterCatagory +"']")).Click();
            waitForPageLoad();
            Assert.IsTrue(ProductsTitleRslt.Displayed, "Product results not displayed after filter catagory selected.");
        }

        public void SelectSortByCatagory(string sortByCatagory)
        {
            waitForPageLoad();
            var selectElement = new SelectElement(ProductsSortByDrpdwn);
            selectElement.SelectByText(sortByCatagory);
            waitForPageLoad();
            Assert.IsTrue(ProductsTitleRslt.Displayed, "Product results not displayed after filter catagory selected.");
        }
        public void AssertSortedProducts(string sortByCatagory)
        {
            List<string> listProductNames = new List<string>();
            List<double> listProductsPrice = new List<double>();
            ReadOnlyCollection<IWebElement> productsWebElements = driver.FindElements(By.XPath("//div[@data-product-id]//a[@class='productLink']"));
            listProductNames = getTextFromWebElements(productsWebElements);
            List<string> beforeMyNameSort = listProductNames.ToList<string>();
            ReadOnlyCollection<IWebElement> productsPriceWebElements = driver.FindElements(By.XPath("//p[@class='price']"));
            //listProductsPrice = getTextFromWebElements(productsPriceWebElements);
            //List<string> listProductsPrice = new List<string>();
            foreach (IWebElement element in productsPriceWebElements)
            {
                string strFilterByCatagory = element.Text.TrimStart('$');
                string price = Regex.Replace(strFilterByCatagory, "[A-Za-z ]", "");
                if (price.Contains("$")) { 
                    price = price.Substring(price.LastIndexOf("$")+1);
                }
                double parsedValue = double.Parse(price);
                listProductsPrice.Add(parsedValue);
            }
            List<double> beforeMyPriceSort = listProductsPrice.ToList<double>();

            switch (sortByCatagory)
            {
                case "Name: A - Z":
                    listProductNames.Sort();
                    bool flag = Enumerable.SequenceEqual(beforeMyNameSort, listProductNames);
                    Assert.IsTrue(flag, "Sort By failed: " + sortByCatagory);
                    break;
                case "Name: Z - A":
                    listProductNames.Sort();
                    listProductNames.Reverse();
                    bool flag2 = Enumerable.SequenceEqual(beforeMyNameSort, listProductNames);
                    Assert.IsTrue(flag2, "Sort By failed: " + sortByCatagory);
                    break;
                case "Price: Low - High":
                    listProductsPrice.Sort();
                    bool flag3 = Enumerable.SequenceEqual(beforeMyPriceSort, listProductsPrice);
                    Assert.IsTrue(flag3, "Sort By failed: " + sortByCatagory);
                    break;
                    
                case "Price: High - Low":
                    listProductsPrice.Sort();
                    listProductsPrice.Reverse();
                    bool flag4 = Enumerable.SequenceEqual(beforeMyPriceSort, listProductsPrice);
                    Assert.IsTrue(flag4, "Sort By failed: " + sortByCatagory);
                    break;
            }
        }

       public void ValidateGridListView()
        {
            waitForPageLoad();
            productGridView.Click();
            waitForPageLoad();
            Assert.IsTrue(driver.FindElement(By.XPath("//div[@id='productList']//div[contains(@class,'gridView') and @data-product-id]")).Displayed, "Failed to view in Grid view");
            productListView.Click();
            waitForPageLoad();
            Assert.IsTrue(driver.FindElement(By.XPath("//div[@id='productList']//div[contains(@class,'productCol') and @data-product-id]")).Displayed, "Failed to view in List view");
        }

        public void NavigateToProduct(string productName)
        {
            waitForPageLoad();
            driver.FindElement(By.XPath("//div[@id='productList']//a[text()='"+productName+ "']")).Click();
            waitForPageLoad();
            Assert.IsTrue(ProductDetailsTitleRslt.Displayed, "Product details page does not displayed");
        }

        public void AssertProductDetails()
        {
            waitForPageLoad();
            Assert.IsTrue(productNameFrmDetail.Displayed, "Product name is not displayed");
            Assert.IsTrue(productSKUFrmDetail.Displayed, "Product name is not displayed");
            Assert.IsTrue(productPriceFrmDetail.Displayed, "Product name is not displayed");
            Assert.IsTrue(productDeliveryMethods.Displayed, "Product name is not displayed");
        }
    }
}
