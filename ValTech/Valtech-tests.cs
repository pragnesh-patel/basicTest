using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
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
            driver = new ChromeDriver();
        }

        [TearDown]
        public void TeardownTest()
        {
            driver.Quit();
        }

        [Test]
        public void TestLatestNewsSection()
        { 
            Homepage homepage = new Homepage(driver);
            Assert.AreEqual("LATEST NEWS",  homepage.newsHeading());
        }

        [Test]
        public void TestCasesHeading()
        {
            Homepage homepage = new Homepage(driver);
            homepage.casePageMenuItem.Click();
            SitePage casesPage = new SitePage(driver);

            Assert.AreEqual("Work", casesPage.pageHeading());
        }

        [Test]
        public void TestServicesHeading()
        {
            Homepage homepage = new Homepage(driver);
            homepage.servicesPageMenuItem.Click();
            SitePage servicesPage = new SitePage(driver);

            Assert.AreEqual("Services", servicesPage.pageHeading());
        }

        [Test]
        public void TestJobsHeading()
        {
            Homepage homepage = new Homepage(driver);
            homepage.jobsPageMenuItem.Click();
            SitePage jobsPage = new SitePage(driver);

            Assert.AreEqual("Careers", jobsPage.pageHeading());
        }

        [Test]
        public void TestCountNumberOfOffices()
        {
            Homepage homepage = new Homepage(driver);
            homepage.officesPageMenuItem.Click();
            OfficesPage officesPage = new OfficesPage(driver);

            officesPage.waitforAnimation();
            System.Diagnostics.Debug.WriteLine("Number of Offices " + officesPage.numberOfOffices().ToString());
        }

    }

}
