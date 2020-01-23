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
    
    class CorporateFundingManagePage : Page
    {
        IWebDriver driver;
        public static dynamic jsonObj;

        public CorporateFundingManagePage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            jsonObj = getJson();
        }
        public IWebElement CorporateFundingTitleRslt => driver.FindElement(By.XPath("//h1[@id='pageTitle' and contains(text(),'Corporate Funding')]"));
        public IWebElement ManageFundingTab => driver.FindElement(By.XPath("//div[@class='row hidden-xs hidden-sm']//a[contains(@href,'CorporateFundHistory')]"));
        public IWebElement MyFundingAccountTab => driver.FindElement(By.XPath("//div[@class='row hidden-xs hidden-sm']//a[contains(@href,'AccountSummary')]"));
        public IWebElement MyFundHistoryTab => driver.FindElement(By.XPath("//div[@class='row hidden-xs hidden-sm']//a[contains(@href,'FundingHistory')]"));
        public IWebElement CoFundingBtn => driver.FindElement(By.Id("linkCofunding"));

        //Manage Funding
        public IWebElement CorporateFundingBalanceSection => driver.FindElement(By.XPath("//h3[text()='Corporate Funding Balance']"));
        public IWebElement ManageMultipleFundingAccountsSection => driver.FindElement(By.XPath("//h3[text()='Manage Multiple Funding Accounts']"));
        public IWebElement ManageIndividualFundingAccountsSection => driver.FindElement(By.XPath("//h3[text()='Manage Individual Funding Accounts']"));
        public IWebElement AvailableBalanceForAllocation => driver.FindElement(By.Id("AvailableBalance"));
        public IWebElement TotalFundAllocatedToUsers => driver.FindElement(By.Id("FundAllocatedToUsers"));
        public IWebElement AddMoreFundsBtn => driver.FindElement(By.XPath("//a[contains(.,'Add More Funds')]"));
        public IWebElement ResetFundsBtn => driver.FindElement(By.XPath("//a[contains(.,'Reset Funds')]"));
        public IWebElement TransferFundsBtn => driver.FindElement(By.XPath("//a[contains(.,'Transfer Funds')]")); 
        public IWebElement MyFundingAccountTabActive => driver.FindElement(By.XPath("//div[@class='row hidden-xs hidden-sm']//a[contains(@href,'AccountSummary')]/parent::li[contains(@class,'active')]"));

        //Manage Individual Funding Accounts
        public IWebElement NameSearchResultTable => driver.FindElement(By.XPath("//table[@id='grid']"));
        public IWebElement SearchNameTxt => driver.FindElement(By.Id("SearchName"));
        public IWebElement NameLabel => driver.FindElement(By.XPath("//label[text()='Name']"));
        public IWebElement SearchBtn => driver.FindElement(By.Id("SearchHistoryButton"));
        public IWebElement UserColumnLink => driver.FindElement(By.XPath("//table[@id='grid']//div[contains(text(),'USER')]"));
        public IWebElement AvailableBalanceColumnLink => driver.FindElement(By.XPath("//table[@id='grid']//div[contains(text(),'AVAILABLE BALANCE')]"));
        public IWebElement CurrentBalanceColumnLink => driver.FindElement(By.XPath("//table[@id='grid']//div[contains(text(),'CURRENT BALANCE')]"));
        public IWebElement ToolTipAvailableBalance => driver.FindElement(By.XPath("//span[@data-toggle='tooltip' and @data-original-title='Your current balance minus any orders not yet fulfilled.' ]"));
        public IWebElement ToolTipCurrentBalance => driver.FindElement(By.XPath("//span[@data-toggle='tooltip' and @data-original-title='The total amount of funds in your account.' ]"));

        public IWebElement AvailableBalanceFirstRowValue => driver.FindElement(By.XPath("//table[@id='grid']//tr[@data-position=1]/td[4]/div"));
        public IWebElement CurrentBalanceFirstRowValue => driver.FindElement(By.XPath("//table[@id='grid']//tr[@data-position=1]/td[5]/div"));
        public IWebElement UserNameFirstRowValue => driver.FindElement(By.XPath("//table[@id='grid']//tr[@data-position=1]/td[3]/div"));
        public IWebElement AddBalanceActionBtn => driver.FindElement(By.XPath("//i[@class='fa fa-plus-circle gj-cursor-pointer' and text()=' Add']"));
        public IWebElement ResetBalanceActionBtn => driver.FindElement(By.XPath("//i[@class='fa fa-repeat gj-cursor-pointer' and text()=' Reset']"));
        public IWebElement AddBalaceEditBox => driver.FindElement(By.XPath("//div[@id='editorDiv' and @style='']//input[@name='addBalance']"));
        public IWebElement ResetBalaceEditBox => driver.FindElement(By.XPath("//div[@id='editorDiv' and @style='']//input[@name='resetBalance']"));
        public IWebElement GreenTickBtn => driver.FindElement(By.XPath("//i[@class='fa fa-check-circle gj-cursor-pointer' and @style='color:green']"));
        public IWebElement RedTickBtn => driver.FindElement(By.XPath("//i[@class='fa fa-times-circle gj-cursor-pointer' and @style='color:red']"));
        public IWebElement AmountAddedInfoMsg => driver.FindElement(By.XPath("//div[contains(@class,'Information alert') and @style='']//span[@class='message-Message' and contains(text(),'has been added to')]"));
        public IWebElement AmountResetInfoMsg => driver.FindElement(By.XPath("//div[contains(@class,'Information alert') and @style='']//span[@class='message-Message' and contains(text(),'account reset to')]"));


        //public IWebElement 

        public IWebElement IndicatorForUserActionsDefault => driver.FindElement(By.XPath("//i[@class='fa fa-chevron-circle-right']"));
        public IWebElement IndicatorForUserActionsExpanded => driver.FindElement(By.XPath("//i[@class='fa fa-chevron-circle-down']"));
        public IWebElement ExpandedRowInLightBlueBGClr => driver.FindElement(By.XPath("//tr[@style='background-color: rgb(151, 224, 235);']"));
        public IWebElement ExpandedRowDarkBlueBorder => driver.FindElement(By.XPath("//tr[@style='border: 3px solid rgb(0, 184, 255);']"));
        //User activity Table
        public IWebElement DateColumn=> driver.FindElement(By.XPath("//div[text()='DATE']"));
        public IWebElement ReferenceColumn => driver.FindElement(By.XPath("//div[text()='REFERENCE']"));
        public IWebElement ActivityColumn => driver.FindElement(By.XPath("//div[text()='ACTIVITY']"));
        public IWebElement InitiatedByColumn => driver.FindElement(By.XPath("//div[text()='INITIATED BY']"));
        public IWebElement AmountAddedColumn => driver.FindElement(By.XPath("//div[text()='AMOUNT ADDED']"));
        public IWebElement AmountUsedColumn => driver.FindElement(By.XPath("//div[text()='AMOUNT USED']"));
        public IWebElement BalanceColumn => driver.FindElement(By.XPath("//div[text()='BALANCE']"));


        public void NavigateToCorporateFundingSection()
        {
            waitForPageLoad();
            CoFundingBtn.Click();
            waitForPageLoad();
            Assert.IsTrue(CorporateFundingTitleRslt.Displayed, "Page not navigated to CoFunding page");
        }

        public void ValidateTheNewTabsInCoFundingPage()
        {
            Assert.IsTrue(ManageFundingTab.Displayed, "ManageFundingTab is not displayed");
            Assert.IsTrue(MyFundingAccountTab.Displayed, "MyFundingAccountTab is not displayed");
            Assert.IsTrue(MyFundHistoryTab.Displayed, "MyFundHistoryTab is not displayed");
        }

        public void ValidateMyFundingAccountTabForNonFundAdmin()
        {
            waitForPageLoad();
            Assert.IsTrue(MyFundingAccountTabActive.Displayed, "My funding account is not default view for non admin user");
        }

        public void NavigateToManageFundingTab()
        {
            waitForPageLoad();
            ManageFundingTab.Click();            
        }

        public void ValidateManageFundingTabSections()
        {
            Assert.IsTrue(CorporateFundingBalanceSection.Displayed, "CorporateFundingBalanceSection is not displayed");
            Assert.IsTrue(ManageMultipleFundingAccountsSection.Displayed, "ManageMultipleFundingAccountsSection is not displayed");
            Assert.IsTrue(ManageIndividualFundingAccountsSection.Displayed, "ManageIndividualFundingAccountsSection is not displayed");
        }

        public void ValidateTotalFundsAllocatedToUsers()
        {
            Assert.IsTrue(TotalFundAllocatedToUsers.Displayed, "TotalFundAllocatedToUsers is not displayed");

        }
        public void ValidateAddMoreFundResetFundAndTransferFundButtons()
        {
            Assert.IsTrue(AddMoreFundsBtn.Displayed, "AddMoreFundsBtn is not displayed");
            Assert.IsTrue(ResetFundsBtn.Displayed, "ResetFundsBtn is not displayed");
            Assert.IsTrue(TransferFundsBtn.Displayed, "TransferFundsBtn is not displayed");
        }

        public void ValidateNameSearchFieldAndLabel()
        {
            IJavaScriptExecutor je = (IJavaScriptExecutor)driver;
            je.ExecuteScript("arguments[0].scrollIntoView(true);", NameLabel);
            Assert.IsTrue(NameLabel.Displayed, "Label Name is not displayed");
            Assert.IsTrue(SearchNameTxt.Displayed, "Name text field is not displayed");
        }

        public void SearchForAName(string NameToSearch)
        {
            SearchNameTxt.SendKeys(NameToSearch);
            SearchBtn.Click();
        }

        public void AssertSearchResultsMatching(string nameToAssert)
        {
            waitForPageLoad();
            Assert.IsTrue(NameSearchResultTable.Displayed, "NameSearchResultTable is not displayed");
            nameToAssert = nameToAssert.ToLower();

            var elements = driver.FindElements(By.XPath("//table[@id='grid']//tr//td[not (contains(@style,'display: none;'))]//div[@title]"));
            foreach (var item in elements)
            {
                string nameFromTable = item.Text;
                nameFromTable = nameFromTable.ToLower();
                Assert.IsTrue((nameFromTable.Contains(nameToAssert)), "Searched name were not matched");
            }

        }

        public void AssertColumnNamesAndTooltip()
        {
            Assert.IsTrue(UserColumnLink.Displayed, "UserColumnLink is not displayed");
            Assert.IsTrue(AvailableBalanceColumnLink.Displayed, "AvailableBalanceColumnLink is not displayed");
            Assert.IsTrue(CurrentBalanceColumnLink.Displayed, "CurrentBalanceColumnLink is not displayed");
            Assert.IsTrue(ToolTipAvailableBalance.Displayed, "ToolTipAvailableBalance is not displayed");
            Assert.IsTrue(ToolTipCurrentBalance.Displayed, "ToolTipCurrentBalance is not displayed");
        }

        public void CheckIndicatorColumn()
        {
            waitForPageLoad();
            Assert.IsTrue(IndicatorForUserActionsDefault.Displayed, "Indicator For User Actions are not displayed");
        }

        public void ClickOnTheIndicatorAndDrilldownToFirstRecord()
        {
            IndicatorForUserActionsDefault.Click();
            waitForPageLoad();
        }

        public void ValidateTheRowExpanedAndDetails()
        {
            Assert.IsTrue(IndicatorForUserActionsExpanded.Displayed, "UserColumnLink is not displayed");
            Assert.IsTrue(ExpandedRowInLightBlueBGClr.Displayed, "UserColumnLink is not displayed");
            Assert.IsTrue(ExpandedRowDarkBlueBorder.Displayed, "UserColumnLink is not displayed");
        }

        public void ValidateTheIndicatorTableColumns()
        {
            Assert.IsTrue(ActivityColumn.Displayed, "ActivityColumn is not displayed");
            Assert.IsTrue(DateColumn.Displayed, "DateColumn is not displayed");
            Assert.IsTrue(ReferenceColumn.Displayed, "ReferenceColumn is not displayed");
            Assert.IsTrue(InitiatedByColumn.Displayed, "InitiatedByColumn is not displayed");
            Assert.IsTrue(AmountAddedColumn.Displayed, "AmountAddedColumn is not displayed");
            Assert.IsTrue(AmountUsedColumn.Displayed, "AmountUsedColumn is not displayed");
            Assert.IsTrue(BalanceColumn.Displayed, "BalanceColumn is not displayed");
        }

        public void ValidateUserNameAvailableCurrentBalances()
        {
            Assert.IsTrue(UserNameFirstRowValue.Displayed, "User Name is not displayed");
            Assert.IsTrue(AvailableBalanceFirstRowValue.Displayed, "Available Balance is not displayed");
            Assert.IsTrue(CurrentBalanceFirstRowValue.Displayed, "Current Balance is not displayed");
            Actions action = new Actions(driver);
            action.MoveToElement(ToolTipAvailableBalance).Perform();
            Thread.Sleep(1000);
            Assert.IsTrue(driver.FindElement(By.XPath("//div[@class='tooltip fade top in']//div[text()='Your current balance minus any orders not yet fulfilled.']")).Displayed, "Tool tip for available balance hover is not displayed");            
            action.MoveToElement(ToolTipCurrentBalance).Perform();
            Thread.Sleep(1000);
            Assert.IsTrue(driver.FindElement(By.XPath("//div[@class='tooltip fade top in']//div[text()='The total amount of funds in your account.']")).Displayed, "Tool tip hover for current balance is not displayed");

        }

        public void ValidateAddAndResetLinksAvailable()
        {
            Assert.IsTrue(AddBalanceActionBtn.Displayed, "Add Balance Link is not displayed");
            Assert.IsTrue(ResetBalanceActionBtn.Displayed, "Reset Balance link is not displayed");
        }

        public void AddBalanceToFirstUserRecord(string amountToAdd)
        {
            waitForPageLoad();
            AddBalanceActionBtn.Click();
            Assert.IsTrue(AddBalaceEditBox.Displayed, "Add Balace Edit Box is not displayed");
            Assert.IsFalse(AddBalanceActionBtn.Displayed, "Add Balance Link is  displayed");
            Assert.IsFalse(ResetBalanceActionBtn.Displayed, "Reset Balance Link is  displayed");
            AddBalaceEditBox.SendKeys(amountToAdd);
            RedTickBtn.Click();
            this.ValidateAddAndResetLinksAvailable();
            string availBalanceBeforeAdd = AvailableBalanceFirstRowValue.Text;
            double availBalB4Add = Double.Parse(availBalanceBeforeAdd.Substring(2));
            string CurrentBalanceBeforeAdd = CurrentBalanceFirstRowValue.Text;
            double currentBalB4Add = Double.Parse(CurrentBalanceBeforeAdd.Substring(2));
            AddBalanceActionBtn.Click();
            AddBalaceEditBox.SendKeys(amountToAdd);
            GreenTickBtn.Click();
            waitForPageLoad();
            Assert.IsTrue(AmountAddedInfoMsg.Displayed, "Amount not added successfully");
            double AmountAdded = Double.Parse(amountToAdd);
            string AvailBalanceAfterAdd = AvailableBalanceFirstRowValue.Text;
            string CurrentBalanceAfterAdd = CurrentBalanceFirstRowValue.Text;
            double intAvailBalanceAfterAdd = Double.Parse(AvailBalanceAfterAdd.Substring(2));
            double intCurrentBalanceAfterAdd = Double.Parse(CurrentBalanceAfterAdd.Substring(2));
            double differenceCurrent = intCurrentBalanceAfterAdd - currentBalB4Add;
            double differenceAvail = intAvailBalanceAfterAdd - availBalB4Add;
            Assert.AreEqual(differenceCurrent, AmountAdded);
            Assert.AreEqual(differenceAvail, AmountAdded);
        }

        public void ResetBalanceToFirstUserRecord(string amountToReset)
        {
            waitForPageLoad();

            ResetBalanceActionBtn.Click();
            Assert.IsTrue(ResetBalaceEditBox.Displayed, "Add Balace Edit Box is not displayed");
            Assert.IsFalse(AddBalanceActionBtn.Displayed, "Add Balance Link is  displayed");
            Assert.IsFalse(ResetBalanceActionBtn.Displayed, "Reset Balance Link is  displayed");
            ResetBalaceEditBox.SendKeys(amountToReset);
            RedTickBtn.Click();
            this.ValidateAddAndResetLinksAvailable();
            string availBalanceBeforeReset = AvailableBalanceFirstRowValue.Text;
            double availBalB4Reset = Double.Parse(availBalanceBeforeReset.Substring(2));
            string CurrentBalanceBeforeReset = CurrentBalanceFirstRowValue.Text;
            double currentBalB4Reset = Double.Parse(CurrentBalanceBeforeReset.Substring(2));

            ResetBalanceActionBtn.Click();
            ResetBalaceEditBox.SendKeys(amountToReset);
            GreenTickBtn.Click();
            waitForPageLoad();
            Assert.IsTrue(AmountResetInfoMsg.Displayed, "Amount had not reset successfully");
            double AmountOfReset = Double.Parse(amountToReset);

            string AvailBalanceAfterReset= AvailableBalanceFirstRowValue.Text;
            string CurrentBalanceAfterReset = CurrentBalanceFirstRowValue.Text;
            double intAvailBalanceAfterReset = Double.Parse(AvailBalanceAfterReset.Substring(2));
            double intCurrentBalanceAfterReset = Double.Parse(CurrentBalanceAfterReset.Substring(2));

            Assert.AreEqual(intAvailBalanceAfterReset, AmountOfReset);
            double updatedCurrBal = currentBalB4Reset + (AmountOfReset - availBalB4Reset);
            Assert.AreEqual(intCurrentBalanceAfterReset, updatedCurrBal);
        }
    }
}
