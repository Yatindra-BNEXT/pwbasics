using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWLearn.Pages
{
    internal class LoginPage{
        private IPage _page;
        private readonly ILocator _btnLoginForm;
        private readonly ILocator _textFieldUser;
        private readonly ILocator _textFieldPassword;
        private readonly ILocator _btnLogin;
        private readonly ILocator _alertMsg;


        public LoginPage(IPage page){
            _page = page;
            _btnLoginForm = page.Locator("a[href='/login']");
            _textFieldUser = page.Locator("#username");
            _textFieldPassword = page.Locator("#password");
            _btnLogin = page.Locator("//button[@type='submit']");
            _alertMsg = page.Locator("#flash");
        }


        public async Task openLoginForm(){
            await _page.GotoAsync("https://practice.expandtesting.com/");
            await _btnLoginForm.ClickAsync();
        }

        public async Task login(string uName, string pass){
            await _textFieldUser.FillAsync(uName);
            await _textFieldPassword.FillAsync(pass);
            await _btnLogin.ClickAsync();
        }
        public async Task validateLogin(string text)
        {
            var val  = await _alertMsg.InnerTextAsync();
            Assert.AreEqual(val, text);

        }

    }
}
