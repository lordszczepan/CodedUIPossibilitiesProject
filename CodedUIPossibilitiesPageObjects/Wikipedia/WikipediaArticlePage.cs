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

        public HtmlLabel HtmlLabelMainTitle
        {
            get
            {
                if ((this.mHtmlLabelMainTitle == null))
                {
                    this.mHtmlLabelMainTitle = new HtmlLabel(browserWindow);
                    #region Search Criteria
                    this.mHtmlLabelMainTitle.SearchProperties[HtmlLabel.PropertyNames.Id] = "firstHeading";
                    this.mHtmlLabelMainTitle.SearchProperties[HtmlLabel.PropertyNames.Class] = "firstHeading";
                    
                    #endregion
                }
                return this.mHtmlLabelMainTitle;
            }
        }
        public HtmlAreaHyperlink HtmlAreaHyperlinkMainTitle
        {
            get
            {
                if ((this.mHtmlAreaHyperlinkMainTitle == null))
                {
                    this.mHtmlAreaHyperlinkMainTitle = new HtmlAreaHyperlink(browserWindow);
                    #region Search Criteria
                    this.mHtmlAreaHyperlinkMainTitle.SearchProperties[HtmlAreaHyperlink.PropertyNames.Id] = "firstHeading";
                    this.mHtmlAreaHyperlinkMainTitle.SearchProperties[HtmlAreaHyperlink.PropertyNames.Class] = "firstHeading";

                    #endregion
                }
                return this.mHtmlAreaHyperlinkMainTitle;
            }
        }
        public HtmlCell HtmlCellMainTitle
        {
            get
            {
                if ((this.mHtmlCellMainTitle == null))
                {
                    this.mHtmlCellMainTitle = new HtmlCell(browserWindow);
                    #region Search Criteria
                    this.mHtmlCellMainTitle.SearchProperties[HtmlCell.PropertyNames.Id] = "firstHeading";
                    this.mHtmlCellMainTitle.SearchProperties[HtmlCell.PropertyNames.Class] = "firstHeading";

                    #endregion
                }
                return this.mHtmlCellMainTitle;
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
        public HtmlCustom HtmlCustomMainTitle
        {
            get
            {
                if ((this.mHtmlCustomMainTitle == null))
                {
                    this.mHtmlCustomMainTitle = new HtmlCustom(browserWindow);
                    #region Search Criteria
                    this.mHtmlCustomMainTitle.SearchProperties[HtmlCustom.PropertyNames.Id] = "firstHeading";
                    this.mHtmlCustomMainTitle.SearchProperties[HtmlCustom.PropertyNames.Class] = "firstHeading";

                    #endregion
                }
                return this.mHtmlCustomMainTitle;
            }
        }
        public HtmlDiv HtmlDivMainTitle
        {
            get
            {
                if ((this.mHtmlDivMainTitle == null))
                {
                    this.mHtmlDivMainTitle = new HtmlDiv(browserWindow);
                    #region Search Criteria
                    this.mHtmlDivMainTitle.SearchProperties[HtmlDiv.PropertyNames.Id] = "firstHeading";
                    this.mHtmlDivMainTitle.SearchProperties[HtmlDiv.PropertyNames.Class] = "firstHeading";

                    #endregion
                }
                return this.mHtmlDivMainTitle;
            }
        }
        public HtmlDocument HtmlDocumentMainTitle
        {
            get
            {
                if ((this.mHtmlDocumentMainTitle == null))
                {
                    this.mHtmlDocumentMainTitle = new HtmlDocument(browserWindow);
                    #region Search Criteria
                    this.mHtmlDocumentMainTitle.SearchProperties[HtmlDiv.PropertyNames.Id] = "firstHeading";
                    this.mHtmlDocumentMainTitle.SearchProperties[HtmlDiv.PropertyNames.Class] = "firstHeading";

                    #endregion
                }
                return this.mHtmlDocumentMainTitle;
            }
        }
        public HtmlEdit HtmlEditMainTitle
        {
            get
            {
                if ((this.mHtmlEditMainTitle == null))
                {
                    this.mHtmlEditMainTitle = new HtmlEdit(browserWindow);
                    #region Search Criteria
                    this.mHtmlEditMainTitle.SearchProperties[HtmlEdit.PropertyNames.Id] = "firstHeading";
                    this.mHtmlEditMainTitle.SearchProperties[HtmlEdit.PropertyNames.Class] = "firstHeading";

                    #endregion
                }
                return this.mHtmlEditMainTitle;
            }
        }
        public HtmlEditableDiv HtmlEditableDivMainTitle
        {
            get
            {
                if ((this.mHtmlEditableDivMainTitle == null))
                {
                    this.mHtmlEditableDivMainTitle = new HtmlEditableDiv(browserWindow);
                    #region Search Criteria
                    this.mHtmlEditableDivMainTitle.SearchProperties[HtmlEditableDiv.PropertyNames.Id] = "firstHeading";
                    this.mHtmlEditableDivMainTitle.SearchProperties[HtmlEditableDiv.PropertyNames.Class] = "firstHeading";

                    #endregion
                }
                return this.mHtmlEditableDivMainTitle;
            }
        }
        public HtmlEditableSpan HtmlEditableSpanMainTitle
        {
            get
            {
                if ((this.mHtmlEditableSpanMainTitle == null))
                {
                    this.mHtmlEditableSpanMainTitle = new HtmlEditableSpan(browserWindow);
                    #region Search Criteria
                    this.mHtmlEditableSpanMainTitle.SearchProperties[HtmlEditableSpan.PropertyNames.Id] = "firstHeading";
                    this.mHtmlEditableSpanMainTitle.SearchProperties[HtmlEditableSpan.PropertyNames.Class] = "firstHeading";

                    #endregion
                }
                return this.mHtmlEditableSpanMainTitle;
            }
        }
        public HtmlFrame HtmlFrameMainTitle
        {
            get
            {
                if ((this.mHtmlFrameMainTitle == null))
                {
                    this.mHtmlFrameMainTitle = new HtmlFrame(browserWindow);
                    #region Search Criteria
                    this.mHtmlFrameMainTitle.SearchProperties[HtmlFrame.PropertyNames.Id] = "firstHeading";
                    this.mHtmlFrameMainTitle.SearchProperties[HtmlFrame.PropertyNames.Class] = "firstHeading";

                    #endregion
                }
                return this.mHtmlFrameMainTitle;
            }
        }
        public HtmlHeaderCell HtmlHeaderCellMainTitle
        {
            get
            {
                if ((this.mHtmlHeaderCellMainTitle == null))
                {
                    this.mHtmlHeaderCellMainTitle = new HtmlHeaderCell(browserWindow);
                    #region Search Criteria
                    this.mHtmlHeaderCellMainTitle.SearchProperties[HtmlHeaderCell.PropertyNames.Id] = "firstHeading";
                    this.mHtmlHeaderCellMainTitle.SearchProperties[HtmlHeaderCell.PropertyNames.Class] = "firstHeading";

                    #endregion
                }
                return this.mHtmlHeaderCellMainTitle;
            }
        }
        public HtmlHyperlink HtmlHyperlinkMainTitle
        {
            get
            {
                if ((this.mHtmlHyperlinkMainTitle == null))
                {
                    this.mHtmlHyperlinkMainTitle = new HtmlHyperlink(browserWindow);
                    #region Search Criteria
                    this.mHtmlHyperlinkMainTitle.SearchProperties[HtmlHyperlink.PropertyNames.Id] = "firstHeading";
                    this.mHtmlHyperlinkMainTitle.SearchProperties[HtmlHyperlink.PropertyNames.Class] = "firstHeading";

                    #endregion
                }
                return this.mHtmlHyperlinkMainTitle;
            }
        }
        public HtmlRow HtmlRowMainTitle
        {
            get
            {
                if ((this.mHtmlRowMainTitle == null))
                {
                    this.mHtmlRowMainTitle = new HtmlRow(browserWindow);
                    #region Search Criteria
                    this.mHtmlRowMainTitle.SearchProperties[HtmlRow.PropertyNames.Id] = "firstHeading";
                    this.mHtmlRowMainTitle.SearchProperties[HtmlRow.PropertyNames.Class] = "firstHeading";

                    #endregion
                }
                return this.mHtmlRowMainTitle;
            }
        }
        public HtmlSpan HtmlSpanMainTitle
        {
            get
            {
                if ((this.mHtmlSpanMainTitle == null))
                {
                    this.mHtmlSpanMainTitle = new HtmlSpan(browserWindow);
                    #region Search Criteria
                    this.mHtmlSpanMainTitle.SearchProperties[HtmlSpan.PropertyNames.Id] = "firstHeading";
                    this.mHtmlSpanMainTitle.SearchProperties[HtmlSpan.PropertyNames.Class] = "firstHeading";

                    #endregion
                }
                return this.mHtmlSpanMainTitle;
            }
        }
        #endregion

        #region Fields
        private HtmlDiv mNavPanel;
        private HtmlLabel mHtmlLabelMainTitle;
        private HtmlAreaHyperlink mHtmlAreaHyperlinkMainTitle;
        private HtmlCell mHtmlCellMainTitle;
        private HtmlControl mHtmlControlMainTitle;
        private HtmlCustom mHtmlCustomMainTitle;
        private HtmlDiv mHtmlDivMainTitle;
        private HtmlDocument mHtmlDocumentMainTitle;
        private HtmlEdit mHtmlEditMainTitle;
        private HtmlEditableDiv mHtmlEditableDivMainTitle;
        private HtmlEditableSpan mHtmlEditableSpanMainTitle;
        private HtmlFrame mHtmlFrameMainTitle;
        private HtmlHeaderCell mHtmlHeaderCellMainTitle;
        private HtmlHyperlink mHtmlHyperlinkMainTitle;
        private HtmlRow mHtmlRowMainTitle;
        private HtmlSpan mHtmlSpanMainTitle;
        #endregion

        public override bool IsLoaded()
        {
            return this.mHtmlLabelMainTitle.Exists;
        }

        public string ReturnHtmlLabelMainTitle()
        {
            return HtmlLabelMainTitle.GetElementText();
        }
        public string ReturnHtmlAreaHyperlinkMainTitle()
        {
            return HtmlAreaHyperlinkMainTitle.GetElementText();
        }
        public string ReturnHtmlCellMainTitle()
        {
            return HtmlCellMainTitle.GetElementText();
        }
        public string ReturnHtmlControlMainTitle()
        {
            return HtmlControlMainTitle.GetElementText().Trim();
        }
        public string ReturnHtmlCustomMainTitle()
        {
            return HtmlCustomMainTitle.GetElementText().Trim();
        }
        public string ReturnHtmlDivMainTitle()
        {
            return HtmlDivMainTitle.GetElementText();
        }
        public string ReturnHtmlDocumentMainTitle()
        {
            return HtmlDocumentMainTitle.GetElementText();
        }
        public string ReturnHtmlEditMainTitle()
        {
            return HtmlEditMainTitle.GetElementText();
        }
        public string ReturnHtmlEditableDivMainTitle()
        {
            return HtmlEditableDivMainTitle.GetElementText();
        }
        public string ReturnHtmlEditableSpanMainTitle()
        {
            return HtmlEditableSpanMainTitle.GetElementText();
        }
        public string ReturnHtmlFrameMainTitle()
        {
            return HtmlFrameMainTitle.GetElementText();
        }
        public string ReturnHtmlHeaderCellMainTitle()
        {
            return HtmlHeaderCellMainTitle.GetElementText();
        }
        public string ReturnHtmlHyperlinkMainTitle()
        {
            return HtmlHyperlinkMainTitle.GetElementText();
        }
        public string ReturnHtmlRowMainTitle()
        {
            return HtmlRowMainTitle.GetElementText();
        }
        public string ReturnHtmlSpanMainTitle()
        {
            return HtmlSpanMainTitle.GetElementText();
        }
        

        public bool IsLoaded(string articleTitle)
        {
            return articleTitle == ReturnHtmlLabelMainTitle();
        }
    }
}
