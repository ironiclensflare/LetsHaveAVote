Feature: Poll
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have then entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

Scenario: Add two more numbers
	Given I have entered 90 into the calculator
	And I have then entered 80 into the calculator
	When I press add
	Then the result should be 170 on the screen

Scenario: Add another two numbers
	Given I have entered 1 into the calculator
	And I have then entered 8 into the calculator
	When I press add
	Then the result should be 9 on the screen