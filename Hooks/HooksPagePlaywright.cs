using JanuaryUnitedProject2024.ObjectRepository;
using Microsoft.Playwright;

namespace JanuaryUnitedProject2024.Hooks
{
    public class HooksPagePlaywright : MyObjects
    {
        [SetUp]
        public async Task StartPlaywright()
        {
            page = await Checkdriver();
        }

        public async Task Initialize()
        {
            playwright = await Playwright.CreateAsync();
            browser = await playwright.Chromium
                .LaunchAsync(new BrowserTypeLaunchOptions()
                {
                    Channel = "chrome",
                    SlowMo = 50,
                    Headless = false
                });
            page = await browser.NewPageAsync(new BrowserNewPageOptions()
            {
                ViewportSize = new ViewportSize
                {
                    Height = 1080,
                    Width = 1850
                }
            });
        }

        public async Task<IPage> Checkdriver()
        {
            if (page == null)
            {
                await Initialize();
            }
            return page;
        }
    }
}
