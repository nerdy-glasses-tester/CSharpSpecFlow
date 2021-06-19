Feature: SignUp
	In order to use the benefit on the website
	I will need to first sign up

@mytag
Scenario: Valid Sign Up
	Given I navigate to the website
	And I enter my username
	And I enter my email
	And I enter my password
	When I click on Sign Up
	Then I should be able to register successfully