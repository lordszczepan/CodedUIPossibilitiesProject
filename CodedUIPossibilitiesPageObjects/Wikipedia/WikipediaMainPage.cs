using CodedUIPossibilitiesPageObjects.SharedElements;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedUIPossibilitiesPageObjects.Wikipedia
{
    public class WikipediaMainPage : SharedActionsAndElements
    {
        public WikipediaTopBar TopBar { get; }

        public WikipediaMainPage(BrowserWindow BrowserWindow) : base(BrowserWindow)
        {
            TopBar = new WikipediaTopBar(browserWindow);
        }

        #region Properties
        public HtmlDiv DivPageHeader
        {
            get
            {
                if (this.mDivPageHeader == null)
                {
                    this.mDivPageHeader = new HtmlDiv(browserWindow);
                    this.mDivPageHeader.SearchProperties[HtmlDiv.PropertyNames.Id] = "main-page-header";
                    this.mDivPageHeader.SearchProperties[HtmlDiv.PropertyNames.Class] = "header nomobile";

                }
                return this.mDivPageHeader;
            }
        }

        public HtmlEdit TextBoxSearch
        {
            get
            {
                if (this.mTextBoxSearch == null)
                {
                    this.mTextBoxSearch = new HtmlEdit(browserWindow);
                    this.mTextBoxSearch.SearchProperties[HtmlEdit.PropertyNames.Id] = "searchInput";
                    //this.mTextBoxSearch.SearchProperties[HtmlEdit.PropertyNames.Id] = "searchInput";
                    this.mTextBoxSearch.SearchProperties[HtmlEdit.PropertyNames.Name] = "search";
                    this.mTextBoxSearch.SearchProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";

                }
                return this.mTextBoxSearch;
            }
        }
        #endregion

        #region Fields
        private HtmlDiv mDivPageHeader;
        private HtmlEdit mTextBoxSearch;
        #endregion

        public override bool IsLoaded()
        {
            return this.DivPageHeader.Exists;
        }

        public WikipediaArticlePage SearchAndEnterArticle(string searchText)
        {
            TextBoxSearch.SendKeys(searchText + "{Enter}");

            return new WikipediaArticlePage(browserWindow);
        }
    }
}
