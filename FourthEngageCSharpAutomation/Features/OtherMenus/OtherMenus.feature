  Feature: As an Engage user
  I want to be able to access various others menus

@smoke
  Scenario Outline: Access other left side menus
    	Given I log in with valid credentials
    	And I click the <other-items> left side menu
		When I able to capture the header content
		Then I validate the header <item> content
 
 Examples:
  | other-items | item			|  
  | "suppliers" | "suppliers"	|  
  | "services"  | "services"    |  
  | "notices"   | "notices"		|  
  | "help"      | "help"		|  
