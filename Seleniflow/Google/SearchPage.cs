using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Seleniflow.Google
{
    public class SearchPage
    {
        public const string LogoId = "hplogo";

        public SearchPage(IWebDriver browser)
        {
            var driver = browser;
            PageFactory.InitElements(browser, this);
        }

        [FindsBy(How = How.Id, Using = LogoId)]
        public IWebElement Logo { get; set; }

    }
}
