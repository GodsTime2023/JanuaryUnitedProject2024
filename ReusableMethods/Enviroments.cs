using JanuaryUnitedProject2024.Config;
using OpenQA.Selenium;

namespace JanuaryUnitedProject2024.ReusableMethods
{
    public static class Enviroments
    {
        /// <summary>
        /// This method will navigate to any url by specifying the url endpoint
        /// </summary>
        /// <param name="_driver"></param>
        /// <param name="js"></param>
        /// <param name="url"></param>
        public static void NavigateToSite(this IWebDriver _driver, 
            ReadFromJs js, string url)
        {
            if (url == "automationpractice")
            {
                _driver.Navigate().GoToUrl(js.GetData($"env:{url}"));
                _driver.Manage().Timeouts().ImplicitWait =
                    TimeSpan.FromSeconds(double.Parse(Enviroment.TimeOut));
            }
            else if (url == "demoqaurl")
            {
                _driver.Navigate().GoToUrl(js.GetData("env:demoqaurl"));
                _driver.Manage().Timeouts().ImplicitWait =
                    TimeSpan.FromSeconds(double.Parse(Enviroment.TimeOut));
            }
            else if (url == "demoqaurl2")
            {
                _driver.Navigate().GoToUrl(js.GetData("env:demoqaurl2"));
                _driver.Manage().Timeouts().ImplicitWait =
                    TimeSpan.FromSeconds(double.Parse(Enviroment.TimeOut));
            }
        }
    }
}
