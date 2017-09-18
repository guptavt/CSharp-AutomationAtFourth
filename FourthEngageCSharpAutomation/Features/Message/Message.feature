Feature: Engage -- Messages
    As an Engage user
    I want Message functionality
    So that people can send me private messages and vice versa


    Background:
    	Given I log in with valid credentials
    	And I click the "Messages" side panel button
	
    Scenario: Verify a user can't @mention himself in the message
    	
    	Given I click on Add new message
        When I do a @mention in message for myself
        Then search result should be empty

    Scenario Outline: Verify generation of a new message

    	Given I click on Add new message
		When I do a @mention in message for another user
        When I write <messageText> in the message body
        And I click the Submit button
		#And I click the latest message 
        Then I verify message body to contain <messageText> and last updated Time to be <messageAfterTime>

    Examples:
        | messageText  					  | messageAfterTime        |
        | this is a private message		  |  a minute ago  |	
   
  	Scenario Outline: Verify generation of reply on new message

  		Given I click on Add new message
		When I do a @mention in message for another user
        When I write <messageText> in the message body
        And I click the Submit button
		And I click the latest message 
        When I add reply <replyText>
        And I click on "Post" button
        Then I verify that <replyText> appears on the message trail
        And number of replies text updated to "1"

         Examples:
        | messageText					| replyText                |
		| New Message expecting reply	| Replying to your message | 

