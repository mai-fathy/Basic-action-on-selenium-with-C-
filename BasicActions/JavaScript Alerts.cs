using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicActionsFramework;
using OpenQA.Selenium;

namespace BasicActions
{
    public class JavaScriptClass
    {
        public static void HandleJsAlerts()
        {
            Driver.Instance.FindElement(By.XPath("/html/body/div[2]/div/div/ul/li[2]/button")).Click();
            IAlert alertDialog = Driver.Instance.SwitchTo().Alert();
            Console.WriteLine(alertDialog.Text);
            alertDialog.Dismiss();
           
        }

        public static void HandleJsAlertswithSendKey()
        {
            Driver.Instance.FindElement(By.XPath("/html/body/div[2]/div/div/ul/li[3]/button")).Click();
            IAlert alertDialog = Driver.Instance.SwitchTo().Alert();
            alertDialog.SendKeys("test");
            alertDialog.Accept();
        }
    }
}
