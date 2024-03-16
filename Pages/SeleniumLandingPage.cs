using OpenQA.Selenium;

namespace JanuaryUnitedProject2024.Pages;

public class SeleniumLandingPage : PlaywrightBasePage
{
    public SeleniumLandingPage(IWebDriver driver) : base(driver)
    {
    }

    //Identify element
    private IWebElement BookStoreLocator =>
        _driver.FindElement(By.
            XPath("(//div[@class='card mt-4 top-card'])[.='Book Store Application']"));
    private IWebElement consent => _driver.FindElement(By.CssSelector("[class='fc-button-label']"));

    //Create method to click the element
    public void ClickConsent()
    {
        _driver.Manage().Timeouts().ImplicitWait =
        TimeSpan.FromSeconds(double.Parse(Enviroment.TimeOut));
        consent.Click();
    }

    public void ClickBookstoreLocator()
    {
        ((IJavaScriptExecutor)_driver)
            .ExecuteScript("arguments[0].scrollIntoView(true);"
            , BookStoreLocator);
        BookStoreLocator.Click();
    }
}
