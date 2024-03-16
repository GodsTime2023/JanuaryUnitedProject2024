using Microsoft.Playwright;
using OpenQA.Selenium;

namespace JanuaryUnitedProject2024.PlaywrightPages
{
    public class PwBooksPage : PwBasePage
    {
        public PwBooksPage(IPage driver) : base(driver)
        {
        }

        //Locator
        private ILocator loginButton => _driver.Locator("#login");
        private ILocator userDisplayName => _driver.GetByText("TestUser");

        //Create a method to click the locator
        public async Task ClickLoginButton() => await loginButton.ClickAsync();
        //public async Task<string> GetUserdisplayName() => userDisplayName.TextContentAsync().Result;
        public async Task<string> GetUserdisplayName() => await Task.FromResult(userDisplayName.TextContentAsync()).Result;
    }
}
