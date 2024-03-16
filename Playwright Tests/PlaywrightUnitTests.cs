using JanuaryUnitedProject2024.Hooks;
using JanuaryUnitedProject2024.PlaywrightPages;
using Microsoft.Playwright;


namespace JanuaryUnitedProject2024.Playwright_Tests
{
    public class PlaywrightUnitTests : HooksPagePlaywright
    {
        PwLandingPage pwLandingPage;
        PwLoginPage pwLoginPage;
        PwBooksPage pwBooksPage;
        Task<IPage> _page;
        public PlaywrightUnitTests()
        {
            _page = Checkdriver();
            pwLandingPage = new PwLandingPage(_page.Result);
            pwLoginPage = new PwLoginPage(_page.Result);
            pwBooksPage = new PwBooksPage(_page.Result);
        }

        [Test]
        public async Task PlaywrightTest01()
        {
            await page.GotoAsync(Enviroment.demoqaUrl);
            await Task.Delay(2000);
            await page.GetByLabel("Consent", new() { Exact = true }).ClickAsync();
            await page.GetByPlaceholder("UserName").FillAsync("TestUser");
            await page.GetByPlaceholder("Password").FillAsync("Password01!");
            await page.GetByRole(AriaRole.Button, new() { Name = "Login" }).ClickAsync();
            var displayedUser = await page.GetByText("TestUser").TextContentAsync();
            Assert.That(displayedUser?.Equals("TestUser"), Is.True);
        }

        [Test]
        public async Task PlaywrightTest02()
        {
            await page.GotoAsync(Enviroment.demoqaUrl);
            await Task.Delay(2000);
            await page.GetByLabel("Consent", new() { Exact = true }).ClickAsync();
            await page.Locator("[id='userName']").FillAsync("TestUser");
            await page.Locator("[id='password']").FillAsync("Password01!");
            await page.Locator("[id='login']").ClickAsync();
            var displayedUser = await page.GetByText("TestUser").TextContentAsync();
            Assert.That(displayedUser?.Equals("TestUser"), Is.True);
        }

        [Test]
        public async Task PlaywrightTest03POM()
        {
            await page.GotoAsync(Enviroment.demoqaUrl);
            await Task.Delay(2000);
            
            //Create object
            await pwLandingPage.ClickConsent();

            await pwLoginPage.EnterUserName("TestUser");
            await pwLoginPage.EnterPassword("Password01!");
            await pwLoginPage.ClickLoginbutton();

            var displayedUser = pwBooksPage.GetUserdisplayName().Result;
            Assert.That(displayedUser.Equals("TestUser"), Is.True);
        }
    }
}
