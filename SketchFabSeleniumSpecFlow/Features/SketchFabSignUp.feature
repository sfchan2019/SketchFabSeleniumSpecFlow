Feature: SketchFabSignUp
	In order to login as a member
	As a user
	I want to be able to sign up for Sketch Fab

Scenario: Sign up without checking privacy policy
	Given I am on the home page
	And I click on the sign up button
	And the sign up window pop up
	When I enter a valid username
	And I enter a valid email
	And I enter a valid password
	And I click the create account button
	Then An error message should appear under privacy policy
