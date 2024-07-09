using Microsoft.Playwright.NUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWLearn.BasicActivities
{
    internal class AlertsHandling : PageTest
    {
        [Test]
        public async Task acceptAlert()
        {
            await Page.GotoAsync("https://demoqa.com/");
            await Page.ClickAsync("//h5[text()='Alerts, Frame & Windows']");
            await Page.ClickAsync("//span[text()='Alerts']");
            

            Page.Dialog += async(_, dialog) =>
            {
                await dialog.AcceptAsync();
            };

            
            await Page.ClickAsync("#confirmButton");
            Thread.Sleep(2000);
        }

    }
}
