﻿using CodedUIPossibilitiesPageObjects.Wikipedia;
using CodedUIPossibilitiesProject.Base;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedUIPossibilitiesProject.Wikipedia
{
    [CodedUITest]
    public class WikipediaTests : TestsBase
    {
        private static string url = "https://pl.wikipedia.org";

        public WikipediaTests() : base(url)
        {
        }

        [TestMethod]
        public void ShouldSearchForGooglePhraseAndEnterIt()
        {
            string searchPhrase = "Testowanie eksploracyjne";

            var wikiMainPage = new WikipediaMainPage(driver);

            Assert.IsTrue(wikiMainPage.IsLoaded());

            var wikiArticlePage = wikiMainPage.SearchAndEnterArticle(searchPhrase);

            Assert.IsTrue(wikiArticlePage.IsLoaded());

            Assert.AreEqual(searchPhrase, wikiArticlePage.ReturnArticleTitle());
        }
    }
}
