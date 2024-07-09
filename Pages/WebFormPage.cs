using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWLearn.Pages
{
    internal class WebFormPage : WebFormPageOR
    {
        private IPage page;
        public WebFormPage(IPage _page) : base(_page) => page = _page;

        public async Task openWebForm()
        {
            await page.GotoAsync("https://bonigarcia.dev/selenium-webdriver-java/");
            await btnWebForm.ClickAsync();

        }

        public async Task fillWebForm(string name, string pass, string details)
        {
            await inputFieldText.FillAsync(name);
            await inputFieldPassword.FillAsync(pass);
            await textArea.FillAsync(details);
        }

        public async Task selectFromDropDown()
        {
            await selectDropDown.SelectOptionAsync(new[] { "Two" });
            await selectDropDown.SelectOptionAsync(new[] { new SelectOptionValue() { Value = "1" } });
        }

        public async Task<bool> validateCheckBoxIsChecked() => await checkBox1.IsCheckedAsync();

        public async Task<bool> validateCheckBoxIsUnchecked()
        {
            await defaultCheckBox.ClickAsync();
            return await defaultCheckBox.IsCheckedAsync();
        }
        
    }
}
