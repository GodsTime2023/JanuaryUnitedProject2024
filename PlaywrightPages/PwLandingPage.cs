using Microsoft.Playwright;
using OpenQA.Selenium;

namespace JanuaryUnitedProject2024.PlaywrightPages
{
    public class PwLandingPage : PwBasePage
    {
        public PwLandingPage(IPage driver) : base(driver)
        {
        }

        //Identify element
        private ILocator BookStoreLocator =>
            _driver.Locator("(//div[@class='card mt-4 top-card'])[.='Book Store Application']");
        private ILocator consent => _driver.GetByLabel("Consent", new() { Exact = true });



        //Create method to click the element
        public async Task ClickConsent() => await consent.ClickAsync();

        public async Task ClickBookstoreLocator()
        {
            //((IJavaScriptExecutor)_driver)
            //    .ExecuteScript("arguments[0].scrollIntoView(true);"
            //    , BookStoreLocator);
            await BookStoreLocator.ScrollIntoViewIfNeededAsync();
            await BookStoreLocator.ClickAsync();
        }
    }
}
