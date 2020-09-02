Feature: GoogleSearch
	In order to find details about an item
	As a user
	I want to seen the serach results on google


Scenario: User able to do google search successfully
	Given User navigate to google search page
	When User enters search item 
	And User Clicks on search button
	Then User should be able to see search item details