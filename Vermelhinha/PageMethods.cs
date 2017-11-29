using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support;
using System.Drawing;
using System.Drawing.Imaging;

namespace Vermelhinha
{
    public class PageMethods
    {

        public static void TakeScreenshot()
        {
            Screenshot ss = ((ITakesScreenshot)Properties.driver).GetScreenshot();
            ss.SaveAsFile(@"C:\Temp\sample.png", ScreenshotImageFormat.Png);
        }
                
        //Method to perform a "mousehover" in the magnifying glass to open the search field and Click()
        public static void MouseHoverSearch()
        {
            IWebElement mg = Properties.driver.FindElement(By.XPath("//*[@id='ubermenu-nav-main-6-primary']"));
            IWebElement submg = Properties.driver.FindElement(By.XPath("(//*[@id='ubermenu-nav-main-6-primary']/li[6]/div/a)[2]"));

            Actions action1 = new Actions(Properties.driver);
            action1.MoveToElement(mg).Perform();
            action1.MoveToElement(submg).Perform();

            //IJavaScriptExecutor js = (IJavaScriptExecutor)Properties.driver;
            //js.ExecuteScript("arguments[0].click();", submg);

        }

        //Method for enter a text in a Textbox
        public static void EnterText(string element, string value, string elementtype)
        {
            if (elementtype == "Id")
                Properties.driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == "Name")
                Properties.driver.FindElement(By.Name(element)).SendKeys(value);
        }

        //Method for click in a button, checkbox, option etc...
        public static void Click(string element, string elementtype)
        {
            if (elementtype == "Id")
                Properties.driver.FindElement(By.Id(element)).Click();
            if (elementtype == "Name")
                Properties.driver.FindElement(By.Name(element)).Click();
            if (elementtype == "ClassName")
                Properties.driver.FindElement(By.ClassName(element)).Click();
            if (elementtype == "XPath")
                Properties.driver.FindElement(By.XPath(element)).Click();
        }

    }
}
