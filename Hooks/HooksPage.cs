using JanuaryUnitedProject2024.Config;
using JanuaryUnitedProject2024.ObjectRepository;
using JanuaryUnitedProject2024.ReusableMethods;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using static JanuaryUnitedProject2024.Enums.BrowserTypes;

namespace JanuaryUnitedProject2024.Hooks;

public class HooksPage : MyObjects
{
    public ReadFromJs js = new ReadFromJs(); 

    [SetUp]
    public void Setup()
    {
        _driver = CheckDriver(browserType.Chrome);
    }

    public IWebDriver ChooseBrowser(browserType browserType)
    {
        return browserType == browserType.Chrome
            ? _driver = new ChromeDriver(new CustomMethods().MaximizeChromeBrowser())
            : browserType == browserType.FireFox
            ? _driver = new FirefoxDriver()
            : browserType == browserType.Edge
            ? _driver = new EdgeDriver()
            : throw new Exception("No such browser exist");
    }

    public IWebDriver CheckDriver(browserType browserType) =>
        _driver! == null ? ChooseBrowser(browserType) : _driver;

    [TearDown]
    public void TearDown() 
    {
        if (_driver != null)
        {
            _driver.Quit();
        }
        _driver = null;
    }

    public static IEnumerable<TestCaseData> Mydata()
    {
        string[] datas =  { 
            "https://www.automationexercise.com/login",
            "20","Test010@test.com","Password01!"};

        yield return new TestCaseData(datas);
    }
}
