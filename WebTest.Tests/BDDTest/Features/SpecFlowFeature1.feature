Feature: Basket management
	In order to properly bill the customer 
	As site owner
	I need to calculate Basket total price

@mytag
Scenario: calculate delivery cost for a customer basket inférieur 20 € HT
	Given user's empty basket
	And a item wich price 15€ HT
	When I press add
	Then the  total customer basket price should be 21€ TTC

@mytag
Scenario: calculate delivery cost for a customer basket supérieur 20 € HT 
	Given user's empty basket
	And a item wich price 25€ HT
	When I press add
	Then the TTC total customer basket price should be 22€ TTC

@mytag
Scenario: calculate delivery cost for a customer basket égale 20 € HT 
	Given user's empty basket
	And a item wich price 20€ HT
	When I press add
	Then the TTC total customer basket price should be 21€ TTC

@TVAtag
Scenario: Add TVA
	Given I have entered 50 into the cal
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen