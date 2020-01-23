# Feature: Storefront: Corporate Funding - Check the new tabs
# TestCase JIRA ID: CB-9771 to CB-9777 
# TestSteps: 1 - 5,
# WrittenBy: Mano Thomson (NL-India)
# Last updated: 25-Nov-2019 

Feature: Storefront: Corporate Funding

@SmokeTest
Scenario: Corporate Funding - Check the new tabs
	Given I have launched the KLIC test site
	When I have logged in with FundAdministrator
  When Navigate to Corporate Funding page
  Then Validate the new tabs in CoFunding page
  

  @SmokeTest
Scenario: Corporate Funding - Validating the default view for Fund Administrator
	Given I have launched the KLIC test site
	When I have logged in with FundAdministrator
  When Navigate to Corporate Funding page
  Then Validate the new tabs in CoFunding page
  #When Validate Manage Funding tab as default view for fund admistrators. -- this step is pending due to the defect.

#  @SmokeTest
#Scenario: Corporate Funding - Validating the default view for Fund Administrator
#	Given I have launched the KLIC test site
#	When I have logged in with NonFundingUser
#  When Navigate to Corporate Funding page
#  Then Validate the new tabs in CoFunding page
#  #When Validate Manage Funding tab as default view for fund admistrators

   @SmokeTest
Scenario: Corporate Funding - Validate default view and Total funds Allocated to users 
	Given I have launched the KLIC test site
	When I have logged in with FundAdministrator
  When Navigate to Corporate Funding page
  #Then Validate the new tabs in CoFunding page  --Need to write seperate code for non fund users
  When Validate MyFunding Account tab as default view for Non Fund Administrator
  When Navigate to Manage Funding tab
  Then Validate the sections in manage funding tab
#Step to check available balance for allocation field from calculation
  When Validate Total funds Allocated to users in CoFunding Balance section


  @SmokeTest
Scenario: Corporate Funding - Validate Add, reset and transfer fund buttons
	Given I have launched the KLIC test site
	When I have logged in with AdminUser
  When Navigate to Corporate Funding page
  When Navigate to Manage Funding tab
  Then Validate AddMoreFund, ResetFund and TransferFund buttons

#---------------------------------------Manage Funding tab (CB-8910)---------------------------------------------

@SmokeTest
Scenario: Manage Funding tab - Check Search feature in Manage Individual Funding Account
	Given I have launched the KLIC test site
	When I have logged in with FundAdministrator
  When Navigate to Corporate Funding page
  When Navigate to Manage Funding tab
  Then Validate Name search field and label
  When Assert column names and tooltips in manage individual funding table
  Then Search for a name Mano in manage individual funding accounts
  Then Assert search results matching for Mano

 @SmokeTest
Scenario: Manage Funding tab - Check Indicator for User Activity in search result table
	Given I have launched the KLIC test site
	When I have logged in with FundAdministrator
  When Navigate to Corporate Funding page
  When Navigate to Manage Funding tab
  Then Validate Name search field and label
  When Assert column names and tooltips in manage individual funding table
  Then Validate Username AvailableBalance and CurrentBalance columns and hovers
  Then Search for a name Mano in manage individual funding accounts
  When Check indicator column for activity of the each user
  When Click on the indicator and drilldown to first record of the table
  Then Validate the row expaned in light blue and its row details wih dark blue border
  Then Validate the Indicator table columns for user activity

  @SmokeTest
Scenario: Manage Funding tab - Check Add action and add balance to user
	Given I have launched the KLIC test site
	When I have logged in with FundAdministrator
  When Navigate to Corporate Funding page
  When Navigate to Manage Funding tab
  Then Validate Name search field and label
  Then Search for a name Mano Thomson in manage individual funding accounts
  Then Validate Add and Reset links available
  When Add balance 10 to first user record and assert


  @SmokeTest
Scenario: Manage Funding tab - Check Reset action and reset balance to user
	Given I have launched the KLIC test site
	When I have logged in with FundAdministrator
  When Navigate to Corporate Funding page
  When Navigate to Manage Funding tab
  Then Validate Name search field and label
  Then Search for a name Mano Thomson in manage individual funding accounts
  Then Validate Add and Reset links available
  When Reset balance 5 to first user record and assert
