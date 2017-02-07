using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace ValTechTests 
{
    [TestFixture]
    public class Test
    {
        private IWebDriver driver;
        private string baseURL = "https://www.valtech.com/";


        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver(@"C:\selenium\");
        }

        [TearDown]
        public void TeardownTest()
        {
            driver.Quit();
        }

        [Test]
        public void TestLatestNewsSection()
        {
            IWebElement headingElement;
            string heading;

            driver.Navigate().GoToUrl(baseURL);
            headingElement = driver.FindElement(By.CssSelector("div.news-post__listing-header > header > h2.block-header__heading"));
            heading = headingElement.Text;
            Assert.AreEqual("LATEST NEWS", heading);
        }

        [Test]
        public void TestCasesHeading()
        {
            IWebElement headingElement;
            string heading;

            driver.Navigate().GoToUrl(baseURL);
            //Cases is the first element in the list of Top Level Navigation
            driver.FindElement(By.CssSelector("div.navigation__menu__bg > ul > li:nth-child(1)")).Click();

            headingElement = driver.FindElement(By.CssSelector("header.page-header > h1"));
            heading = headingElement.Text;
            Assert.AreEqual("Work", heading);
        }

        [Test]
        public void TestServicesHeading()
        {
            IWebElement headingElement;
            string heading;

            driver.Navigate().GoToUrl(baseURL);
            //Services is the second item in the list of Top Level Navigation
            driver.FindElement(By.CssSelector("div.navigation__menu__bg > ul > li:nth-child(2)")).Click();
            headingElement = driver.FindElement(By.CssSelector("header.page-header.article__heading > h1"));
            heading = headingElement.Text;
            Assert.AreEqual("Services", heading);
        }

        [Test]
        public void TestJobsHeading()
        {
            IWebElement headingElement;
            string heading;

            driver.Navigate().GoToUrl(baseURL);
            //Jobs / Carrers is the fifth item in the list of Top Level Navigation
            driver.FindElement(By.CssSelector("div.navigation__menu__bg > ul > li:nth-child(5)")).Click();
            headingElement = driver.FindElement(By.CssSelector("div.page-header > h1"));
            heading = headingElement.Text;
            Assert.AreEqual("Careers", heading);
        }

        [Test]
        public void TestCountNumberOfOffices()
        {
            IList<IWebElement> offices;

            driver.Navigate().GoToUrl(baseURL);
            //Jobs / Carrers is the fifth item in the list of Top Level Navigation
            driver.FindElement(By.CssSelector("div.hamburger__flip-container")).Click();

            //wait for sliding animation to finish so shows the offices around the world
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("p.contactheader")));

            offices = driver.FindElements(By.CssSelector("ul.contactcities > li"));

            System.Diagnostics.Debug.WriteLine("Number of Offices " + offices.Count.ToString());

        }

    }

}
