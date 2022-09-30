using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;
using TechTalk.SpecFlow;

namespace GuideProject.Hooks
{
    [Binding]
    public  class BaseTest
    {
        public static IWebDriver driver;

        [BeforeScenario()]
        public void BeforeScenario()


        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();
        }

        //[BeforeScenario()]
        //public void FirstBeforeScenario()
        //{
        //}

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
            driver.Dispose();
                
        }
    }
}