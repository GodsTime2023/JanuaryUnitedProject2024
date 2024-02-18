using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuaryUnitedProject2024.Pages
{
    public class BooksPage
    {
        IWebDriver _driver;
        public BooksPage(IWebDriver driver)
        {
            _driver = driver;  
        }

        //Locator
        private IWebElement loginButton => _driver.FindElement(By.CssSelector("#login"));
        private IWebElement userDisplayName => _driver.FindElement(By.CssSelector(
            "#userName-value"));

        //Create a method to click the locator
        public void ClickLoginButton()=> loginButton.Click();
        public string GetUserdisplayName()=> userDisplayName.Text;
    }
}
