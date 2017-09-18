  Feature: As an Engage user
  I want to be able to access my profile page
  So that I can see and edit my information.

      	 @smoke
  Scenario: Edit and Save profile information
    	Given I log in with valid credentials
    	And I click the user profile button
	   	And I click the "edit-button" right side button
		And I modify the "user " Lastname 
		And I click the "save-button" right side button
		Then I able to see the modified lastname

		@negative
	    @smoke
	Scenario: Edit and Cancel profile information
    	Given I log in with valid credentials
    	And I click the user profile button
		And I copied the user lastname
	   	And I click the "edit-button" right side button
		And I modify the "user " Lastname 
		And I click the left cancel button
		Then I able to compare the before modified name 