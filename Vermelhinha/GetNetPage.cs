using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace Vermelhinha
{
    class GetnetPage
    {
        public GetnetPage()
        {
            PageFactory.InitElements(Properties.driver, this);
        }

        [FindsBy(How = How.Id, Using = "fl-search-input")]
        public IWebElement SearchInput { get; set; }

        [FindsBy(How = How.ClassName, Using = "fl-search-submit")]
        public IWebElement SearchSubmit { get; set; }

        [FindsBy(How = How.ClassName, Using = "ubermenu-target-title ubermenu-target-text")]
        public IWebElement FaleConosco { get; set; }
    }
}
