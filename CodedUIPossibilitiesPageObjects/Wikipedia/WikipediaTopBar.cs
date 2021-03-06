using CodedUIPossibilitiesPageObjects.SharedElements;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;

namespace CodedUIPossibilitiesPageObjects.Wikipedia
{
    public class WikipediaTopBar : SharedActionsAndElements
    {
        public WikipediaTopBar(BrowserWindow BrowserWindow) : base(BrowserWindow)
        {
        }
        #region Properties
        public HtmlCustom ContentList
        {
            get
            {
                if ((this.mContentList == null))
                {
                    this.mContentList = new HtmlCustom(browserWindow);
                    #region Search Criteria
                    this.mContentList.SearchProperties["TagName"] = "UL";
                    this.mContentList.SearchProperties["Class"] = "vector-menu-content-list";
                    #endregion
                }
                return this.mContentList;
            }
        }
        public HtmlHyperlink HyperlinkLogin
        {
            get
            {
                if ((this.mHyperlinkLogin == null))
                {
                    this.mHyperlinkLogin = new HtmlHyperlink(browserWindow);
                    #region Search Criteria
                    this.mHyperlinkLogin.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Zaloguj się";
                    this.mHyperlinkLogin.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/w/index.php";
                    this.mHyperlinkLogin.FilterProperties[HtmlHyperlink.PropertyNames.Title] = "Zachęcamy do zalogowania się, choć nie jest to obowiązkowe. [alt-o]";
                    this.mHyperlinkLogin.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "1";
                    #endregion
                }
                return this.mHyperlinkLogin;
            }
        }
        #endregion

        #region Fields
        private HtmlCustom mContentList;
        private HtmlHyperlink mHyperlinkLogin;
        #endregion

        public override bool IsLoaded()
        {
            return this.ContentList.Exists;
        }
    }
}
