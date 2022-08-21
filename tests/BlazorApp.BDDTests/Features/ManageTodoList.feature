Feature: Users can view and manage the list of todo items
	As a user
	I want to view, add and delete all the items in my todo list

@tag1
Scenario: A new user should see an empty list
	Given an empty list of todo items
	When the todo items is accessed
	Then the list is empty

Scenario: A user should be able to add a new Todo Item
	Given an empty list of todo items
	When 1 new todo item is added to the list
	Then list contains the newly added item
