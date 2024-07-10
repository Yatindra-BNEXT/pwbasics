using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWLearn.BasicActivities
{
    internal class MouseHover
    {
        IPage page;
        IBrowser browser;

        [SetUp]
        public async Task setUp()
        {
            var playwright = await Playwright.CreateAsync();
            browser = await playwright.Chromium.LaunchAsync(new () {
               Headless = false,
                

            });


            page = await browser.NewPageAsync();
        }

        [Test]
        public async Task test1()
        {   await page.GotoAsync("https://rahulshettyacademy.com/dropdownsPractise/");
            await page.Locator("(//a[@title='Web Check-in'])[1]").HoverAsync();
            var isVisible = await page.Locator("(//div[@class='fareToolTip'])[1]").IsVisibleAsync();
            Assert.IsTrue(isVisible);
            
        }
    }
}
