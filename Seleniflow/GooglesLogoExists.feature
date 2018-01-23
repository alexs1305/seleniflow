Feature: GooglesLogoExists

Scenario: Googles Logo loads
	Given I navigate to the page "https://www.google.com"
	And I see the page is loaded
	Then Googles logo should be visible
