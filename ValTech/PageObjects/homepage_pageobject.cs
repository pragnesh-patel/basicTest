using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ValtechTest.PageObjects; 

namespace ValtechPages.PageObjects
{
    public class Homepage : BasePage
    {

        [FindsBy(How = How.CssSelector, Using = "div.navigation__menu__bg > ul > li:nth-child(1)")]
        public IWebElement casePageMenuItem { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.navigation__menu__bg > ul > li:nth-child(2)")]
        public IWebElement servicesPageMenuItem { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.navigation__menu__bg > ul > li:nth-child(5)")]
        public IWebElement jobsPageMenuItem { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.hamburger__flip-container")]
        public IWebElement officesPageMenuItem { get; set; }


        public Homepage(IWebDriver browser):base(browser)
        {
            driver.Navigate().GoToUrl(baseURL);
            PageFactory.InitElements(browser, this);
        }
        
        public string newsHeading()
        {
            IWebElement headingElement;

            headingElement = driver.FindElement(By.CssSelector("div.news-post__listing-header > header > h2.block-header__heading"));
            return headingElement.Text;
        }

    }
}
