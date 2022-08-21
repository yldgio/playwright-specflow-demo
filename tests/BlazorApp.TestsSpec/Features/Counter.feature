@Counter
Feature: Counter should be properly incrementing its value

A short summary of the feature


Scenario: Click increases the counter value to 2
	Given a user in the counter page
	When the increase button is clicked 2 times
	Then the counter value is 2

Scenario: Click increases the counter value to 3
	Given a user in the counter page
	When the increase button is clicked 3 times
	Then the counter value is 3
