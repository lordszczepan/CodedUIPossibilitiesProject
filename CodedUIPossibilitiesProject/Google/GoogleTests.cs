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
using CodedUIPossibilitiesProject.Base;

namespace CodedUIPossibilitiesProject.Google
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>

    

    [CodedUITest]
    public class GoogleTests : TestsBase
    {
        private static string test_url = "https://www.google.com";

        public GoogleTests() : base(test_url)
        {
            
        }

        [TestMethod]
        public void ShouldSearchForGooglePhraseAndEnterIt_PageObject()
        {
            var googleMainPage = new GoogleMainPage(driver);

            Assert.IsTrue(googleMainPage.IsLoaded());

            var googleSearchResultPage = googleMainPage.SearchGooglePhrase("Star Wars");
        }
    }
}
