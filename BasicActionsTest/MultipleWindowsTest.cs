using System;
using System.Text;
using System.Collections.Generic;
using BasicActions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicActionsTest
{
    /// <summary>
    /// Summary description for MultipleWindowsTest
    /// </summary>
    [TestClass]
    public class MultipleWindowsTest :BaseTest
    {
        

        [TestMethod]
        public void SwitchWindowsTest()
        {

            HomePage.ManuSelecter("Multiple Windows");
            MultipleWindows.SwtichBetweenWindows();

            }

        [TestMethod]
        public void SwitchbBetweenTabsTest()
        {
            MultipleWindows.SwtichBetweenTabs();

        }

        [TestMethod]
        public void RightClickManuTest()
        {
            MultipleWindows.RightClickManu();

        }
    }
}
