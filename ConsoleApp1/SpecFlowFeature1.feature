Feature: SpecFlowFeature1
	Login Taiga Test Tracker Website and 
	verifying Posted Bugs

@mytag
Scenario: Login into the Taiga Web App
	Given Url for Taiga Web App
	And Enter User name and Password
	When hit on the login button
	Then the result window should be logged in page