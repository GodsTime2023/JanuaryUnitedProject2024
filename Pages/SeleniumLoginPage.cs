using OpenQA.Selenium;

namespace JanuaryUnitedProject2024.Pages;

public class SeleniumLoginPage : PlaywrightBasePage
{
    public SeleniumLoginPage(IWebDriver driver) : base(driver)
    {
    }

    //Create your locator
    private IWebElement userName => _driver.FindElement(By.CssSelector("#userName"));
    private IWebElement password => _driver.FindElement(By.CssSelector("#password"));
    private IWebElement loginbutton => _driver.FindElement(By.CssSelector("#login"));


    //Create a method to interact with those elements
    public void EnterUserName(string username) => userName.SendKeys(username);
    public void EnterPassword(string passWord) => password.SendKeys(passWord);
    public void ClickLoginbutton() => loginbutton.Click();
}
