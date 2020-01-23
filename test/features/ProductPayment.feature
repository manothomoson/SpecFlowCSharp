# Feature: StoreFront -  Order Workflow - Payment
# TestCase JIRA ID: CB-9614 - (CB-9542 to CB-9548)
# TestSteps: All Steps,
# WrittenBy: Mano Thomson (NL-India)
# Last updated: 11-Nov-2019 

Feature: StoreFront - Product Payment Page and Options

@SmokeTest
Scenario: Order Workflow -  Payment
	
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
  #Then Validate product details from cart section
  Then Validate estimated Delivery and Cost section
  When Add General Ledger code to the product
  When Add Product NickName TestNickName to the product
  Then Navigate from Shopping cart page to Payment page
  Then Validate payment methods available
  Then Validate payment summary section
  When Fill existing Credit card details for payment
  When Fill billing information exisiting Address
  Then Validate payment breakdown for CreditCard from summary  
  When check Terms of Use check box before placing order
  Then Place the order from payment page
	Then signout the application

@SmokeTest
Scenario: Order Workflow -  Payment(Credit card - OneTime Payment)
	
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
  #Then Validate product details from cart section
  Then Validate estimated Delivery and Cost section
  When Add General Ledger code to the product
  When Add Product NickName TestNickName to the product
  Then Navigate from Shopping cart page to Payment page
  Then Validate payment methods available
  Then Validate payment summary section
  Then Validate security code message hint
  Then Validate Payment profile message hint
  When Fill one time payment Credit card details for payment
  When Fill billing information new Address
  When check Terms of Use check box before placing order
  Then Place the order from payment page
	Then signout the application
 
 @SmokeTest
Scenario: Order Workflow -  Payment(Existing Credit card Payment and billing address)
	
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
  #Then Validate product details from cart section
  Then Validate estimated Delivery and Cost section
  When Add General Ledger code to the product
  When Add Product NickName TestNickName to the product
  Then Navigate from Shopping cart page to Payment page
  Then Validate payment methods available
  Then Validate payment summary section
  Then Validate security code message hint
  Then Validate Payment profile message hint
  When Fill existing Credit card details for payment
  When Fill billing information exisiting Address
  When check Terms of Use check box before placing order
  Then Place the order from payment page
	Then signout the application

@SmokeTest
Scenario: Order Workflow -  Payment(Invoice)
	
	Given I have launched the KLIC test site
	When I have logged in with AdminUser
	When navigate to products menu
	Then search the product testAuto3333
  When Navigate to the product testAuto3333
  Then Navigate from Produt details page to product Customization page
  # When Fill product customization fields for Print
  #Then Preview and approve from customization
  When Fill Delivery Options page details for ShipToAnAddress
  Then Navigate from Delivery Options page to Shopping cart page
  Then Validate cart summary section
  #Then Validate product details from cart section
  Then Validate estimated Delivery and Cost section
  When Add General Ledger code to the product
  When Add Product NickName TestNickName to the product
  Then Navigate from Shopping cart page to Payment page
  When Navigate to Invoice payment method
  Then Validate Invoice amount to be paid
  Then Validate payment breakdown for Invoice from summary
  When check Terms of Use check box before placing order
  Then Place the order from payment page
	Then signout the application

@SmokeTest
Scenario: Order Workflow -  Payment(CoFunding)
	
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
  #Then Validate product details from cart section
  Then Validate estimated Delivery and Cost section
  When Add General Ledger code to the product
  When Add Product NickName TestNickName to the product
  Then Navigate from Shopping cart page to Payment page
  When Navigate to Cofunding payment method
  Then Validate Cofunding amount to be paid
  Then Validate payment breakdown for CoFunding from summary
  When check Terms of Use check box before placing order
  Then Place the order from payment page
	Then signout the application

@SmokeTest
Scenario: Order Workflow -  Payment(CoFunding with existing credit card and existing billing info)
	
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
  #Then Validate product details from cart section
  Then Validate estimated Delivery and Cost section
  When Add General Ledger code to the product
  When Add Product NickName TestNickName to the product
  Then Navigate from Shopping cart page to Payment page
  When Navigate to CofundingAndCreditCard payment method
  When Fill Cofunding amount with credit card payment
  When Fill existing Credit card details for payment
  When Fill billing information exisiting Address
  Then Validate payment breakdown for CoFundingAndCreditCard from summary
  When check Terms of Use check box before placing order
  Then Place the order from payment page
	Then signout the application

@SmokeTest
Scenario: Order Workflow -  Payment(CoFunding with Invoice)
	
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
  #Then Validate product details from cart section
  Then Validate estimated Delivery and Cost section
  When Add General Ledger code to the product
  When Add Product NickName TestNickName to the product
  Then Navigate from Shopping cart page to Payment page
  When Navigate to CofundingAndInvoice payment method
  When Fill Cofunding amount with Invoice payment
  Then Validate payment breakdown for CoFundingAndInvoice from summary
  When check Terms of Use check box before placing order
  Then Place the order from payment page
	Then signout the application
