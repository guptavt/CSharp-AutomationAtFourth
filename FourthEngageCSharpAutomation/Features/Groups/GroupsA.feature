Feature: Engage -- Groups-B
		    As an Engage user
		    I want Groups functionality
		    So that I can direct my communications to specific groups

Background:
			Given I log in with valid credentials
			When I click the "Groups" side panel button
			And I visit the "TS_QAI" group

Scenario Outline: I should be able to like a group post
			Given I start writing a new post
			And I add <message> text
			And I click the Submit button
	        And I refresh the groups feed page
	        When I click on Like button
	        Then I verify that number of likes on the post become 1

Examples:
	        |	message              			|
	        |	"New group post to verify like" |

#Scenario Outline: I should be able to edit a group post
#	        Given I start writing a new post
#			And I add <message> text
#			And I click the Submit button
#	        And I refresh the groups feed page
#	        When I edit the feed text to <EditedGroupFeedText>
#	        And I click the "Submit" button
#	        Then I verify that feed text change to <EditedGroupFeedText>

#Examples:
#              |	message              			| EditedGroupFeedText       |
#              |	"New group post to verify edit" | "Edited Group Feed Text"  |

    
#Scenario Outline: I should be able to delete a group post
#	        Given I start writing a new post
#			And I add <message> text
#			And I click the Submit button
#	        And I refresh the groups feed page
#	        When I click on delete button
#	        And I confirm the deletion
#	        Then I verify that post <message> is successfully deleted from the feed trail

#Examples:
#	        | message              		      | 
#	        | "I can delete this group feed"  |


#Scenario Outline: I should not be able to delete posts of which I m not the creator
#          	Given I start writing a new post
#			And I add <message> text
#			And I click the Submit button
#	        And I refresh the groups feed page
#          	When I click the "Sign Out" side panel button
#			And I click the "Sign Out" modal button
#          	Given I log in with another user credentials
#          	And I click the "Groups" side panel button
#          	And I visit the "TS_QAI" group
#          	And I click the latest feed
#          	Then I verify that delete option is unavailable
#Examples:
#	        | message              	                 | 
#	        | "Others can't delete this group feed"  |

