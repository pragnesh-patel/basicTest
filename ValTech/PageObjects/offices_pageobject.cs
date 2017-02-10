using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using ValtechTest.PageObjects;

namespace ValtechPages.PageObjects
{
    class OfficesPage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "ul.contactcities > li")]
        public IList<IWebElement> offices { get; set; }

        public OfficesPage(IWebDriver browser):base(browser)
        {
            PageFactory.InitElements(browser, this);
        }
         
        public void waitforAnimation()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("p.contactheader")));
        }

        public int numberOfOffices()
        {
            return offices.Count;
        }
    }
}
