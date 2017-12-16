using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;

namespace csharp.Utils
{
    public class DriverFactory
    {
        public static IWebDriver GetDriver()
        {
            string dirPath = "C:\\Users\\tanak\\Dropbox\\workspace\\gauge-sample\\csharp";
            return new ChromeDriver(dirPath);

            //var browser = Environment.GetEnvironmentVariable("BROWSER");

            //switch (browser)
            //{
            //    case "chrome":
            //        return new ChromeDriver();
            //    case "ie":
            //        return new InternetExplorerDriver();
            //    default:
            //        return new FirefoxDriver();
            //}
        }
    }
}
