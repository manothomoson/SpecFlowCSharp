using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace ConductorTest
{
    [Binding]
    public class CorporateFundingManageSteps
    {
        private readonly CorporateFundingManagePage Page;

        public CorporateFundingManageSteps(IWebDriver driver)
        {
            this.Page = new CorporateFundingManagePage(driver);
        }

        [When(@"Navigate to Corporate Funding page")]
        public void WhenNavigateToCorporateFundingSection()
        {
            Page.NavigateToCorporateFundingSection();
        }

        [Then(@"Validate the new tabs in CoFunding page")]
        public void ThenValidateTheNewTabsInCoFundingPage()
        {
            Page.ValidateTheNewTabsInCoFundingPage();
        }

        [When(@"Validate MyFunding Account tab as default view for Non Fund Administrator")]
        public void WhenValidateMyFundingAccountTabAsDefaultViewForNonFundAdministrator()
        {
            Page.ValidateMyFundingAccountTabForNonFundAdmin();
        }

        [When(@"Navigate to Manage Funding tab")]
        public void WhenNavigateToManageFundingTab()
        {
            Page.NavigateToManageFundingTab();
        }

        [Then(@"Validate the sections in manage funding tab")]
        public void ThenValidateTheSectionsInManageFundingTab()
        {
            Page.ValidateManageFundingTabSections();
        }

        [When(@"Validate Total funds Allocated to users in CoFunding Balance section")]
        public void WhenValidateTotalFundsAllocatedToUsersInCoFundingBalanceSection()
        {
            Page.ValidateTotalFundsAllocatedToUsers();
        }
        [Then(@"Validate AddMoreFund, ResetFund and TransferFund buttons")]
        public void ThenValidateAddMoreFundResetFundAndTransferFundButtons()
        {
            Page.ValidateAddMoreFundResetFundAndTransferFundButtons();
        }

        [Then(@"Validate Name search field and label")]
        public void ThenValidateNameSearchFieldAndLabel()
        {
            Page.ValidateNameSearchFieldAndLabel();
        }

        [Then(@"Search for a name (.*) in manage individual funding accounts")]
        public void ThenSearchForANameInManageIndividualFundingAccounts(string NameToSearch)
        {
            Page.SearchForAName(NameToSearch);
        }

        [Then(@"Assert search results matching for (.*)")]
        public void ThenAssertSearchResultsMatching(string NameToAssert)
        {
            Page.AssertSearchResultsMatching(NameToAssert);
        }

        [When(@"Assert column names and tooltips in manage individual funding table")]
        public void WhenAssertColumnNamesAndTooltipMessages()
        {
            Page.AssertColumnNamesAndTooltip();
        }

        [When(@"Check indicator column for activity of the each user")]
        public void WhenCheckIndicatorColumnForActivityOfTheEachUser()
        {
            Page.CheckIndicatorColumn();
        }

        [When(@"Click on the indicator and drilldown to first record of the table")]
        public void ThenClickOnTheIndicatorAndDrilldownToFirstRecordOfTheTable()
        {
            Page.ClickOnTheIndicatorAndDrilldownToFirstRecord();
        }

        [Then(@"Validate the row expaned in light blue and its row details wih dark blue border")]
        public void ThenValidateTheRowExpanedInLightBlueAndItsRowDetailsWihDarkBlueBorder()
        {
            Page.ValidateTheRowExpanedAndDetails();
        }

        [Then(@"Validate the Indicator table columns for user activity")]
        public void ThenValidateTheIndicatorTableColumnsForUserActivity()
        {
           Page.ValidateTheIndicatorTableColumns();
        }

        [Then(@"Validate Username AvailableBalance and CurrentBalance columns and hovers")]
        public void ThenValidateUsernameAvailableBalanceAndCurrentBalanceColumnsAndHovers()
        {
            Page.ValidateUserNameAvailableCurrentBalances();
        }

        [Then(@"Validate Add and Reset links available")]
        public void ThenValidateAddAndResetLinksAvailable()
        {
            Page.ValidateAddAndResetLinksAvailable();
        }

        [When(@"Add balance (.*) to first user record and assert")]
        public void WhenAddBalanceToFirstUserRecord(string amountToAdd)
        {
            Page.AddBalanceToFirstUserRecord(amountToAdd);
        }

        [When(@"Reset balance (.*) to first user record and assert")]
        public void WhenResetBalanceToFirstUserRecordAndAssert(string amountToReset)
        {
            Page.ResetBalanceToFirstUserRecord(amountToReset);
        }


    }
}
