using System;
using TechTalk.SpecFlow;

namespace BlazorApp.BDDTests.Steps
{
    [Binding]
    public class ManageTodoListSteps
    {
        [Given(@"an empty list of todo items")]
        public void GivenAnEmptyListOfTodoItems()
        {
            ScenarioContext.StepIsPending();
        }

        [When(@"the todo items is accessed")]
        public void WhenTheTodoItemsIsAccessed()
        {
            ScenarioContext.StepIsPending();
        }

        [Then(@"the list is empty")]
        public void ThenTheListIsEmpty()
        {
            ScenarioContext.StepIsPending();
        }

        [When(@"(.*) new todo item is added to the list")]
        public void WhenNewTodoItemIsAddedToTheList(int p0)
        {
            ScenarioContext.StepIsPending();
        }

        [Then(@"list contains the newly added item")]
        public void ThenListContainsTheNewlyAddedItem()
        {
            ScenarioContext.StepIsPending();
        }
    }
}
