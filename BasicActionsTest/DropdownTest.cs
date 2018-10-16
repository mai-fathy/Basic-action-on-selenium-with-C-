using System;
using BasicActions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicActionsTest
{
    [TestClass]
    public class DropdownTest :BaseTest
    {
        [TestMethod]
        public void DropdownListTest()
        {
            HomePage.ManuSelecter("Dropdown");
            DropdownPage.SelectItem();
        }
    }
}
