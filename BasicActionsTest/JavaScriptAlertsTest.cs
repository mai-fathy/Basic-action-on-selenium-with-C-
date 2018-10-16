using System;
using BasicActions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicActionsTest
{
    [TestClass]
    public class JavaScriptAlertsTest :BaseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            HomePage.ManuSelecter("JavaScript Alerts");
            JavaScriptClass.HandleJsAlerts();
        }



        [TestMethod]
        public void TestMethod2()
        {
            HomePage.ManuSelecter("JavaScript Alerts");
            JavaScriptClass.HandleJsAlertswithSendKey();
        }
    }
}
