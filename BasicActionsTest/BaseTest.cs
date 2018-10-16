using System;
using BasicActionsFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicActionsTest
{
    [TestClass]
    public class BaseTest
    {
        private TestContext _testContextInstance; // create object from TestContext class

        public TestContext TestContext // create Property 
        {
            get { return _testContextInstance; }
            set { _testContextInstance = value; }
        }
        
        
        [TestInitialize]
        public void beforeTest()
        {
            Driver.Initialization();
        }

        [TestCleanup]
        public void takeScreenshot()
        {
            if (TestContext.CurrentTestOutcome != UnitTestOutcome.Passed) // check if the test not pass
            {
                Driver.TakeScreenshout(TestContext.TestName.ToString());
               

            }
           

            }

    }
}
