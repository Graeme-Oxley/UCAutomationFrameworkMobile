namespace AutoFramework
{
    using AutoFramework.Pages;
    using System.Threading;

    public static class NavigateTo
    {
        public static void LoginFormScenarioThroughTestCases()
        {
            MobileMenu menu = new MobileMenu();
            TestCasesPage tcPage = new TestCasesPage();
            UsernameCasePost ucPost = new UsernameCasePost();

            menu.OpenMenu.Click();
            Thread.Sleep(2000);
            menu.TestCases.Click();
            Thread.Sleep(2000);
            tcPage.UsernameCase.Click();
            Thread.Sleep(2000);
            ucPost.LoginFormLink.Click();
        }

        public static void LoginFormScenarioThroughMenu()
        {
            MobileMenu menu = new MobileMenu();
            TestScenariosPage tsPage = new TestScenariosPage();

            menu.OpenMenu.Click();
            Thread.Sleep(2000);
            menu.TestScenarios.Click();
            Thread.Sleep(2000);
            tsPage.LoginFormScenario.Click();
        }
    }
}
