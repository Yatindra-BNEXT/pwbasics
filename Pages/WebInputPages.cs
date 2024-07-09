using Microsoft.Playwright;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWLearn.Pages
{
    internal class WebInputPages : WebInputPageOR
    {
        private IPage _page;
        public WebInputPages(IPage page):base(page){
            _page = page;
        } 

        public async Task openWebInputs()
        {
            await _page.GotoAsync("https://practice.expandtesting.com/");
            await webInputs.ClickAsync();
        }

        public async Task<string> FormIsOpened() => await _page.TitleAsync();

        public async Task enterDetails(string num, string text, string pass)
        {
            await inputNum.FillAsync(num);
            await inputText.FillAsync(text);
            await inputPass.FillAsync(pass);
            await displayInputBtn.ClickAsync();
        }

        public async Task<string> validateEnteredNum() => await outputNum.InnerTextAsync();

        public async Task<string> validateEnteredText() => await outputText.InnerTextAsync();
        public async Task<string> validateEnteredPassword() => await outputPass.InnerTextAsync();

        


    }
}
