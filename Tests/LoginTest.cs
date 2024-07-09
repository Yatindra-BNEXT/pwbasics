using Microsoft.Playwright.NUnit;
using PWLearn.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWLearn.Tests
{
    internal class LoginTest : PageTest
    {
        private string user = "practice";
        private string password = "SuperSecretPassword!";
        private string invalidPassword = "password";

        [Test]
        public async Task Test1()
        {
            LoginPage loginPage = new LoginPage(Page);
            await loginPage.openLoginForm();
            await loginPage.login(user, password);
            await loginPage.validateLogin("You logged into a secure area!");
        }

        [Test]
        public async Task Test2()
        {
            LoginPage loginPage = new LoginPage(Page);
            await loginPage.openLoginForm();
            await loginPage.login(user, invalidPassword);
            await loginPage.validateLogin("Your password is invalid!");
        }
    }
}
