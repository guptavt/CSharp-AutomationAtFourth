Feature: Engage -- Login -- A
	As an Engage user
	I expect to have basic login functionality
	So that I can make use of the provided apps and services

	@smoke
	Scenario: Login with valid credentials
		Given I log in with valid credentials
		Then I see the Hamburger Menu button

	@smoke
	Scenario: Login with blank credentials
		Given I log in with blank credentials
		Then I see the blank credentials error message

	@smoke
	Scenario: Login with invalid credentials
		Given I log in with invalid credentials
		Then I see the invalid credentials error message