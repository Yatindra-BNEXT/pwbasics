using Microsoft.Playwright.NUnit;
using PWLearn.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWLearn.Tests
{
    internal class WebFormTest : PageTest
    {
        [Test]
        public async Task test1()
        {
            WebFormPage web = new WebFormPage(Page);
            await web.openWebForm();
            await web.selectFromDropDown();
        }

        [Test]
        public async Task test2()
        {
            WebFormPage web = new WebFormPage(Page);
            await web.openWebForm();
            var isChecked = await web.validateCheckBoxIsChecked();
            Assert.IsTrue(isChecked);
        }

        //[Test]
        public async Task test3()
        {
            WebFormPage web = new WebFormPage(Page);
            await web.openWebForm();
            var isChecked = await web.validateCheckBoxIsUnchecked();
            Assert.IsTrue(!isChecked);
        }
    }
}
