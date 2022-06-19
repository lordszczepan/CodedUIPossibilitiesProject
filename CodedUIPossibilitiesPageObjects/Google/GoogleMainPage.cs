using CodedUIPossibilitiesPageObjects.Google.Popups;
using CodedUIPossibilitiesPageObjects.SharedElements;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System;

namespace CodedUIPossibilitiesPageObjects.Google
{
    public class GoogleMainPage : SharedActionsAndElements
    {
        public GoogleMainPage(BrowserWindow browserWindow) : base(browserWindow)
        {
            CookiesPopup = new GoogleCookiesPopup(browserWindow);
        }

        public GoogleCookiesPopup CookiesPopup { get; }

        #region Properties
        public HtmlImage GoogleLogoImage
        {
            get
            {
                if (this.mGoogleLogoImage == null)
                {
                    this.mGoogleLogoImage = new HtmlImage(browserWindow);                   
                    this.mGoogleLogoImage.SearchProperties[HtmlImage.PropertyNames.Id] = "hplogo";
                    this.mGoogleLogoImage.SearchProperties[HtmlImage.PropertyNames.Class] = "lnXdpd";
                }
                return this.mGoogleLogoImage;
            }
        }

        public HtmlInputButton GoogleSearchButton
        {
            get
            {
                if ((this.mGoogleSearchButton == null))
                {
                    mGoogleSearchButton = new HtmlInputButton(browserWindow);
                    #region Search Criteria
                    this.mGoogleSearchButton.SearchProperties[HtmlButton.PropertyNames.Name] = "btnK";
                    this.mGoogleSearchButton.SearchProperties[HtmlButton.PropertyNames.DisplayText] = "Szukaj w Google";
                    this.mGoogleSearchButton.SearchProperties[HtmlButton.PropertyNames.Type] = "submit";
                    this.mGoogleSearchButton.SearchProperties[HtmlButton.PropertyNames.Class] = "gNO89b";
                    #endregion
                }
                return this.mGoogleSearchButton;
            }
        }

        public WinComboBox UISzukajComboBox
        {
            get
            {
                if ((this.mUISzukajComboBox == null))
                {
                    this.mUISzukajComboBox = new WinComboBox(browserWindow);
                    #region Search Criteria
                    this.mUISzukajComboBox.SearchProperties[WinComboBox.PropertyNames.Name] = "Szukaj";
                    this.mUISzukajComboBox.WindowTitles.Add("Google — Osobisty — Microsoft​ Edge");
                    #endregion
                }
                return this.mUISzukajComboBox;
            }
        }

        public WinButton UIGoogleOsobistyMicrosButton
        {
            get
            {
                if ((this.mUIGoogleOsobistyMicrosButton == null))
                {
                    this.mUIGoogleOsobistyMicrosButton = new WinButton(browserWindow);
                    #region Search Criteria
                    this.mUIGoogleOsobistyMicrosButton.SearchProperties[WinButton.PropertyNames.Name] = "Szukaj w Google";
                    #endregion
                }
                return this.mUIGoogleOsobistyMicrosButton;
            }
        }
        #endregion

        #region Fields
        private HtmlImage mGoogleLogoImage;
        private HtmlInputButton mGoogleSearchButton;
        private WinComboBox mUISzukajComboBox;
        private WinButton mUIGoogleOsobistyMicrosButton;
        #endregion


        #region Methods
        public override bool IsLoaded()
        {
            return GoogleLogoImage.Exists;
        }

        public GoogleSearchResultPage SearchGooglePhrase(string phrase)
        {
            UISzukajComboBox.SendKeys(phrase);
            UISzukajComboBox.SendKeys("{Esc}");
            UIGoogleOsobistyMicrosButton.Click();
            
            return new GoogleSearchResultPage(browserWindow);
        }
        #endregion
    }
}
