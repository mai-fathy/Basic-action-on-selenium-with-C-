using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicActionsFramework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BasicActions
{
    public class DropdownPage
    {
        public static void SelectItem()
        {
            IWebElement dropdwonElment = Driver.Instance.FindElement(By.Id("dropdown"));
            SelectElement element = new SelectElement(dropdwonElment);
            element.SelectByIndex(2);
        }
    }
}
