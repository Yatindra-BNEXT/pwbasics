using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using PWLearn.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWLearn.Tests
{
    internal class WebInputTest : PageTest
    {
        [Test]
        public async Task test1()
        {
            WebInputPages page = new WebInputPages(Page);
            await page.openWebInputs();
            Thread.Sleep(2000);
            var isOpened = await page.FormIsOpened();
            Assert.That(isOpened, Is.EqualTo("Web inputs page for Automation Testing Practice"));
        }

        [Test]
        public async Task test2()
        {
            WebInputPages page = new WebInputPages(Page);
            await page.openWebInputs();
            await page.enterDetails("123", "yatindra", "password");
            var num = await page.validateEnteredNum();
            var name = await page.validateEnteredText();
            var pass = await page.validateEnteredPassword();

            Assert.That(num, Is.EqualTo("123"));
            Assert.That(name, Is.EqualTo("yatindra"));
            Assert.That(pass, Is.EqualTo("password"));
        }

    }
}
