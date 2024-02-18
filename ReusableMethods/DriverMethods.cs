using OpenQA.Selenium;

namespace JanuaryUnitedProject2024.ReusableMethods
{
    public class DriverMethods
    {
        public void FindMyElement(IWebDriver driver, string by,
            string locator, string value)
        {
            if (by == "Name")
            {
                driver.FindElement(By.Name(locator)).SendKeys(value);
            }
            else if (by == "css")
            {
                driver.FindElement(By.CssSelector(locator)).SendKeys(value);
            };
        }

        public IWebElement FindMyElementAndClick(IWebDriver driver,
            string locator)
        {
            return driver.FindElement(By.CssSelector(locator));
        }

        public void FindMyElementAndClick2(IWebDriver driver,
            string locator)
        {
            var element = driver.FindElement(By.CssSelector(locator));
                element.Click();
        }

        public IWebElement FindMyElements(IWebDriver driver, string locator)
        {
            return driver.FindElements(By.Name(locator)).First();
        }

        public static IEnumerable<TestCaseData> Mydatas()
        {
            string[] data = { "Test010@test.com", "Password01!", "Name", "email", "password" };
            yield return new TestCaseData(data);
        }

        public (DriverMethods dm, IWebElement ele) FindThisElementAndclick(IWebDriver driver, By locator)
        {
            return (this, driver.FindElement(locator));
        }

        public DriverMethods FindThisElementAndEnterText(IWebDriver driver, By locator, string text)
        {
            var ele = driver.FindElement(locator);
            (this, ele).Item2.SendKeys(text);
            return new DriverMethods();
        }
    }

    public static class DriverExtensions
    {
        public static By IDLocator(this string idLocator) => By.Id(idLocator);
        public static By NameLocator(this string loc) => By.Name(loc);
        public static By CssLocator(this string cssLocator) => By.CssSelector(cssLocator);
        public static By XpathLocator(this string xpathLocator) => By.XPath(xpathLocator);
        public static By TagNameLocator(this string tagNameLocator) => By.TagName(tagNameLocator);
        public static By LinkTextLocator(this string linkTextLocator) => By.LinkText(linkTextLocator);
        public static By PartialLinkTextLocator(this string partialLinkTextLocator) =>
        By.PartialLinkText(partialLinkTextLocator);

        public static void FindMyElementAndClick2(this IWebDriver driver,
            string locator)
        {
            var element = driver.FindElement(By.CssSelector(locator));
            element.Click();
        }

        public static void FindMyElementAndEnterText(this IWebDriver driver,
            string locator, string value)
        {
            var element = driver.FindElement(By.CssSelector(locator));
            element.SendKeys(value);
        }

        public static string FindMyElementGetText(this IWebDriver driver,
            string locator)
        {
            var element = driver.FindElement(By.CssSelector(locator));
            return element.Text;
        }

        public static IWebElement FindMyElements(this IWebDriver driver, string locator)
        {
            return driver.FindElements(By.Name(locator)).First();
        }
    }
}
