# Feature: StoreFront -  Order Workflow - Shopping Cart
# TestCase JIRA ID: CB-9607 to CB-9613 - (CB-9530)
# TestSteps: All Steps,
# WrittenBy: Mano Thomson (NL-India)
# Last updated: 4-Nov-2019 

Feature: StoreFront - Product Shopping Cart
	
@SmokeTest
Scenario: Order Workflow -  Product Shopping Cart
	
	Given I have launched the KLIC test site
	When I have logged in with AdminUser
  When Remove existing items from shopping cart
	When navigate to products menu
	Then search the product testAuto3333
  When Navigate to the product testAuto3333
  Then Navigate from Produt details page to product Customization page
  # When Fill product customization fields for Print
  #Then Preview and approve from customization
  When Fill Delivery Options page details for ShipToAnAddress
  Then Navigate from Delivery Options page to Shopping cart page
  Then Validate cart summary section
  Then Validate product details from cart section
  Then Validate estimated Delivery and Cost section
  When Add General Ledger code to the product
  When Add Product NickName TestNickName to the product
  Then Navigate from Shopping cart page to Payment page
	Then signout the application

@SmokeTest
Scenario: Order Workflow -  Product Shopping Cart (Edit Button)
	 
	Given I have launched the KLIC test site
	When I have logged in with AdminUser
  When Remove existing items from shopping cart
	When navigate to products menu
	Then search the product testAuto3333
  When Navigate to the product testAuto3333
  Then Navigate from Produt details page to product Customization page
  # When Fill product customization fields for Print
  #Then Preview and approve from customization
  When Fill Delivery Options page details for ShipToAnAddress
  Then Navigate from Delivery Options page to Shopping cart page
  When Get current item count from cart
  When Edit product from the shopping cart page
  Then Navigate from Produt details page to product Customization page
  When Update Delivery Options page details for MailToRecipientList
  Then Navigate from Delivery Options page to Shopping cart page  
  Then Validate cart summary section
  Then Validate product details from cart section
  Then Validate cart count after edit product

@SmokeTest
Scenario: Order Workflow -  Product Shopping Cart (Copy Button)
	 
	Given I have launched the KLIC test site
	When I have logged in with AdminUser
  When Remove existing items from shopping cart
	When navigate to products menu
	Then search the product testAuto3333
  When Navigate to the product testAuto3333
  Then Navigate from Produt details page to product Customization page
  # When Fill product customization fields for Print
  #Then Preview and approve from customization
  When Fill Delivery Options page details for ShipToAnAddress
  Then Navigate from Delivery Options page to Shopping cart page
  When Get current item count from cart
  Then Validate cart summary section
  When Copy product from the shopping cart page
  Then Navigate from Produt details page to product Customization page
  When Update Delivery Options page details for ShipToAnAddress
  Then Navigate from Delivery Options page to Shopping cart page
  Then Validate cart summary section
  Then Validate product details from cart section
  Then Validate cart items after copy the product

 @SmokeTest
 Scenario: Order Workflow -  Product Shopping Cart (Save for Later Button)
	 
	Given I have launched the KLIC test site
	When I have logged in with AdminUser
  When Remove existing items from shopping cart
	When navigate to products menu
	Then search the product testAuto3333
  When Navigate to the product testAuto3333
  Then Navigate from Produt details page to product Customization page
  # When Fill product customization fields for Print
  #Then Preview and approve from customization
  When Fill Delivery Options page details for ShipToAnAddress
  Then Navigate from Delivery Options page to Shopping cart page
  Then Validate cart summary section
  When Get current item count from cart
  When Save for Later product from the shopping cart page
  Then Validate copy, remove, add to cart button of Save Later section
  Then Validate cart count after Save a product for Later

  @SmokeTest
 Scenario: Order Workflow -  Product Shopping Cart (Remove Button)
	 
	Given I have launched the KLIC test site
	When I have logged in with AdminUser
  When Remove existing items from shopping cart
	When navigate to products menu
	Then search the product testAuto3333
  When Navigate to the product testAuto3333
  Then Navigate from Produt details page to product Customization page
  # When Fill product customization fields for Print
  #Then Preview and approve from customization
  When Fill Delivery Options page details for ShipToAnAddress
  Then Navigate from Delivery Options page to Shopping cart page
  Then Validate cart summary section
  When Get current item count from cart
  When Remove the product from the cart
  Then Validate cart count after removing a product

