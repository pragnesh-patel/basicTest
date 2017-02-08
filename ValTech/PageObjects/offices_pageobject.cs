using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ValtechTest.PageObjects;

namespace ValtechPages.PageObjects
{
    class OfficesPage : BasePage
    {
        public OfficesPage(IWebDriver browser):base(browser)
        {
        }
         
        public void waitforAnimation()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("p.contactheader")));
        }

        public int numberOfOffices()
        {
            IList<IWebElement> offices;

            offices = driver.FindElements(By.CssSelector("ul.contactcities > li"));
            return offices.Count;

        }
    }
}
