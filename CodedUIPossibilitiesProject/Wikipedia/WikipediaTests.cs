using CodedUIPossibilitiesPageObjects.Wikipedia;
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
        public void ShouldSearchForWikiPhraseAndEnterIt()
        {
            string searchPhrase = "Testowanie eksploracyjne";

            var wikiMainPage = new WikipediaMainPage(driver);

            Assert.IsTrue(wikiMainPage.IsLoaded());

            var wikiArticlePage = wikiMainPage.SearchAndEnterArticle(searchPhrase);

            //Assert.IsTrue(wikiArticlePage.IsLoaded());

            string message = "";
            try
            {
                message = $"{message}{Environment.NewLine}1: {wikiArticlePage.ReturnHtmlLabelMainTitle()}";
            }
            catch {}

            try
            {
                message = $"{message}{Environment.NewLine}2: {wikiArticlePage.ReturnHtmlAreaHyperlinkMainTitle()}";
            }
            catch { }
            
            try
            {
                message = $"{message}{Environment.NewLine}3: {wikiArticlePage.ReturnHtmlCellMainTitle()}";
            }
            catch { }
            
            try
            {
                message = $"{message}{Environment.NewLine}4: {wikiArticlePage.ReturnHtmlControlMainTitle()}";
            }
            catch { }
            
            try
            {
                message = $"{message}{Environment.NewLine}5: {wikiArticlePage.ReturnHtmlCustomMainTitle()}";
            }
            catch { }
            
            try
            {
                message = $"{message}{Environment.NewLine}6: {wikiArticlePage.ReturnHtmlDivMainTitle()}";
            }
            catch { }
            
            try
            {
                message = $"{message}{Environment.NewLine}7: {wikiArticlePage.ReturnHtmlDocumentMainTitle()}";
            }
            catch { }
            
            try
            {
                message = $"{message}{Environment.NewLine}8: {wikiArticlePage.ReturnHtmlEditMainTitle()}";
            }
            catch { }
            
            try
            {
                message = $"{message}{Environment.NewLine}9: {wikiArticlePage.ReturnHtmlEditableDivMainTitle()}";
            }
            catch { }
            
            try
            {
                message = $"{message}{Environment.NewLine}10: {wikiArticlePage.ReturnHtmlEditableSpanMainTitle()}";
            }
            catch { }
            
            try
            {
                message = $"{message}{Environment.NewLine}11: {wikiArticlePage.ReturnHtmlFrameMainTitle()}";
            }
            catch { }
            
            try
            {
                message = $"{message}{Environment.NewLine}12: {wikiArticlePage.ReturnHtmlHeaderCellMainTitle()}";
            }
            catch { }
            
            try
            {
                message = $"{message}{Environment.NewLine}13: {wikiArticlePage.ReturnHtmlHyperlinkMainTitle()}";
            }
            catch { }
            
            try
            {
                message = $"{message}{Environment.NewLine}14: {wikiArticlePage.ReturnHtmlRowMainTitle()}";
            }
            catch { }
            
            try
            {
                message = $"{message}{Environment.NewLine}15: {wikiArticlePage.ReturnHtmlSpanMainTitle()}";
            }
            catch { }
            
            throw new Exception(message);

            //Assert.AreEqual(searchPhrase, wikiArticlePage.ReturnArticleTitle());
        }
    }
}
