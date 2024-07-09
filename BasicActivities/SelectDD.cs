using Microsoft.Playwright.NUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWLearn.BasicActivities
{
    internal class SelectDD : PageTest
    {
        [Test]
        public async Task test1()
        {
            //await Page.GotoAsync("https://demoqa.com/");
            //await Page.ClickAsync("//h5[text()='Forms']");
            //await Page.ClickAsync("//span[text()='Practice Form']");
            //await Page.FillAsync("#firstName", "Yatindra");
            //await Page.FillAsync("#lastName", "Shukla");
            //await Page.FillAsync("#userEmail", "yk@gmail.com");

            //await Page.FillAsync("#userNumber", "9876543210");
            //await Page.ClickAsync("#dateOfBirthInput");
            //await Page.SelectOptionAsync(".react-datepicker__month-select", "December");
            //await Page.SelectOptionAsync(".react-datepicker__year-select", "1997");
            //await Page.ClickAsync("//div[text()='23']");
            ////await Page.CheckAsync("#hobbies-checkbox-1");
            ////await Page.CheckAsync("#hobbies-checkbox-2");
            ////await Page.CheckAsync("#hobbies-checkbox-3");
            //await Page.FillAsync("#currentAddress", "Lucknow UP India");
            //await Page.ClickAsync("//div[text()='Select State']");
            //await Page.ClickAsync("//div[text()='Uttar Pradesh']");
            //await Page.CheckAsync("input[name='gender'][value='Male']");
            //await Page.ClickAsync("#submit");
            

            await Page.GotoAsync("https://practice.expandtesting.com/");
            await Page.ClickAsync("a[href='/checkboxes']");
            await Page.CheckAsync("#checkbox1");
            await Page.UncheckAsync("#checkbox2");

            Thread.Sleep(5000);

        }
    }
}
