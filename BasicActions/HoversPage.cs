using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicActionsFramework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace BasicActions
{
    public class HoversPage
    {
        public static void MouseHover()
        {
            IWebElement mainManu=  Driver.Instance.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/img"));
            IWebElement subManu = Driver.Instance.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/a"));
            Actions action = new Actions(Driver.Instance);
            action.MoveToElement(mainManu);
            action.MoveToElement(subManu).Click().Build().Perform();
        }
    }
}
