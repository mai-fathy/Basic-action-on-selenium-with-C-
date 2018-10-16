using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicActionsFramework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace BasicActions
{
  public  class MultipleWindows
    {
      public static void SwtichBetweenWindows()
      {
          var currentWindow = Driver.Instance.CurrentWindowHandle;
          Driver.Instance.FindElement(By.LinkText("Click Here")).Click();
           
          var availableWindows = new List<string>(Driver.Instance.WindowHandles);
          foreach (var availableWindow in availableWindows)
          {
              Driver.Instance.SwitchTo().Window(availableWindow);
          }
          if (Driver.Instance.Url.Contains("new"))
          {
              //Driver.Instance = new ChromeDriver(@"D:\chromedriver");
              //Driver.Instance.Navigate().GoToUrl("https://www.google.com.eg");
              Console.WriteLine("test");
          }
          
          Driver.Instance.SwitchTo().Window(currentWindow);

      }


      public static void SwtichBetweenTabs()
      {
          Driver.Instance.FindElement(By.CssSelector("body")).SendKeys(Keys.Control + "t");
          Driver.Instance.Navigate().GoToUrl("https://www.google.com.eg");
          Driver.Instance.FindElement(By.CssSelector("body")).SendKeys(Keys.Control + "\t");
          Driver.Instance.SwitchTo().DefaultContent();
          Driver.Instance.FindElement(By.LinkText("A/B Testing")).Click();
          Driver.Instance.FindElement(By.CssSelector("body")).SendKeys(Keys.Control + "\t");
          Driver.Instance.SwitchTo().DefaultContent();
          Driver.Instance.FindElement(By.Id("lst-ib")).SendKeys("test");

      }
    
      
      public static void RightClickManu()
      {
          IWebElement e = Driver.Instance.FindElement(By.LinkText("A/B Testing"));
          Actions action = new Actions(Driver.Instance);
          action.ContextClick(e).SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).SendKeys(Keys.Return).Build().Perform();
      }
   
  
  }
}
