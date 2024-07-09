using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWLearn.Pages
{
    internal class WebInputPageOR
    {
        private IPage _page;
        protected WebInputPageOR(IPage page) => _page = page;
       
        protected ILocator webInputs => _page.Locator("a[href='/inputs']");
        protected ILocator inputNum => _page.Locator("input[id='input-number']");
        protected ILocator outputNum => _page.Locator("#output-number");
        protected ILocator inputText => _page.Locator("#input-text");
        protected ILocator outputText => _page.Locator("#output-text");
        
        protected ILocator inputPass => _page.Locator("#input-password");
        protected ILocator outputPass => _page.Locator("#output-password");

        protected ILocator inputDate => _page.Locator("#input-date");
        protected ILocator outputDate => _page.Locator("#output-date");

        protected ILocator displayInputBtn => _page.Locator("#btn-display-inputs");

        protected ILocator displayClearInputBtn => _page.Locator("#btn-clear-inputs");
    }
}
