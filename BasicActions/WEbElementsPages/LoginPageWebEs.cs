using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicActionsFramework;
using OpenQA.Selenium;

namespace BasicActions
{
     public class LoginPageWebEs

     {
         public IWebElement UserName = Driver.Instance.FindElement(By.Id("username"));
         public IWebElement Password = Driver.Instance.FindElement(By.Id("password"));
         public IWebElement LoginB = Driver.Instance.FindElement(By.XPath("/html/body/div[2]/div/div/form/button"));

     }
}
