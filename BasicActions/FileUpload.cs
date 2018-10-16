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
    public class FileUpload
    {
        public static void UplpadFileUsingIWebElement()
        {
            Driver.Instance.FindElement(By.Id("file-upload")).SendKeys("D:\\OtlobLogins.xlsx");
            Driver.Instance.FindElement(By.Id("file-submit")).Click();
           
        }

        public static void UplpadFileUsingSendKey()
        {
         Driver.Instance.FindElement(By.Id("file-upload")).Click();
            Thread.Sleep(3000);
            SendKeys.SendWait(@"D:\Accounts.xlsx");
            Thread.Sleep(3000);
         SendKeys.SendWait("{Enter}");
            Thread.Sleep(2000);
         Driver.Instance.FindElement(By.Id("file-submit")).Click();
        }
    }
}
