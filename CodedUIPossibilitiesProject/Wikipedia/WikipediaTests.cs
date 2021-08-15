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

        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data.csv", "data#csv", DataAccessMethod.Sequential), DeploymentItem("data.csv"), TestMethod]
        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\xmlfile.xml", "xmlfile#xml", DataAccessMethod.Sequential), DeploymentItem("xmlfile.xml")]
        [TestMethod()]
        public void ShouldSearchForWikiPhraseAndEnterIt()
        {
            //string searchPhrase = "Testowanie eksploracyjne";
            string searchPhrase = TestContext.DataRow["WikiSearchPrases"].ToString();

            var wikiMainPage = new WikipediaMainPage(driver);

            Assert.IsTrue(wikiMainPage.IsLoaded());

            var wikiArticlePage = wikiMainPage.SearchAndEnterArticle(TestContext.DataRow["WikiSearchPrases"].ToString());

            Assert.IsTrue(wikiArticlePage.IsLoaded());

            Assert.AreEqual(searchPhrase, wikiArticlePage.ReturnArticleTitle());
        }

        
    }
}
