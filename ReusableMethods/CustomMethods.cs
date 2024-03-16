using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace JanuaryUnitedProject2024.ReusableMethods;

public class CustomMethods
{
    public ChromeOptions MaximizeChromeBrowser()
    {
        ChromeOptions opt = new ChromeOptions();
        opt.AddArguments("--start-maximized", "incognito");
        return opt;
    }

    public FirefoxOptions MaximizeFireFoxBrowser()
    {
        FirefoxOptions opt = new FirefoxOptions();
        opt.AddArguments("--start-maximized", "--private");
        return opt;
    }

    public EdgeOptions MaximizeEdgeBrowser()
    {
        EdgeOptions opt = new EdgeOptions();
        opt.AddArguments("--start-maximized", "incognito");
        return opt;
    }
}
