using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Interactions.Internal;

namespace Vermelhinha
{
    [TestClass]
    public class PageTest
    {

        [TestInitialize]
        public void Setup()
        {
            //Creating the reference for the Browser
            Properties.driver = new ChromeDriver();

            //Navigate to Getnet Page
            Properties.driver.Navigate().GoToUrl("https://site.getnet.com.br/");
            Properties.driver.Manage().Window.Maximize();
            Console.WriteLine("Opening the URL");
        }

        [TestMethod]
        [Owner("Marcos Couto")]
        [Priority(1)]
        [TestCategory("Positive")]
        [Description("Test Challenge proposed by CWI")]
        public void TestChallenge()
        {
            Console.WriteLine("Starting TestChallenge");
            PageMethods.MouseHoverSearch();
            PageMethods.TakeScreenshot();
            PageMethods.EnterText("fl-search-input", "vermelhinha", "Id");
            PageMethods.Click("fl-search-submit", "ClassName");
        }

        [TestMethod]
        [Owner("Marcos Couto")]
        [Priority(1)]
        [TestCategory("Negative")]
        [Description("Test User form without all the mandatory fields")]
        public void Ofertas()
        {
            Console.WriteLine("Starting the Test...");
            PageMethods.Click("c-peca-ja__button", "ClassName");
            PageMethods.Click("//*[@id='basic-user-form']/div/div[3]/div/span[2]", "XPath");
            PageMethods.EnterText("form-name", "Marcos Couto", "Id");
            PageMethods.EnterText("form-cpf", "92239366087", "Id");
            PageMethods.EnterText("form-birth-date", "22041976", "Id");
            PageMethods.EnterText("form-cellphone-number", "51998863224", "Id");
            PageMethods.EnterText("form-email", "marcouto@gmail.com", "Id");
            PageMethods.Click("submitButton", "Id");
            PageMethods.TakeScreenshot();
        }

        [TestCleanup]
        public void TearDown()
        {
            // Close the page
            Properties.driver.Quit();
            Console.WriteLine("Close the browser");
        }
    }
}
