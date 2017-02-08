﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ValtechTest.PageObjects
{
    public abstract class BasePage
    {
        protected IWebDriver driver;
        protected string baseURL = "https://www.valtech.com/";

        protected BasePage(IWebDriver browser)
        {
            this.driver = browser;
        }

        public void openPageLink(string cssLocation)
        {
            driver.Navigate().GoToUrl(baseURL);
            driver.FindElement(By.CssSelector(cssLocation)).Click();
        }
    }
}
