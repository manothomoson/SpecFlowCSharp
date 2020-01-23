# Feature: StoreFront - Product Delivery Options - Validating different types of delivery options
# TestCase JIRA ID: CB-9604, CB-9605, CB-9606 -  (CB-9527)
# TestSteps: All Steps,
# WrittenBy: Mano Thomson (NL-India)
# Last updated: 20-Oct-2019 

Feature: StoreFront - Product Delivery Options
	
@SmokeTest
Scenario: Order Workflow - Delivery Options (Shipping to an Address)
	
	Given I have launched the KLIC test site
	When I have logged in with AdminUser
	When navigate to products menu
	Then search the product testAuto3333
  When Navigate to the product testAuto3333
  Then Navigate from Produt details page to product Customization page
  When Fill Delivery Options page details for ShipToAnAddress
  Then Navigate from Delivery Options page to Shopping cart page
	Then signout the application

@SmokeTest
Scenario: Order Workflow - Delivery Options (Mail to Recipient List)
	
	Given I have launched the KLIC test site
	When I have logged in with AdminUser
	When navigate to products menu
	Then search the product testAuto3333
  When Navigate to the product testAuto3333
  Then Navigate from Produt details page to product Customization page
  When Fill Delivery Options page details for MailToRecipientList
  Then Navigate from Delivery Options page to Shopping cart page
	Then signout the application

@SmokeTest
Scenario: Order Workflow - Delivery Options (Download)
	
	Given I have launched the KLIC test site
	When I have logged in with AdminUser
	When navigate to products menu
	Then search the product testAuto3333
  When Navigate to the product testAuto3333
  Then Navigate from Produt details page to product Customization page
  When Fill Delivery Options page details for Download
  Then Navigate from Delivery Options page to Shopping cart page
	Then signout the application
