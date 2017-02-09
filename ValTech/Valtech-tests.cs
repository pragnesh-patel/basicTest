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
            Homepage homepage = new Homepage(driver);
            Assert.AreEqual("LATEST NEWS",  homepage.newsHeading());
        }

        [Test]
        public void TestCasesHeading()
        {
            Homepage homepage = new Homepage(driver);
            SitePage casesPage = new SitePage(driver);
            //Cases is the first item in the list of Top Level Navigation of homepage
            casesPage.openPageLink(homepage.casePageMenuItem);

            Assert.AreEqual("Work", casesPage.pageHeading());
        }

        [Test]
        public void TestServicesHeading()
        {
            Homepage homepage = new Homepage(driver);
            SitePage servicesPage = new SitePage(driver);
            //Services is the second item in the list of Top Level Navigation
            servicesPage.openPageLink(homepage.servicesPageMenuItem);

            Assert.AreEqual("Services", servicesPage.pageHeading());
        }

        [Test]
        public void TestJobsHeading()
        {
            Homepage homepage = new Homepage(driver);
            SitePage jobsPage = new SitePage(driver);
            //Jobs / Careers is the fifth item in the list of Top Level Navigation
            jobsPage.openPageLink(homepage.jobsPageMenuItem);

            Assert.AreEqual("Careers", jobsPage.pageHeading());
        }

        [Test]
        public void TestCountNumberOfOffices()
        {
            Homepage homepage = new Homepage(driver);
            OfficesPage officesPage = new OfficesPage(driver);

            officesPage.openPageLink(homepage.officesPageMenuItem);
            officesPage.waitforAnimation();
            System.Diagnostics.Debug.WriteLine("Number of Offices " + officesPage.numberOfOffices().ToString());
        }

    }

}
