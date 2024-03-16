using Microsoft.Playwright;

namespace JanuaryUnitedProject2024.PlaywrightPages
{
    public class PwBasePage
    {
        public IPage _driver;
        public PwBasePage(IPage driver)
        {
            _driver = driver;
        }
    }
}
