using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.Extensions;

namespace BasicActionsFramework
{
    public class Driver
    {
        public static IWebDriver Instance ;

        public static void Initialization()
        {
            Instance = new FirefoxDriver();
            Instance.Manage().Window.Maximize();
            Instance.Navigate().GoToUrl("http://the-internet.herokuapp.com/");
        }


        public static void TakeScreenshout(string screenshotName)
        {
            var screenShot = Driver.Instance.TakeScreenshot();
            screenShot.SaveAsFile("D:\\" + screenshotName + ".png", ScreenshotImageFormat.Png);
            // Console.WriteLine("Ok");
        }
    }
}
