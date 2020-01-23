# Feature: Admin: Products - Create new print product 
# TestCase JIRA ID: CB-9664
# TestSteps: 1 - 20,
# WrittenBy: Mano Thomson (NL-India)
# Last updated: 21-Oct-2019 

Feature: Administration - Create Product 

@SmokeTest
Scenario: Create a product
	
	Given I have launched the KLIC test site
	When I have logged in with AdminUser
	When Navigate to Administration menu
  Then Navigate to Add/Edit Products from Admin page
  When Add product for type Print
  When Fill General details for Print product
  When Navigate to Images tab
  #Then Upload image for Catalog Thumbnail
  When Navigate to Visibility tab
  Then Fill visiblity details for Print product
  When Navigate to Pricing and Delivery tab
  Then Fill Pricing and Delivery details for Print product
  When Navigate to Customization tab
  Then Fill Customization tab fields for Print product
  Then Save and publish now the product


  Scenario:Refresh and index a created product
  	Given I have launched the KLIC test site
	  When I have logged in with AdminUser
	  When Navigate to Administration menu
    When Navigate to SOLR for index
    Then Refresh the product testAuto3333 for AdminUser
