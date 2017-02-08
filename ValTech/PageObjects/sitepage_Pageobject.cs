using System;
using OpenQA.Selenium;
using ValtechTest.PageObjects;


namespace ValtechPages.PageObjects
{
    //This class can give page headings for CASES, SERVICES & JOBS pages
    class SitePage : BasePage
    {

        public SitePage(IWebDriver browser):base(browser)
        {
        }

        public string pageHeading()
        {
            IWebElement headingElement;
            headingElement = driver.FindElement(By.CssSelector(".page-header > h1"));
            return headingElement.Text;
        }
    }
}
