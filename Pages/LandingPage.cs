using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace JanuaryUnitedProject2024.Pages
{
    public class LandingPage
    {
        IWebDriver _driver;
        public LandingPage(IWebDriver driver)
        {
            _driver = driver;
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
}
