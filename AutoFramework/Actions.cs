namespace AutoFramework
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Appium.Android;
    using OpenQA.Selenium.Appium.Enums;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Remote;
    using Pages;
    using System;

    public static class Actions
    {
        public static void InitializeDriver()
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability(MobileCapabilityType.DeviceName, "device");
            capabilities.SetCapability(MobileCapabilityType.BrowserName, "Chrome");

            Driver.driver = new AndroidDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities);
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
            Driver.WaitForElementUpTo(Config.ElementsWaitingTimeout);
        }

        public static void FillLoginForm(string username, string password, string repeatPassword)
        {
            LoginScenarioPost loginScenario = new LoginScenarioPost();

            loginScenario.UsernameField.Clear();
            loginScenario.UsernameField.SendKeys(username);
            loginScenario.PasswordField.Clear();
            loginScenario.PasswordField.SendKeys(password);
            loginScenario.RepeatPasswordField.Clear();
            loginScenario.RepeatPasswordField.SendKeys(repeatPassword);
            loginScenario.LoginButton.Click();
        }
    }
}
