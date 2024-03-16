using OpenQA.Selenium;
namespace JanuaryUnitedProject2024.Pages;

public class SeleniumBooksPage : PlaywrightBasePage
{
    public SeleniumBooksPage(IWebDriver driver) : base(driver)
    {
    }

    //Locator
    private IWebElement loginButton => _driver.FindElement(By.CssSelector("#login"));
    private IWebElement userDisplayName => _driver.FindElement(By.CssSelector(
        "#userName-value"));

    //Create a method to click the locator
    public void ClickLoginButton() => loginButton.Click();
    public string GetUserdisplayName() => userDisplayName.Text;
}
