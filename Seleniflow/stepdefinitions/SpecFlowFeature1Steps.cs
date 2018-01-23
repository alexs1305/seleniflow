﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using Seleniflow.Google;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Seleniflow.stepdefinitions
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        private IWebDriver driver;
        private SearchPage searchPage;

        public SpecFlowFeature1Steps()
        {
            driver = new ChromeDriver(@"C:\Users\alexs\source\repos\Seleniflow\Seleniflow\drivers");
            searchPage = new SearchPage(driver);
        }

        [Given(@"I navigate to the page ""(.*)""")]
        public void GivenINavigateToThePage(string page)
        {
            driver.Navigate().GoToUrl(page);
        }
        
        [Given(@"I see the page is loaded")]
        public void GivenISeeThePageIsLoaded()
        {
            Assert.IsTrue(searchPage.Logo.Displayed);


        }
        
        [When(@"I enter Search Keyword in the Search Text box")]
        public void WhenIEnterSearchKeywordInTheSearchTextBox()
        {
            
        }
        
        [When(@"I click on Search Button")]
        public void WhenIClickOnSearchButton()
        {
            
        }
        
        [Then(@"Search items shows the items related to SpecFlow")]
        public void ThenSearchItemsShowsTheItemsRelatedToSpecFlow()
        {
            
        }

        [Then(@"Googles logo should be visible")]
        public void ThenGooglesLogoShouldBeVisible()
        {

        }

        [AfterScenario()]
        public void TearDown()
        {
            driver.Close();
            driver.Dispose();
        }

    }
}
