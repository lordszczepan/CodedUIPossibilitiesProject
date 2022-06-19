using CodedUIPossibilitiesPageObjects.SharedElements;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;

namespace CodedUIPossibilitiesPageObjects.Google.Popups
{
    public class GoogleCookiesPopup : SharedActionsAndElements
    {
        public GoogleCookiesPopup(BrowserWindow BrowserWindow) : base(BrowserWindow)
        {
        }

        #region Properties
        public HtmlDiv GoogleCookiesPopupModal
        {
            get
            {
                if (this.mGoogleCookiesPopupModal == null)
                {
                    this.mGoogleCookiesPopupModal = new HtmlDiv(browserWindow);
                    this.mGoogleCookiesPopupModal.SearchProperties[HtmlDiv.PropertyNames.Id] = "CXQnmb";
                    this.mGoogleCookiesPopupModal.SearchProperties[HtmlDiv.PropertyNames.Class] = "KxvlWc";
                }
                return this.mGoogleCookiesPopupModal;
            }
        }

        public HtmlButton GoogleCookiesPopupButton
        {
            get
            {
                if (this.mGoogleCookiesPopupButton == null)
                {
                    this.mGoogleCookiesPopupButton = new HtmlButton(browserWindow);
                    this.mGoogleCookiesPopupButton.SearchProperties[HtmlButton.PropertyNames.Id] = "L2AGLb";
                    this.mGoogleCookiesPopupButton.SearchProperties[HtmlButton.PropertyNames.Class] = "tHlp8d";
                }
                return this.mGoogleCookiesPopupButton;
            }
        }
        #endregion

        #region Fields
        private HtmlDiv mGoogleCookiesPopupModal;
        private HtmlButton mGoogleCookiesPopupButton;
        #endregion

        public override bool IsLoaded()
        {
            return GoogleCookiesPopupModal.Exists;
        }

        public void ConfirmGoogleCookiesPopup()
        {
            GoogleCookiesPopupButton.Click();
        }
    }
}
