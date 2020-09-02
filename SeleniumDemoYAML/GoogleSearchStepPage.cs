using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using TechTalk.SpecFlow;

namespace SeleniumDemoYAML
{
    [Binding]
    public class GoogleSearchStepPage
    {
        public IWebDriver driver = null;
        [Given(@"User navigate to google search page")]
        public void GivenUserNavigateToGoogleSearchPage()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("headless");
             driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), chromeOptions);

            driver.Navigate().GoToUrl("https://google.com");
        }

        [When(@"User enters search item")]
        public void WhenUserEntersSearchItem()
        {
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("q")).SendKeys("Hello World");
        }

        [When(@"User Clicks on search button")]
        public void WhenUserClicksOnSearchButton()
        {
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("btnK")).SendKeys(Keys.Return);

            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        [Then(@"User should be able to see search item details")]
        public void ThenUserShouldBeAbleToSeeSearchItemDetails()
        {
           
        }

    }
}
