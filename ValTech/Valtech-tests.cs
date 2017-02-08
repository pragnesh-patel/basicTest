using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using ValtechPages.PageObjects;

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
            driver.Navigate().GoToUrl(baseURL); 
            Homepage homepage = new Homepage(driver);
            Assert.AreEqual("LATEST NEWS",  homepage.newsHeading());
        }

        [Test]
        public void TestCasesHeading()
        {
            SitePage casesPage = new SitePage(driver);
            //Cases is the first item in the list of Top Level Navigation of homepage
            casesPage.openPageLink("div.navigation__menu__bg > ul > li:nth-child(1)");

            Assert.AreEqual("Work", casesPage.pageHeading());
        }

        [Test]
        public void TestServicesHeading()
        {
            SitePage servicesPage = new SitePage(driver);
            //Services is the second item in the list of Top Level Navigation
            servicesPage.openPageLink("div.navigation__menu__bg > ul > li:nth-child(2)");

            Assert.AreEqual("Services", servicesPage.pageHeading());
        }

        [Test]
        public void TestJobsHeading()
        {
            SitePage jobsPage = new SitePage(driver);
            //Jobs / Careers is the fifth item in the list of Top Level Navigation
            jobsPage.openPageLink("div.navigation__menu__bg > ul > li:nth-child(5)");

            Assert.AreEqual("Careers", jobsPage.pageHeading());
        }

        [Test]
        public void TestCountNumberOfOffices()
        {
            IList<IWebElement> offices;

            OfficesPage officesPage = new OfficesPage(driver);
            //Jobs / Careers is the fifth item in the list of Top Level Navigation
            officesPage.openPageLink("div.hamburger__flip-container");
            officesPage.waitforAnimation();
            System.Diagnostics.Debug.WriteLine("Number of Offices " + officesPage.numberOfOffices().ToString());

        }

    }

}
