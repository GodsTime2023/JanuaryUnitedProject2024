using FluentAssertions;
using JanuaryUnitedProject2024.Hooks;
using JanuaryUnitedProject2024.Pages;
using JanuaryUnitedProject2024.ReusableMethods;
using OpenQA.Selenium;
using static JanuaryUnitedProject2024.Enums.BrowserTypes;

namespace JanuaryUnitedProject2024.Tests;

public class Automation101 : HooksPage
{
    SeleniumLandingPage landingPage;
    SeleniumBooksPage booksPage;
    SeleniumLoginPage loginPage;

    public Automation101()
    {
        _driver = CheckDriver(browserType.Chrome);
        landingPage = new SeleniumLandingPage(_driver);
        booksPage = new SeleniumBooksPage(_driver); 
        loginPage = new SeleniumLoginPage(_driver);
    }

    [Test, TestCaseSource(nameof(Mydata))] //Data driven
    public void TestExample01(string url, string timeout, string username, string password)
    {
        _driver.NavigateToSite(js, "automationpractice");

        //Fill my login detail
        driverMethods.FindMyElement(_driver, "Name", "email",username);
        driverMethods.FindMyElement(_driver, "Name", "password", password);

        //Click login button
        driverMethods.FindMyElementAndClick2(_driver, "[data-qa='login-button']");

        IWebElement loggedInName =
            _driver.FindElement(
                By.XPath("//li//i[@class='fa fa-user']//parent::a/b"));

        Assert.That(loggedInName.Text.Equals("Test010")); //Nunit Assertion
        loggedInName.Text.Should().Be("Test010"); //Fluent Assertion
    }

    [Test]
    public void TestExample02()
    {
        _driver.NavigateToSite(js, "automationpractice"); // code english

        driverMethods.FindMyElement(_driver, "Name", "email", "Test010@test.com");
        driverMethods.FindMyElement(_driver, "Name", "password", "Password01!");
        driverMethods.FindMyElementAndClick(_driver, "[data-qa='login-button']").Click();
        
        IWebElement loggedInName =
            _driver.FindElement(
                By.XPath("//li//i[@class='fa fa-user']//parent::a/b"));

        loggedInName.Text.Should().Be("Test010");
    }

    [Test]
    public void TaskExcercise()
    {
        _driver.NavigateToSite(js, "demoqaurl");

        _driver.FindElement(By.CssSelector("[class='fc-button-label']")).Click();
        _driver.FindElement(By.CssSelector("#userName"))
            .SendKeys("TestUser");
        _driver.FindElement(By.CssSelector("#password"))
            .SendKeys("Password01!");
        _driver.FindElement(By.CssSelector("#login")).Click();

        var user = _driver.FindElement(By.CssSelector("#userName-value")).Text;
        Assert.That(user.Equals("TestUser"), Is.True);
    }

    [Test]
    public void TaskExcerciseWithMethods()
    {
        _driver.NavigateToSite(js, "demoqaurl");

        _driver.FindMyElementAndClick2("[class='fc-button-label']");
        _driver.FindMyElementAndEnterText("#userName", js.GetData("env:username"));
        _driver.FindMyElementAndEnterText("#password", js.GetData("env:password"));
        _driver.FindMyElementAndClick2("#login");

        var user = _driver.FindMyElementGetText("#userName-value");
        Assert.That(user.Equals("TestUser"), Is.True);
    }
    
    [Test]
    public void POMBasics()
    {
        _driver.NavigateToSite(js, "demoqaurl2");

        landingPage.ClickConsent();
        landingPage.ClickBookstoreLocator();
        booksPage.ClickLoginButton();

        loginPage.EnterUserName("TestUser");
        loginPage.EnterPassword("Password01!");.

        loginPage.ClickLoginbutton();
        _driver.Manage().Timeouts().ImplicitWait =
        TimeSpan.FromSeconds(double.Parse(Enviroment.TimeOut));

        var user = booksPage.GetUserdisplayName();
        Assert.That(user.Equals("TestUser"), Is.True);
    }
}
