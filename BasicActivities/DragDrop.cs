using Microsoft.Playwright.NUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWLearn.BasicActivities
{
    internal class DragDrop : PageTest
    {
        [Test]
        public async Task Test1()
        {
            await Page.GotoAsync("https://practice.expandtesting.com/drag-and-drop");
            await Page.DragAndDropAsync("#column-a", "#column-b");
            Thread.Sleep(3000);

            //open a new window
            var newPage = await Browser.NewPageAsync();
            await newPage.GotoAsync("https://practice.expandtesting.com/drag-and-drop-circles");
            await newPage.DragAndDropAsync(".red", "#target");
            await newPage.DragAndDropAsync(".green", "#target");
            await newPage.DragAndDropAsync(".blue", "#target");
            Thread.Sleep(3000);
        }
    }
}
