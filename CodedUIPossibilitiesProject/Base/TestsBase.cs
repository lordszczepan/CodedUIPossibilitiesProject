using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedUIPossibilitiesProject.Base
{
    [CodedUITest]
    public abstract class TestsBase
    {
        protected BrowserWindow driver;
        public readonly string url;

        public TestsBase(string url)
        {
            this.url = url;
        }

        #region Additional test attributes
        //Use TestInitialize to run code before running each test 
        [TestInitialize()]
        public void MyTestInitialize()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            driver = BrowserWindow.Launch(new Uri(url));
        }

        //Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public void MyTestCleanup()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            BrowserWindow.ClearCookies();
            driver.Close();
        }
        #endregion
    }
}
