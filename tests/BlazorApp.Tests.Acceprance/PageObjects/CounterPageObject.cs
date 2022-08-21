using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Tests.Acceprance.PageObjects
{
    public class CounterPageObject : BasePageObject
    {
        public override string PagePath { get; init; }// => "http://localhost:5109/counter";
        public CounterPageObject(IBrowserContext browser, string baseUrl)
        {
            Browser = browser;
            PagePath = $"{baseUrl}/counter";
        }
        public override IPage Page { get; set; }
        public override IBrowserContext Browser { get; }

        public async Task ClickIncreaseButton() => await Page.ClickAsync("#increase-btn");

        public async Task<int> CounterValue() => int.Parse(await Page.InnerTextAsync("#counter-val"));
    }
}
