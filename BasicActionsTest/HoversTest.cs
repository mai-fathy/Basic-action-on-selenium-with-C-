using System;
using BasicActions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicActionsTest
{
    [TestClass]
    public class HoversTest :BaseTest

    {
        [TestMethod]
        public void HoverTest()
        {
            HomePage.ManuSelecter("Hovers");
            HoversPage.MouseHover();
        }
    }
}
