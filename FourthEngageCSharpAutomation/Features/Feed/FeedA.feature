Feature: Engage -- Feed
    As an Engage user
    I want Feed functionality
    So that I can post and read Feeds posted  on the channel

    Background:
	
    Scenario Outline: Verify generation of new Feed with at mention
    	Given I log in with valid credentials
       	When I start writing a new post
		And I add <message> text
		And I mention myself
		And I click the Submit button
        Then I verify Feed body to contain <feedText> and last updated Time to be <feedTime>
   

    Examples:
        | message  						  |	feedText                         					 | feedTime                   |
        | The following user is notified: | The following user is notified:@approver testington  | Last Updated a minute ago  |

        Scenario Outline: Verify reply on new post

        Given I log in with valid credentials
       	And I start writing a new post
		And I add <message> text
		And I click the Submit button
        And I click the latest feed 
        When I add reply <replyText>
        And I click on "Post" button
        Then I verify that <replyText> appears on the message trail
        And number of replies text updated to "1"

         Examples:
        | message	| 				  replyText             |
		| New Feed expecting reply	| Replying to your feed |     