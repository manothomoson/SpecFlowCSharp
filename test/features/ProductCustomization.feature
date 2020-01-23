# Feature: StoreFrontStorefront: Order Workflow - Product Customization
# TestCase JIRA ID: CB-9603 (CB-9626)
# TestSteps: 1 - 10,
# WrittenBy: Mano Thomson (NL-India)
# Last updated: 05-Oct-2019 

Feature: Product Customization - verify customization fields, preview, approve and Continue

@SmokeTest
Scenario: Product Customization - Print Product verify customization fields
	Given I have launched the KLIC test site
	When I have logged in with AdminUser
	When navigate to products menu
  #When Select the filter from catagory Print
  Then search the product TestAuto
  When Navigate to the first product
  Then Navigate from Produt details page to product Customization page
  When Fill product customization fields for Print
  Then Preview and approve from customization
  Then signout the application
