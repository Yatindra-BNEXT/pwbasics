using Microsoft.Playwright.NUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWLearn.BasicActivities
{
    internal class FrameHandling : PageTest
    {

        [Test]
        public async Task Test1()
        {
            await Page.GotoAsync("https://practice.expandtesting.com/iframe");
            //IFrame handling
            var frame = Page.FrameLocator("iframe[title='Rich Text Area']");
            var text = frame.Locator("#tinymce");
            await text.FillAsync("Yatindra");
            Thread.Sleep(5000);
            await Page.Locator("//span[text()='File']").ClickAsync();
            Thread.Sleep(5000);
        }

    }
}
