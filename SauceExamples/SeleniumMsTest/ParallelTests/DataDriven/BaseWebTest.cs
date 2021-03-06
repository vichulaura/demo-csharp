﻿using Common.SauceLabs;
using OpenQA.Selenium;

namespace Selenium.MsTest.Scripts.ParallelTests.DataDriven
{
    public class BaseWebTest
    {
        public SauceJavaScriptExecutor SauceReporter { get; set; }

        public IWebDriver Driver { get; set; }
    }
}