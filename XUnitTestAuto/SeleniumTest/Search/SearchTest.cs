using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using Xunit;

namespace XUnitTestAuto.SeleniumTest.Search
{
    public class SearchTest
    {
        [Fact]
        public void SearchFirst()
        {
            SearchAction searchAction = new SearchAction();
            searchAction.NavigatetoURL("https://www.cheapoair.com/")
                .LocationFrom("BOM - Mumbai, India")
                .LocationTo("HOU - Houston All Airports, Texas, United States")
                .DateDepart("Nov 15 2019")
                .DateReturn("Jan 02 2020")
                .Adult("1")
                .Seniors("0")
                .Children("0")
                .FlightClass("Coach");

            searchAction.SearchNow();

        }

    }
}
