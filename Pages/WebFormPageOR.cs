using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWLearn.Pages
{
    internal class WebFormPageOR
    {
        private IPage page;
        protected WebFormPageOR(IPage _page) => page = _page;

        protected ILocator btnWebForm => page.Locator("a[href='web-form.html']");
        protected ILocator inputFieldText => page.Locator("#my-text-id");
        protected ILocator inputFieldPassword => page.Locator("input[name='my-password']");
        protected ILocator textArea => page.Locator("textarea[name='my-textarea']");
        protected ILocator disabledInput => page.Locator("input[name='my-disabled']");
        protected ILocator selectDropDown => page.Locator("select[name='my-select']");

        protected ILocator checkBox1 => page.Locator("#my-check-1");
        protected ILocator defaultCheckBox => page.Locator("#my-check-2");
        protected ILocator radioBtn1 => page.Locator("#my-radio-1");
        protected ILocator defRadioBtn => page.Locator("##my-radio-2");
        protected ILocator submitBtn => page.Locator("#//button[normalize-space()='Submit']");



        

    }
}
