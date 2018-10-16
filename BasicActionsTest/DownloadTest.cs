using System;
using BasicActions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicActionsTest
{
    [TestClass]
    public class DownloadTest :BaseTest
    {
        [TestMethod]
        public void DownloadTestUsingSendKey()

        {
            HomePage.ManuSelecter("File Download");
            DownloadPage.DownloadFile();
        }
    }
}
