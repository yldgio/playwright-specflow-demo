using BlazorApp.Tests.Acceprance.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace BlazorApp.Tests.Acceprance.StepDefinitions
{
    [Binding]
    public class CounterStepDefinitions
    {
        private readonly CounterPageObject _counterPageObject;

        public CounterStepDefinitions(CounterPageObject counterPageObject)
        {
            _counterPageObject = counterPageObject;
        }

        [Given(@"a user in the counter page")]
        public async Task GivenAUserInTheCounterPage()
        {
            await _counterPageObject.NavigateAsync();
        }

        [When(@"the increase button is clicked (.*) times")]
        public async Task WhenTheIncreaseButtonIsClickedTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                await _counterPageObject.ClickIncreaseButton();
            }
        }

        [Then(@"the counter value is (.*)")]
        public async Task ThenTheCounterValueIs(int expectedValue)
        {
            var counterValue = await _counterPageObject.CounterValue();
            counterValue.Should().Be(expectedValue);
        }
    }
}
