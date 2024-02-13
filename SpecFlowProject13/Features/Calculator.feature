Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProject13/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Add two numbers
	Given the first number is 70
	And the second number is 50
	When the two numbers are added
	Then the result should be 120

@mytag
Scenario: Sub two numbers
	Given the first number is 70
	And the second number is 50
	When the two numbers are sub
	Then the result should be 20

@mytag
Scenario: Mul two numbers
	Given the first number is 70
	And the second number is 50
	When the two numbers are mul
	Then the result should be 350

@mytag
Scenario: Div two numbers
	Given the first number is 70
	And the second number is 50
	When the two numbers are div
	Then the result should be 14