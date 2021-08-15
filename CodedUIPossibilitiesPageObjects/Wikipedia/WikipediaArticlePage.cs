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
                    #region Search Criteria
                    this.mNavPanel.SearchProperties[HtmlDiv.PropertyNames.Id] = "mw-head";
                    this.mNavPanel.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "id=\"mw-head\"";
                    this.mNavPanel.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "24";
                    #endregion
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
                    #region Search Criteria
                    this.mHtmlControlMainTitle.SearchProperties[HtmlControl.PropertyNames.Id] = "firstHeading";
                    this.mHtmlControlMainTitle.SearchProperties[HtmlControl.PropertyNames.Class] = "firstHeading";

                    #endregion
                }
                return this.mHtmlControlMainTitle;
            }
        }
        #endregion

        #region Fields
        private HtmlDiv mNavPanel;
        private HtmlControl mHtmlControlMainTitle;        
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
