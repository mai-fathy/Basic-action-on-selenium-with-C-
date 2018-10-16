using System;
using BasicActions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicActionsTest
{
    [TestClass]
    public class LoginTest :BaseTest
    {
        [TestMethod]
        public void IsDiaplayValdationMSGTest()
        {
            HomePage.ManuSelecter("Form Authentication");
            LoginPage.LoginAS("Mai.fathy@hindawi.com", "123456");
            Assert.IsTrue(LoginPage.GetMSA().Contains("Your username is invalid!"));
        }


        [TestMethod]
        public void Test_DataDriven()
        {
            HomePage.ManuSelecter("Form Authentication");
            LoginPage.LoginUsingDataDriven();
        }


        [TestMethod]
        public void Test_LoginPageFactory()
        {
            HomePage.ManuSelecter("Form Authentication");
            LoginPage.LoginWithPageFactory("mai.fathy@hindawi.com","12345");
        }

        [TestMethod]
        public void Test_LoginPageWebEs()
        {
            HomePage.ManuSelecter("Form Authentication");
            LoginPage.LoginWithLoginPageWebEs("mai.fathy@hindawi.com", "12345");
        }

    }
}
