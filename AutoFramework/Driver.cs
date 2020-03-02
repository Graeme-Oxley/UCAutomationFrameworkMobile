namespace AutoFramework
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Appium;
    using OpenQA.Selenium.Chrome;
    using System;

    public static class Driver
    {
        public static AppiumDriver<IWebElement> driver { get; set; }

        public static void WaitForElementUpTo(int seconds = 5)
        {
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(seconds));
        }
    }
}
