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
    public class GoogleMainPage : SharedActionsAndElements
    {
        public GoogleMainPage(BrowserWindow browserWindow) : base(browserWindow)
        {
        }
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

        public HtmlEdit GoogleSearchArea
        {
            get
            {
                if ((this.mGoogleSearchArea == null))
                {
                    this.mGoogleSearchArea = new HtmlEdit(browserWindow);
                    #region Search Criteria
                    this.mGoogleSearchArea.SearchProperties[HtmlEdit.PropertyNames.Name] = "q";
                    this.mGoogleSearchArea.SearchProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mGoogleSearchArea.FilterProperties[HtmlEdit.PropertyNames.Title] = "Szukaj";
                    this.mGoogleSearchArea.FilterProperties[HtmlEdit.PropertyNames.Class] = "gLFyf gsfi";
                    this.mGoogleSearchArea.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"q\" title=\"Szukaj\" class=\"gLFyf gsf";
                    this.mGoogleSearchArea.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "6";
                    this.mGoogleSearchArea.WindowTitles.Add("Google - Internet Explorer");
                    #endregion
                }
                return this.mGoogleSearchArea;
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
        #endregion

        #region Fields
        private HtmlImage mGoogleLogoImage;

        private HtmlEdit mGoogleSearchArea;

        private HtmlInputButton mGoogleSearchButton;
        #endregion


        #region Methods
        public override bool IsLoaded()
        {
            return this.GoogleLogoImage.Exists;
        }

        public GoogleSearchResultPage SearchGooglePhrase(string phrase)
        {

            this.GoogleSearchArea.SendKeys(phrase);
            this.GoogleSearchButton.Click();

            return new GoogleSearchResultPage(browserWindow);
        }
        #endregion
    }
}
