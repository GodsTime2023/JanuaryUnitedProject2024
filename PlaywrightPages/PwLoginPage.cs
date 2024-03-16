using Microsoft.Playwright;

namespace JanuaryUnitedProject2024.PlaywrightPages
{
    public class PwLoginPage : PwBasePage
    {
        public PwLoginPage(IPage driver) : base(driver)
        {
        }

        //Create your locator
        private ILocator userName => _driver.Locator("#userName");
        private ILocator password => _driver.Locator("#password");
        private ILocator loginbutton => _driver.Locator("#login");


        //Create a method to interact with those elements
        public async Task EnterUserName(string username) => await userName.FillAsync(username);
        public async Task EnterPassword(string passWord) => await password.FillAsync(passWord);
        public async Task ClickLoginbutton() => await loginbutton.ClickAsync();
    }
}
