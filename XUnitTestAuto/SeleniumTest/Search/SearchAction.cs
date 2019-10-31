using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Xunit;

namespace XUnitTestAuto.SeleniumTest.Search
{
    public class SearchAction
    {
        private IWebDriver driver = DriverFactory.GetChromeDriver();

        public SearchAction NavigatetoURL(string _url)
        {
            driver.Navigate().GoToUrl(_url);
            return this;

        }

        public SearchAction LocationFrom(string _from)
        {
            IWebElement from = driver.FindElement(By.XPath(
                 "//body[@class='chrome chrome-78']/div[@id='app']/main[@class='main-contents']/section[@class='banner']/div[@class='container']/div[@class='row']/div[@class='col-12 col-md-12 col-lg-7 col-xl-6 p-0 px-lg-3']/div[@class='widget__wrap']/div[@class='tab-content widget']/div[@class='tab-pane fade active show']/section[@class='segment']/div[@class='position-relative mt-1']/div/div[1]/input[1]"));
            from.SendKeys(_from);

            return this;
        }

        public SearchAction LocationTo(string _to)
        {
            IWebElement from = driver.FindElement(By.XPath(
                "//body[@class='chrome chrome-78']/div[@id='app']/main[@class='main-contents']/section[@class='banner']/div[@class='container']/div[@class='row']/div[@class='col-12 col-md-12 col-lg-7 col-xl-6 p-0 px-lg-3']/div[@class='widget__wrap']/div[@class='tab-content widget']/div[@class='tab-pane fade active show']/section[@class='segment']/div[@class='position-relative mt-1']/div/div[2]/input[1]"));
            from.SendKeys(_to);
            return this;
        }

        public SearchAction DateDepart(string _departDate)
        {


            IWebElement departDate = driver.FindElement(By.XPath(
                "/html[1]/body[1]/div[2]/main[1]/section[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[2]/div[1]/div[1]/input[1]"));
            departDate.SendKeys(_departDate);
            return this;
        }

        public SearchAction DateReturn(string _returnDate)
        {
            IWebElement returnDate = driver.FindElement(By.XPath(
                "/html[1]/body[1]/div[2]/main[1]/section[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[2]/div[2]/div[1]/input[1]"));
            returnDate.SendKeys(_returnDate);
            return this;
        }


        public SearchAction Adult(string _adult)
        {
            IWebElement adult = driver.FindElement(By.XPath(
                "//select[contains(@name,'Adults')]"));
            adult.SendKeys(_adult);
            return this;
        }

        public SearchAction Seniors(string _seniors)
        {
            IWebElement seniors = driver.FindElement(By.XPath(
                "//select[contains(@name,'Seniors')]"));
            seniors.SendKeys(_seniors);
            return this;
        }


        public SearchAction Youths(string _youths)
        {
            IWebElement youths = driver.FindElement(By.XPath(
                "//select[contains(@name,'Youths')]"));
            youths.SendKeys(_youths);
            return this;
        }

        public SearchAction Children(string _children)
        {
            IWebElement children = driver.FindElement(By.XPath(
                "//select[contains(@name,'Children')]"));
            children.SendKeys(_children);
            return this;
        }


        public SearchAction FlightClass(string _flightClass)
        {
            IWebElement flightClass = driver.FindElement(By.XPath(
                "//select[contains(@name,'Class')]"));
            flightClass.SendKeys(_flightClass);
            return this;
        }

        public void SearchNow()
        {

            IWebElement datecontrol = driver.FindElement(By.XPath(
                "//main[contains(@class,'main-contents')]"));
            datecontrol.Click();

            IWebElement searchNow = driver.FindElement(By.XPath(
                "//input[contains(@class,'button button-xl button-primary')]"));
            searchNow.Click();
        }


        public void DisposeWebDriver()
        {
            driver.Dispose();
        }
    }
}
