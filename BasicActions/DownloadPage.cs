using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicActionsFramework;
using OpenQA.Selenium;

namespace BasicActions
{
   public  class DownloadPage
    {
       public static void DownloadFile()
       {
          Driver.Instance.FindElement(By.XPath("/html/body/div[2]/div/div/a[1]")).Click();
           Thread.Sleep(2000);
           SendKeys.SendWait("{Enter}");
       }
    }
}
