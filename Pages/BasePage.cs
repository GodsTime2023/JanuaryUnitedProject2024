using OpenQA.Selenium;

namespace JanuaryUnitedProject2024.Pages
{
    public class PlaywrightBasePage
    {
        public IWebDriver _driver;
        public PlaywrightBasePage(IWebDriver driver)
        {
            _driver = driver; 
        }
    }
}
