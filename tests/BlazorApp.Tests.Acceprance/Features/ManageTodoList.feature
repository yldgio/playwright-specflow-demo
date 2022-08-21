Feature: todo items
	It should be possible to view, add and delete all the items in a todo list

@tag1
Scenario: It should be possible to add a new Todo Item to the todo items list
	Given an empty list of todo items
	When 1 new todo item is added to the list
	Then list contains only 1 item
