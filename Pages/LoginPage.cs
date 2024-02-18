using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuaryUnitedProject2024.Pages
{
    public class LoginPage
    {
        IWebDriver _driver;
        public LoginPage(IWebDriver driver)
        {
            _driver = driver; //Initializing our driver
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
}
