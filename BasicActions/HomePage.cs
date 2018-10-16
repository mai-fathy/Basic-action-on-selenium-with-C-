using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicActionsFramework;
using OpenQA.Selenium;

namespace BasicActions
{
    public class HomePage
    {
        

       public static void ManuSelecter(string link)
       {
           Driver.Instance.FindElement(By.LinkText(link)).Click();

       }
    }
}
