using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Tests.Acceprance.PageObjects
{
    public abstract class BasePageObject
    {
        public abstract string PagePath { get; init; }
        public abstract IPage Page { get; set; }
        public abstract IBrowserContext Browser { get; }

        public async Task NavigateAsync() {
            Page = await Browser.NewPageAsync();
            await Page.GotoAsync(PagePath);
        }
    }
}
