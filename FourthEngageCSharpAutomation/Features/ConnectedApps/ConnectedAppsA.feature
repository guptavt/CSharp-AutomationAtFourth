﻿Feature: Engage -- Connected Apps -- A
	As an Engage user provisioned with Connected Apps
	I expect to be able to access the Connected Apps
	So that I can make use of their added value
	
	@smoke
	Scenario: Opening ESS as a Connected App
		Given I log in with valid credentials
		When I click the "All Applications" side panel button
		And I select the "My Rota & Payslips" Connected App
		Then I see ESS has loaded