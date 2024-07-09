using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWLearn.BasicActivities
{
    internal class PromptAlert : PageTest
    {
        [Test]
        public async Task acceptAlert()
        {
            await Page.GotoAsync("https://demoqa.com/");
            await Page.ClickAsync("//h5[text()='Alerts, Frame & Windows']");
            await Page.ClickAsync("//span[text()='Alerts']");

            //Prompt alert

            Page.Dialog += async (_, dialog) =>
            {
                if (dialog.Type == DialogType.Prompt)
                {
                    await dialog.AcceptAsync("Yatindra");
                }
            };

            await Page.ClickAsync("#promtButton");
        }

    }
}
