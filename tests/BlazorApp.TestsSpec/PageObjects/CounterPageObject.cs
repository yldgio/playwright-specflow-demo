using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.TestsSpec.PageObjects
{
    public class CounterPageObject : BasePageObject
    {
        public override string PagePath => "http://localhost:5109/counter";
        public CounterPageObject(IBrowser browser)
        {
            Browser = browser;
        }
        public override IPage Page { get; set; }
        public override IBrowser Browser { get; }

        public async Task ClickIncreaseButton() => await Page.ClickAsync("#increase-btn");

        public async Task<int> CounterValue() => int.Parse(await Page.InnerTextAsync("#counter-val"));
    }
}
