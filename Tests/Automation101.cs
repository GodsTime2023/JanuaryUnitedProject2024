using FluentAssertions;
using JanuaryUnitedProject2024.Hooks;
using JanuaryUnitedProject2024.ReusableMethods;
using OpenQA.Selenium;

namespace JanuaryUnitedProject2024.Tests
{
    public class Automation101 : HooksPage
    {
        [Test, TestCaseSource(nameof(Mydata))]
        public void TestExample01(string url, string timeout, string username, string password)
        {
            //Fill my login detail
            driverMethods.FindMyElement(driver, "Name", "email",username);
            driverMethods.FindMyElement(driver, "Name", "password", password);

            //Click login button
            driverMethods.FindMyElementAndClick2(driver, "[data-qa='login-button']");

            IWebElement loggedInName =
                driver.FindElement(
                    By.XPath("//li//i[@class='fa fa-user']//parent::a/b"));

            Assert.That(loggedInName.Text.Equals("Test010")); //Nunit Assertion
            loggedInName.Text.Should().Be("Test010"); //Fluent Assertion
        }

        [Test]
        public void TestExample02()
        {
            driverMethods.FindMyElement(driver, "Name", "email", "Test010@test.com");
            driverMethods.FindMyElement(driver, "Name", "password", "Password01!");
            driverMethods.FindMyElementAndClick(driver, "[data-qa='login-button']").Click();
            
            IWebElement loggedInName =
                driver.FindElement(
                    By.XPath("//li//i[@class='fa fa-user']//parent::a/b"));

            loggedInName.Text.Should().Be("Test010");
        }

        [Test]
        public void TaskExcercise()
        {
            driver.FindElement(By.CssSelector("[class='fc-button-label']")).Click();
            driver.FindElement(By.CssSelector("#userName"))
                .SendKeys("TestUser");
            driver.FindElement(By.CssSelector("#password"))
                .SendKeys("Password01!");
            driver.FindElement(By.CssSelector("#login")).Click();

            var user = driver.FindElement(By.CssSelector("#userName-value")).Text;
            Assert.That(user.Equals("TestUser"), Is.True);
        }

        [Test]
        public void TaskExcerciseWithMethods()
        {
            driver.FindMyElementAndClick2("[class='fc-button-label']");
            driver.FindMyElementAndEnterText("#userName", js.GetData("env:username"));
            driver.FindMyElementAndEnterText("#password", js.GetData("env:password"));
            driver.FindMyElementAndClick2("#login");

            var user = driver.FindMyElementGetText("#userName-value");
            Assert.That(user.Equals("TestUser"), Is.True);
        }
        
        [Test]
        public void POMBasics()
        {
            //Git repository - Code or project is stored - Code base
            //Different types - 1. Git 2. Azure Devops 3. Jenkins 4. Sauce Lab 5. Git Lab

        }
    }
}
