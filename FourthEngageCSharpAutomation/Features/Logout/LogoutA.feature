Feature: Engage -- Logout -- A
	As an Engage user
	I expect to have basic logout functionality
	So that I can close my current app session

	@smoke
	Scenario: Logout and cancelling the modal
		Given I log in with valid credentials
		When I click the "Sign Out" side panel button
		And I click the "Cancel" modal button
		Then I see the "Sign Out" side panel button

	@smoke
	Scenario: Logout and confirming the modal
		Given I log in with valid credentials
		When I click the "Sign Out" side panel button
		And I click the "Sign Out" modal button
		Then I see Fourth footer