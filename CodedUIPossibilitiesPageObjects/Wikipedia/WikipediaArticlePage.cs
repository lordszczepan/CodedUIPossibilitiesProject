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

        public HtmlLabel LabelMainTitle
        {
            get
            {
                if ((this.mLabelMainTitle == null))
                {
                    this.mLabelMainTitle = new HtmlLabel(browserWindow);
                    #region Search Criteria
                    this.mLabelMainTitle.SearchProperties[HtmlLabel.PropertyNames.Id] = "firstHeading";
                    this.mLabelMainTitle.FilterProperties[HtmlLabel.PropertyNames.Class] = "firstHeading";
                    
                    #endregion
                }
                return this.mLabelMainTitle;
            }
        }
        #endregion

        #region Fields
        private HtmlDiv mNavPanel;
        private HtmlLabel mLabelMainTitle;
        #endregion

        public override bool IsLoaded()
        {
            return this.LabelMainTitle.Exists;
        }

        public string ReturnArticleTitle()
        {
            return LabelMainTitle.GetElementText();
        }

        public bool IsLoaded(string articleTitle)
        {
            return articleTitle == ReturnArticleTitle();
        }
    }
}
