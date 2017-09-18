Feature: Engage -- Notifications -- A
	As an Engage user
	I expect to have notifications inside the Dashboard
	So that I can be kept up to date on in-app events that interest me
	
	@smoke
	Scenario Outline: Notification counter incrementing
		Given I log in with valid credentials
		And I remember the count of unread notifications
		When I start writing a new post
		And I add <message> text
		And I mention myself
		And I click the Submit button
		Then I see the count of unread notifications increment

		Examples:
		| message                         |
		| The following user is notified: |

	@smoke
	Scenario Outline: Notification counter decrementing
		Given I log in with valid credentials
		And I start writing a new post
		And I add <message> text
		And I mention myself
		And I click the Submit button
		When I remember the count of unread notifications
		And I click the "Notifications" side panel button
		And I click the latest notification 
		Then I see the count of unread notifications decrement

		Examples:
		| message                         |
		| The following user is notified: |

		# TODO: For the mention myself step, get the user from the Profile?