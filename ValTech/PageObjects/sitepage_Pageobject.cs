using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ValtechTest.PageObjects;


namespace ValtechPages.PageObjects
{
    //This class can give page headings for CASES, SERVICES & JOBS pages
    class SitePage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = ".page-header > h1")]
        public IWebElement headingElement { get; set; }

        public SitePage(IWebDriver browser):base(browser)
        {
            PageFactory.InitElements(browser, this);
        }

        public string pageHeading()
        {
            return headingElement.Text;
        }
    }
}
