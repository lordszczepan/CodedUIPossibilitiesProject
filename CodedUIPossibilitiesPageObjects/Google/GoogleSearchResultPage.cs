using CodedUIPossibilitiesPageObjects.SharedElements;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedUIPossibilitiesPageObjects.Google
{
    public class GoogleSearchResultPage : SharedActionsAndElements
    {
        public GoogleSearchResultPage(BrowserWindow browserWindow) : base(browserWindow)
        {
        }

        #region Properties
        public HtmlDiv GoogleSearchResultBar
        {
            get
            {
                if (this.mGoogleSearchResultBar == null)
                {
                    this.mGoogleSearchResultBar = new HtmlDiv(browserWindow);
                    this.mGoogleSearchResultBar.SearchProperties[HtmlImage.PropertyNames.Id] = "sfcnt";
                    this.mGoogleSearchResultBar.SearchProperties[HtmlImage.PropertyNames.Class] = "dodTBe";
                }
                return this.mGoogleSearchResultBar;
            }
        }
        #endregion

        #region Fields
        private HtmlDiv mGoogleSearchResultBar;
        #endregion

        public override bool IsLoaded()
        {
            return this.GoogleSearchResultBar.Exists;
        }

    }
}
