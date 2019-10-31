using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace XUnitTestAuto
{
    public class DriverFactory
    {

        private static IWebDriver driver = null;

        private DriverFactory()
        {
            
        }

        public static IWebDriver GetChromeDriver()
        {
            if (driver is null)
            {
                ChromeOptions co = new ChromeOptions();
                //co.AddArgument("--headless");
                driver = new ChromeDriver(co);
            }

            return driver;
        }



    }
}
