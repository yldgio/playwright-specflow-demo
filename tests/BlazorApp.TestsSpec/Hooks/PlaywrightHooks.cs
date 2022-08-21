using BlazorApp.TestsSpec.PageObjects;
using BoDi;
using Microsoft.Playwright;
using TechTalk.SpecFlow;

namespace BlazorApp.TestsSpec.Hooks
{
    [Binding]
    public sealed class PlaywrightHooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario("@Counter")]
        public async Task BeforeCounterScenario(IObjectContainer container)
        {
            // Example of filtering hooks using tags. (in this case, this 'before scenario' hook will execute if the feature/scenario contains the tag '@tag1')
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=hooks#tag-scoping

            var playwright = await Playwright.CreateAsync(); //create the driver
            var browser = await playwright.Chromium.LaunchAsync(); //launch browser headless
            //var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            //{
            //    Headless = false,
            //    SlowMo = 2000
            //}); //open browser
            var pageObject = new CounterPageObject(browser);
            container.RegisterInstanceAs(playwright);
            container.RegisterInstanceAs(browser);
            container.RegisterInstanceAs(pageObject);

        }

        [AfterScenario]
        public async void AfterScenario(IObjectContainer container)
        {
            var browser = container.Resolve<IBrowser>();
            await browser.CloseAsync();
            var playwright = container.Resolve<IPlaywright>();
            playwright.Dispose();
        }
    }
}