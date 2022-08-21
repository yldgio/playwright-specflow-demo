using System;
using TechTalk.SpecFlow;

namespace BlazorApp.Tests.Acceprance.StepDefinitions
{
    [Binding]
    public class ManageTodoListSteps
    {
        private TodoItems _todos;
        [Given(@"an empty list of todo items")]
        public void GivenAnEmptyListOfTodoItems()
        {
             _todos = new();
        }

        [When(@"(.*) new todo item is added to the list")]
        public void WhenNewTodoItemIsAddedToTheList(int howmany)
        {
            for (int i = 0; i < howmany; i++)
            {
                _todos.Add(new TodoItem() { Title = $"Item {i}" });
            }
        }

        [Then(@"list contains only (.*) item")]
        public void ThenListContainsOnlyItem(int howMany)
        {
            _todos.Count.Should().Be(howMany);
        }

    }
}
