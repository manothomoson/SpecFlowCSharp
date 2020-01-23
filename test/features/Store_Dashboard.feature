# Feature: StoreFront Dashboard - Validating Login and logo, widgets, icons and footer sections  
# TestCase JIRA ID: CB-9618 to CB-9620 
# TestSteps: 1 - 12,
# WrittenBy: Mano Thomson (NL-India)
# Last updated: 10-Oct-2019 

Feature: StoreFront Dashboard
	
@SmokeTest
Scenario: Login and validate dashboard page
	
	Given I have launched the KLIC test site
	When I have logged in with AdminUser
	And assert KLIC logo on upper left corner of the page
	Then assert upper right for shoppingCart, CoFund, Profile icons
	When assert the main menu widgets and product search form
	When assert home page layer
	When assert the footer sections
	When assert MyTools footer section links
	When assert Products footer section links
	When assert Compaigns footer section links
	When assert Contacts footer section links
	Then signout the application

@SmokeTest
Scenario: Login and search a product	
	Given I have launched the KLIC test site
	When I have logged in with AdminUser
	When navigate to products menu
	Then search the product testAuto3333
	Then signout the application
