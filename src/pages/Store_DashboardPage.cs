using ConductorTest.src.pages;
using ConductorTest.test.support;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;
using System.Threading;

namespace ConductorTest
{
    
    class SF_DashboardPage : Page
    {
        IWebDriver driver;
        public static dynamic jsonObj;
        public IWebElement TxtUserName => driver.FindElement(By.Id("username-email"));
        public IWebElement TxtPassword => driver.FindElement(By.Id("password"));
        public IWebElement BtnLoginSubmit => driver.FindElement(By.Id("login-button"));
        public IWebElement IconShoppingCart => driver.FindElement(By.XPath("//i[@class='fa fa-shopping-cart']"));
        public IWebElement IconCofund => driver.FindElement(By.XPath("//i[@class='glyphicon glyphicon-piggy-bank']"));
        public IWebElement IconProfile => driver.FindElement(By.XPath("//i[@class='fa fa-chevron-circle-down']"));
        public IWebElement LogoKLIC => driver.FindElement(By.XPath("//img[@alt='KLIC']"));
        public IWebElement ProductsMenu => driver.FindElement(By.Id("link-Products2"));
        public IWebElement DashboardMenu => driver.FindElement(By.Id("link-Dashboard1"));
        public IWebElement ContactsMenu => driver.FindElement(By.Id("link-Contacts3"));
        public IWebElement CompaignsMenu => driver.FindElement(By.Id("link-Campaigns4"));
        public IWebElement ReportsMenu => driver.FindElement(By.Id("link-Reports5"));
        public IWebElement ProfileDrpDwn => driver.FindElement(By.Id("profile-dropdown"));
        public IWebElement SignOutLink => driver.FindElement(By.XPath("//li[@class='log-out last']"));
        public IWebElement ProductSearchTxt => driver.FindElement(By.Id("productSearchBox"));
        public IWebElement ProductSearchBtn => driver.FindElement(By.XPath("//span[@class='glyphicon glyphicon-search']"));
        public IWebElement ProductHeroBanner => driver.FindElement(By.Id("layout-featured"));
        public IWebElement ProductFeatured => driver.FindElement(By.Id("first-double-first"));
        public IWebElement ProductCurrentCompaigns => driver.FindElement(By.Id("CurrentCampaignsContainer"));
        public IWebElement ProductNewsFeed => driver.FindElement(By.Id("tripel-first"));
        public IWebElement ProductRecentOrders => driver.FindElement(By.Id("RecentOrdersContainer"));
        public IWebElement ProductFinancialStatement => driver.FindElement(By.XPath("//div[contains(@id='ConductorReports')]"));
        public IWebElement FooterMyTools => driver.FindElement(By.XPath("//div[@id='footer-quad']//h1[contains(text(),'My Tools')]"));
        public IWebElement FooterProducts => driver.FindElement(By.XPath("//div[@id='footer-quad']//h1[contains(text(),'Products')]"));
        public IWebElement FooterCompaigns => driver.FindElement(By.XPath("//div[@id='footer-quad']//h1[contains(text(),'Campaigns')]"));
        public IWebElement FooterContacts => driver.FindElement(By.XPath("//div[@id='footer-quad']//h1[contains(text(),'Contacts')]"));



        //private static string projectPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        //private static string projectDirectory = Directory.GetParent(projectPath).Parent.FullName;
        //public static JObject jsonObject = JObject.Parse(System.IO.File.ReadAllText(projectDirectory + @"\test\resources\prop.json"));

        public SF_DashboardPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            //PageFactory.InitElements(this, new RetryingElementLocator(driver, TimeSpan.FromSeconds(20)));
            //JObject jsonObj = new JObject();
             jsonObj = getJson();
        }
        public void AssertFooterSections()
        {
            bool flag1 = this.FooterMyTools.Displayed;
            bool flag2 = this.FooterProducts.Displayed;
            bool flag3 = this.FooterCompaigns.Displayed;
            bool flag4 = this.FooterContacts.Displayed;
            Assert.IsTrue(flag1 & flag2 & flag3 & flag4,  "Footer section headers is not displayed");
        }
        public void AssertProductsFooterSections()
        {
            Assert.IsTrue(driver.FindElement(By.XPath("//div[@id='footer-quad']//a[contains(text(),'All Products')]")).Displayed, "All Products link missing");
            Assert.IsTrue(driver.FindElement(By.XPath("//div[@id='footer-quad']//a[contains(text(),'Favorites')]")).Displayed, "Favorites link missing");
            Assert.IsTrue(driver.FindElement(By.XPath("//div[@id='footer-quad']//a[contains(text(),'Featured')]")).Displayed, "Featured link missing");
            Assert.IsTrue(driver.FindElement(By.XPath("//div[@id='footer-quad']//a[contains(text(),'Order Approval')]")).Displayed, "Order Approval link missing");

        }
        public void AssertMyToolsFooterSections()
        {
            Assert.IsTrue(driver.FindElement(By.XPath("//div[@id='footer-quad']//a[contains(text(),'Profile')]")).Displayed, "My tools link missing");
            Assert.IsTrue(driver.FindElement(By.XPath("//div[@id='footer-quad']//a[contains(text(),'Assets')]")).Displayed, "Assets link missing");
            Assert.IsTrue(driver.FindElement(By.XPath("//div[@id='footer-quad']//a[contains(text(),'Inbox')]")).Displayed, "Inbox link missing");
            Assert.IsTrue(driver.FindElement(By.XPath("//div[@id='footer-quad']//a[contains(text(),'Funding')]")).Displayed, "Funding link missing");
            Assert.IsTrue(driver.FindElement(By.XPath("//div[@id='footer-quad']//a[contains(text(),'Orders')]")).Displayed, "Orders link missing");
        }
        public void AssertCompaignsFooterSections()
        {
            Assert.IsTrue(driver.FindElement(By.XPath("//div[@id='footer-quad']//a[contains(text(),'My Campaigns')]")).Displayed, "My Campaigns link missing");
            Assert.IsTrue(driver.FindElement(By.XPath("//div[@id='footer-quad']//a[contains(text(),'Corporate Campaigns')]")).Displayed, "Corporate Campaigns link missing");
        }
        public void AssertContactsFooterSections()
        {
            Assert.IsTrue(driver.FindElement(By.XPath("//div[@id='footer-quad']//a[contains(text(),'My Lists')]")).Displayed, "My Lists link missing");
            Assert.IsTrue(driver.FindElement(By.XPath("//div[@id='footer-quad']//a[contains(text(),'My Contacts')]")).Displayed, "My Contacts link missing");
            Assert.IsTrue(driver.FindElement(By.XPath("//div[@id='footer-quad']//a[contains(text(),'Prospecting')]")).Displayed, "Prospecting link missing");
        }


        public void AssertMainMenuWidgets()
        {
            bool flag1 = this.ProductsMenu.Displayed;
            bool flag2 = this.DashboardMenu.Displayed;
            bool flag3 = this.ContactsMenu.Displayed;
            bool flag4 = this.CompaignsMenu.Displayed;
            bool flag5 = this.ReportsMenu.Displayed;
            Assert.IsTrue(flag1&flag2&flag3&flag4&flag5, "Main menu widget for shopping cart is not displayed");
            bool flag6 = this.ProductSearchTxt.Displayed;
            bool flag7 = this.ProductSearchBtn.Displayed;
            Assert.IsTrue(flag6 & flag7 , "Product search form or button is not displayed");
        }

        public void AssertHomePageLayer()
        {
            bool flag1 = ProductHeroBanner.Displayed;
            bool flag2 = ProductFeatured.Displayed;
            bool flag3 = ProductCurrentCompaigns.Displayed;
            bool flag4 = ProductNewsFeed.Displayed;
            bool flag5 = ProductRecentOrders.Displayed;
            Assert.IsTrue(flag1 & flag2 & flag3 & flag4 & flag5, "Home page layer element is not displayed");
        }
        public void LaunchConductorSite()
        {
            string hostURL = (string)jsonObj.Host;
            driver.Url = hostURL;
            driver.Manage().Window.Maximize();    
        }
        public void Login(string userType)
        {
            Thread.Sleep(3000);
            this.waitForPageLoad();            
            this.TxtUserName.SendKeys(jsonObj.Users[userType].UserName.ToString());
            this.TxtPassword.SendKeys(jsonObj.Users[userType].Password.ToString());
            this.BtnLoginSubmit.Click();
            this.waitForPageLoad();
        }

        public void AssertLogo()
        {
            bool flag = LogoKLIC.Displayed;
            Assert.IsTrue(flag, "Logo KLIC is not displayed");
            this.waitForPageLoad();
        }

        public void AssertIcons()
        {
            bool flagCartIcon = this.IconShoppingCart.Displayed;
            Assert.IsTrue(flagCartIcon, "Icon for shopping cart is not displayed");
            bool flagCoFundIcon = this.IconCofund.Displayed;
            Assert.IsTrue(flagCoFundIcon, "Icon for shopping cart is not displayed");
            bool flagProfileIcon = this.IconProfile.Displayed;
            Assert.IsTrue(flagProfileIcon, "Icon for shopping cart is not displayed");
        }
        public void NavigateToProducts()
        {
            WaitForId("link-Products2");
            ProductsMenu.Click();
            waitForPageLoad();
        }
        public void Signout()
        {
            WaitForId("profile-dropdown");
            waitForPageLoad();
            ProfileDrpDwn.Click();
            Thread.Sleep(2000);
            SignOutLink.Click();
            Actions action = new Actions(driver);            
            action.SendKeys(Keys.Escape);
            IAction pressEscape = action.SendKeys(Keys.Escape);
            pressEscape.Perform();
            waitForPageLoad();
        }

        public void SearchProduct(string productDetail)
        {
            WaitForId("productSearchBox");
            ProductSearchTxt.SendKeys(productDetail);
            ProductSearchBtn.Click();
            waitForPageLoad();
        }
       
    }
}
