using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Input;

using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using CodedUIPossibilitiesPageObjects.Google;

namespace CodedUIPossibilitiesProject
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class GoogleTests_01
    {
        public GoogleTests_01()
        {
        }

        [TestMethod]
        public void ShouldSearchForGooglePhraseAndEnterIt()
        {
            var bw = BrowserWindow.Launch(new Uri("https://www.google.com"));

            HtmlEdit searchBox = new HtmlEdit(bw);
            searchBox.SearchProperties.Add(HtmlEdit.PropertyNames.Name, "q");
            Keyboard.SendKeys(searchBox, "Star Wars {Enter}");

            HtmlDiv searchResults = new HtmlDiv(bw);
            searchResults.SearchProperties.Add(HtmlDiv.PropertyNames.Id, "rso");

            HtmlHyperlink result = new HtmlHyperlink(searchResults);
            result.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, "Gwiezdne wojny", PropertyExpressionOperator.Contains);
            //result.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, "Gwiezdne wojny – Wikipedia, wolna encyklopediahttps://pl.wikipedia.org › wiki › Gwiezdne_wojny");

            Mouse.Click(result);
        }

        [TestMethod]
        public void ShouldSearchForGooglePhraseAndEnterIt_Selenium()
        {
            var driver = BrowserWindow.Launch(new Uri("https://www.google.com"));

            //var searchArea = driver.FindElement(By.CssSelector("input[name='q'][type='text']"));
            var searchArea = driver.FindElement(By.CssSelector("input[name='q']"));
            searchArea.SendKeys("Star Wars");

            var searchButton = driver.FindElement(By.CssSelector("div[jscontroller='W5mjOc'] > div > center > input[value='Szukaj w Google'][type='submit']"));
            searchButton.Click();
        }

        [TestMethod]
        public void ShouldSearchForGooglePhraseAndEnterIt_PageObject()
        {
            var driver = BrowserWindow.Launch(new Uri("https://www.google.com"));

            var googleMainPage = new GoogleMainPage(driver);

            var googleSearchResultPage = googleMainPage.SearchGooglePhraseAndEnter("Star Wars");
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if (this.map == null)
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
