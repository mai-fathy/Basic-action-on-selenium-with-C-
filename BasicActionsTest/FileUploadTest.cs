using System;
using BasicActions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicActionsTest
{
    [TestClass]
    public class FileUploadTest :BaseTest
    {
        [TestMethod]
        public void UploadfileTest()
        {
            HomePage.ManuSelecter("File Upload");
            FileUpload.UplpadFileUsingIWebElement();

        }

        [TestMethod]
        public void UploadfileTest2()
        {
            HomePage.ManuSelecter("File Upload");
            FileUpload.UplpadFileUsingSendKey();

        }
    }
}
