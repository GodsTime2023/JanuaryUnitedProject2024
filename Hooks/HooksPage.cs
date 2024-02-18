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
        driver = ChooseBrowser(browserType.Chrome);
        //driver.Navigate().GoToUrl(Enviroment.url);
        driver.Navigate().GoToUrl(js.GetData("env:demoqaurl"));
        driver.Manage().Timeouts().ImplicitWait =
            TimeSpan.FromSeconds(double.Parse(Enviroment.TimeOut));
        driver.Manage().Timeouts().PageLoad =
            TimeSpan.FromSeconds(double.Parse(Enviroment.TimeOut));
        driver.Manage().Timeouts().AsynchronousJavaScript =
            TimeSpan.FromSeconds(double.Parse(Enviroment.TimeOut));
    }

    public IWebDriver ChooseBrowser(browserType browserType)
    {
        return browserType == browserType.Chrome
            ? driver = new ChromeDriver(new CustomMethods().MaximizeChromeBrowser())
            : browserType == browserType.FireFox
            ? driver = new FirefoxDriver()
            : browserType == browserType.Edge
            ? driver = new EdgeDriver()
            : throw new Exception("No such browser exist");
    }         

    [TearDown]
    public void TearDown() 
    {
        if (driver != null)
        {
            driver.Quit();
        }
        driver = null;
    }

    public static IEnumerable<TestCaseData> Mydata()
    {
        string[] datas =  { 
            "https://www.automationexercise.com/login","20","Test010@test.com","Password01!"};

        yield return new TestCaseData(datas);
    }
}
