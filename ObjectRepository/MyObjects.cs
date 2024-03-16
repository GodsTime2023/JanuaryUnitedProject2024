using JanuaryUnitedProject2024.ReusableMethods;
using Microsoft.Playwright;
using OpenQA.Selenium;

namespace JanuaryUnitedProject2024.ObjectRepository;

public class MyObjects
{
    public IWebDriver _driver;
    public DriverMethods driverMethods = new DriverMethods();
    public IPlaywright playwright;
    public IBrowser browser;
    public IPage page;
}
