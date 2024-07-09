using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace PWLearn.Basics
{
    public class UnitTest1 : PageTest
    {


        [SetUp]
        public async Task Setup()
        {

            // launch the url
            await Page.GotoAsync("https://practice.expandtesting.com/");
            await Page.ClickAsync("text=Login Form");

        }

        [Test]
        public async Task Test1()
        {

            //login page

            var textFieldUserName = Page.Locator("#username");
            await textFieldUserName.FillAsync("practice");

            var textFieldPassword = Page.Locator("#password");
            await textFieldPassword.FillAsync("SuperSecretPassword!");

            var btnLogin = Page.Locator("//button[@type='submit']");
            await btnLogin.ClickAsync();

            //assertion for the successfull login

            var alertMsg = Page.Locator("#flash");
            await Expect(alertMsg).ToContainTextAsync("You logged into a secure area!");

        }

        [Test]
        public async Task Test2()
        {

            //login page
            var textFieldUserName = Page.Locator("#username");
            await textFieldUserName.FillAsync("practice");

            var textFieldPassword = Page.Locator("#password");
            await textFieldPassword.ClickAsync();

            var btnLogin = Page.Locator("//button[@type='submit']");
            await btnLogin.ClickAsync();

            //assertion for the invalid login

            var alertMsg = Page.Locator("#flash");
            await Expect(alertMsg).ToContainTextAsync("Your password is invalid!");
        }

        [TearDown]
        public async Task tearDown()
        {
            await Page.CloseAsync();
        }
    }
}