# Feature: StoreFront -  Order Workflow - Order Confirmation
# TestCase JIRA ID: CB-9615 to CB-9617 (CB-9549)
# TestSteps:All test steps,
# WrittenBy: Mano Thomson (NL-India)
# Last updated: 14-Nov-2019 

Feature: StoreFront - Order Workflow - Order Confirmation

@SmokeTest
Scenario: Order Workflow -  Order Confirmation, Order Detail
	
	Given I have launched the KLIC test site
	When I have logged in with AdminUser
	When navigate to products menu
  When Remove existing items from shopping cart
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
  When Fill one time payment Credit card details for payment
  When Fill billing information new Address
  #When Fill existing Credit card details for payment
  #When Fill billing information exisiting Address
  Then Validate payment breakdown for CreditCard from summary  
  When check Terms of Use check box before placing order
  Then Place the order from payment page
  Then Validate Order number link, thankyou message and disclaimer
  When Navigate from order confirmation page to Order details page
  Then Validate Order detail page elements from product section
  Then Validate Estimated delivery and its elements
  Then Validate payment breakdown modal under Estd delivery and Cost
  Then Validate the order details from order summary panel
  Then Cancel Delivery for estimated section
	Then signout the application
