using Microsoft.Playwright.NUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWLearn.BasicActivities
{
    internal class SwitchWindow : PageTest
    {
        //switching window
        [Test]
        public async Task test1()
        {
            await Page.GotoAsync("https://demoqa.com/");
            await Page.ClickAsync("//h5[text()='Alerts, Frame & Windows']");
            await Page.ClickAsync("//span[text()='Browser Windows']");
            

            var newPage = await Context.RunAndWaitForPageAsync(async () =>
            {
                await Page.ClickAsync("#tabButton");
               
            });

            var heading = await newPage.Locator("#sampleHeading").InnerTextAsync();
            Console.WriteLine(heading);
         }
    }
}
