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
using CodedUIPossibilitiesPageObjects.Google;
using CodedUIPossibilitiesProject.Base;

namespace CodedUIPossibilitiesProject.Google
{
    [CodedUITest]
    public class GoogleTests : TestsBase
    {
        private static string url = "https://www.google.com";

        public GoogleTests() : base(url)
        {
        }

        [TestMethod()]
        public void ShouldSearchForGooglePhraseAndEnterIt()
        {
            var googleMainPage = new GoogleMainPage(driver);

            Assert.IsTrue(googleMainPage.CookiesPopup.IsLoaded());

            googleMainPage.CookiesPopup.ConfirmGoogleCookiesPopup();

            Assert.IsTrue(googleMainPage.IsLoaded());

            var googleSearchResultPage = googleMainPage.SearchGooglePhrase("Star Wars");

            Assert.IsTrue(googleSearchResultPage.IsLoaded());
        }
    }
}
