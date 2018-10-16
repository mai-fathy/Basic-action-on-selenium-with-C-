using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BasicActions
{
  public class LoginPageFactory

    {
      [FindsBy(How = How.Id, Using = "username")]
      public IWebElement UserName { get; set; }


      [FindsBy(How = How.Id, Using = "password")]
      public IWebElement Password { get; set; }

      [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/button")]
      public IWebElement Loginbutton { get; set; }

    }
 }
