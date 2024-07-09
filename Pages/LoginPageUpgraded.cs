using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWLearn.Pages
{
    internal class LoginPageUpgraded {
        private IPage _page;
        public LoginPageUpgraded(IPage page) => _page = page;

        private ILocator btnLoginForm => _page.Locator("a[href='/login']");
        private ILocator textFieldUser => _page.Locator("#username");
        private ILocator textFieldPassword => _page.Locator("#password");
        private ILocator btnLogin => _page.Locator("//button[@type='submit']");
        private ILocator alertMsg => _page.Locator("#flash");


        public async Task openLoginForm(){
            await _page.GotoAsync("https://practice.expandtesting.com/");
            await btnLoginForm.ClickAsync();
        }

        public async Task login(string uName, string pass){
            await textFieldUser.FillAsync(uName);
            await textFieldPassword.FillAsync(pass);
            await btnLogin.ClickAsync();
        }
        public async Task validateLogin(string text)
        {
            var val  = await alertMsg.InnerTextAsync();
            Assert.AreEqual(val, text);

        }

    }
}
