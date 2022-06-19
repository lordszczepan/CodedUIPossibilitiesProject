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
    public class WikipediaArticlePage : SharedActionsAndElements
    {
        public WikipediaArticlePage(BrowserWindow BrowserWindow) : base(BrowserWindow)
        {
        }

        #region Properties
        public HtmlDiv NavPanel
        {
            get
            {
                if ((this.mNavPanel == null))
                {
                    this.mNavPanel = new HtmlDiv(browserWindow);
                    this.mNavPanel.SearchProperties[HtmlDiv.PropertyNames.Id] = "mw-head";
                    this.mNavPanel.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "id=\"mw-head\"";
                    this.mNavPanel.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "24";
                }
                return this.mNavPanel;
            }
        }
        public HtmlControl HtmlControlMainTitle
        {
            get
            {
                if ((this.mHtmlControlMainTitle == null))
                {
                    this.mHtmlControlMainTitle = new HtmlControl(browserWindow);
                    this.mHtmlControlMainTitle.SearchProperties[HtmlControl.PropertyNames.Id] = "firstHeading";
                }
                return this.mHtmlControlMainTitle;
            }
        }
        public HtmlHyperlink UIArtykulHyperlink
        {
            get
            {
                if ((this.mUIArtykulHyperlink == null))
                {
                    this.mUIArtykulHyperlink = new HtmlHyperlink(browserWindow);
                    this.mUIArtykulHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Artykuł";
                    this.mUIArtykulHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = "Zobacz stronę treści [alt-c]";
                    this.mUIArtykulHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "title=\"Zobacz stronę treści [alt-c]\" acc";
                    this.mUIArtykulHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "1";
                }
                return this.mUIArtykulHyperlink;
            }
        }
        #endregion

        #region Fields
        private HtmlDiv mNavPanel;
        private HtmlControl mHtmlControlMainTitle;
        private HtmlHyperlink mUIArtykulHyperlink;
        #endregion

        public override bool IsLoaded()
        {
            return this.HtmlControlMainTitle.Exists;
        }

        public string ReturnArticleTitle()
        {
            return HtmlControlMainTitle.GetElementText().Replace("[edytuj]", "");
        }
        
    }
}
