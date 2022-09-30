using GuideProject.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuideProject.PageObjects
{
    public class CompanyPage
    {
         IWebDriver driver;

        public CompanyPage()
        {
            driver = BaseTest.driver;
        }

        private By company = By.CssSelector("");
        private By contact = By.CssSelector("");
        private By country = By.CssSelector("");
        
        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);

        }

        public void Company(string companytxt)
        {
            driver.FindElement(company).SendKeys(companytxt);
        }






    }
}
