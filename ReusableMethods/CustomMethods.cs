using OpenQA.Selenium.Chrome;

namespace JanuaryUnitedProject2024.ReusableMethods;

public class CustomMethods
{
    public ChromeOptions MaximizeChromeBrowser()
    {
        ChromeOptions opt = new ChromeOptions();
        opt.AddArguments("--start-maximized", "incognito");
        return opt;
    }
}
