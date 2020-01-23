# Feature: StoreFrontStorefront: Order Workflow - Product Catalog 
# TestCase JIRA ID: CB-9602 (CB-9515)
# TestSteps: 1 - 11,
# WrittenBy: Mano Thomson (NL-India)
# Last updated: 25-Sep-2019 

Feature: Product Catalog - Search a product, Validate filters and Sort

@SmokeTest
Scenario: Product catalog - Validate filter and Sort by Name: A - Z
	Given I have launched the KLIC test site
	When I have logged in with AdminUser
	When navigate to products menu
  Then Check Filter By catagories
  When Select the filter from catagory Email
  When Sort the products by Name: A - Z
  Then Assert the products sorted in Name: A - Z
  
@SmokeTest
Scenario: Product catalog - Validate filter and Sort by Name: Z - A
	Given I have launched the KLIC test site
	When I have logged in with AdminUser
	When navigate to products menu
  Then Check Filter By catagories
  When Select the filter from catagory Email
  When Sort the products by Name: Z - A
  Then Assert the products sorted in Name: Z - A

@SmokeTest
Scenario: Product catalog - Validate filter and  Sort by Price: Low - High
	Given I have launched the KLIC test site
	When I have logged in with AdminUser
	When navigate to products menu
  Then Check Filter By catagories
  When Select the filter from catagory Email
  When Sort the products by Price: Low - High
  Then Assert the products sorted in Price: Low - High

@SmokeTest
Scenario: Product catalog - Validate filter and Sort by Price: High - Low
	Given I have launched the KLIC test site
	When I have logged in with AdminUser
	When navigate to products menu
  Then Check Filter By catagories
  When Select the filter from catagory Email
  When Sort the products by Price: High - Low
  Then Assert the products sorted in Price: High - Low

@SmokeTest
Scenario: Product catalog - Validate Grid, List view and product details
	Given I have launched the KLIC test site
	When I have logged in with AdminUser
	When navigate to products menu
  When Validate Grid view and List view icons
  #When Navigate to the product 0 Email
  Then search the product testAuto3333
  When Navigate to the product testAuto3333
  Then Assert product details thumbnail, name, SKU, delivery methods and Price
