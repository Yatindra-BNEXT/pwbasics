using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using PWLearn.Pages;

namespace PWLearn.Basics
{
    public class BasicSetup
    {

        IPage page;

        [SetUp]
        public async Task Setup()
        {
            // create playwright instance => downloads the driver and establish connection.
            var playwright = await Playwright.CreateAsync();

            // set the browser and running mode.
            var brower = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
            });

            // create a new page in context of new browser
            page = await brower.NewPageAsync();

            // launch the url
            await page.GotoAsync("https://practice.expandtesting.com/");
            await page.ClickAsync("text=Login Form");

        }

        [Test]
        public async Task Test1()
        {

            LoginPage loginPage = new LoginPage(page);
            loginPage.openLoginForm();
            loginPage.login("practice", "SuperSecretPassword!");
            loginPage.validateLogin("You logged into a secure area!");

        }

        [Test]
        public async Task Test2()
        {
            //login page
            await page.FillAsync("#username", "practice");
            await page.FillAsync("#password", "password!");
            await page.ClickAsync("//button[@type='submit']");

            //assertion for the invalid login

            var val = await page.Locator("#flash").InnerTextAsync();
            Assert.AreEqual(val, "Your password is invalid!");


            Thread.Sleep(5000);
        }

        [TearDown]
        public async Task tearDown()
        {
            await page.CloseAsync();
        }
    }
}