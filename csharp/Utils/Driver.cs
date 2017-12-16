﻿using Gauge.CSharp.Lib.Attribute;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Utils
{
    public class Driver
    {
        // Holds the WebDriver instance
        private static IWebDriver _driver;

        [BeforeSuite]
        public void Initialize()
        {
            _driver = DriverFactory.GetDriver();
        }

        [AfterSuite]
        public void Cleanup()
        {
            _driver.Quit();
        }

        public static IWebDriver WebDriver
        {
            get { return _driver; }
        }

    }
}
