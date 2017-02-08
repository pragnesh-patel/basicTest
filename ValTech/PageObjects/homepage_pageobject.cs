using System;
using OpenQA.Selenium;
using ValtechTest.PageObjects; 

namespace ValtechPages.PageObjects
{
    public class Homepage : BasePage
    {

        public Homepage(IWebDriver browser):base(browser)
        {
        }
        
        public string newsHeading()
        {
            IWebElement headingElement;

            driver.Navigate().GoToUrl(baseURL);
            headingElement = driver.FindElement(By.CssSelector("div.news-post__listing-header > header > h2.block-header__heading"));
            return headingElement.Text;
        }

    }
}
