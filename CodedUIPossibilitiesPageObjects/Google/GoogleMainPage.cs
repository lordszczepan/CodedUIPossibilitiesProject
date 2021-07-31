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
        public HtmlEdit UISzukajEdit
        {
            get
            {
                if ((this.mUISzukajEdit == null))
                {
                    this.mUISzukajEdit = new HtmlEdit();
                    #region Search Criteria
                    this.mUISzukajEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = null;
                    this.mUISzukajEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "q";
                    this.mUISzukajEdit.SearchProperties[HtmlEdit.PropertyNames.LabeledBy] = null;
                    this.mUISzukajEdit.SearchProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUISzukajEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = "Szukaj";
                    this.mUISzukajEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "gLFyf gsfi";
                    this.mUISzukajEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"q\" title=\"Szukaj\" class=\"gLFyf gsf";
                    this.mUISzukajEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "6";
                    this.mUISzukajEdit.WindowTitles.Add("Google - Internet Explorer");
                    #endregion
                }
                return this.mUISzukajEdit;
            }
        }

        public HtmlInputButton UISzukajwGoogleButton
        {
            get
            {
                if ((this.mUISzukajwGoogleButton == null))
                {
                    mUISzukajwGoogleButton = new HtmlInputButton();
                    #region Search Criteria
                    this.mUISzukajwGoogleButton.SearchProperties[HtmlButton.PropertyNames.Id] = null;
                    this.mUISzukajwGoogleButton.SearchProperties[HtmlButton.PropertyNames.Name] = "btnK";
                    this.mUISzukajwGoogleButton.SearchProperties[HtmlButton.PropertyNames.DisplayText] = "Szukaj w Google";
                    this.mUISzukajwGoogleButton.SearchProperties[HtmlButton.PropertyNames.Type] = "submit";
                    this.mUISzukajwGoogleButton.FilterProperties[HtmlButton.PropertyNames.Title] = null;
                    this.mUISzukajwGoogleButton.FilterProperties[HtmlButton.PropertyNames.Class] = "gNO89b";
                    this.mUISzukajwGoogleButton.FilterProperties[HtmlButton.PropertyNames.ControlDefinition] = "name=\"btnK\" class=\"gNO89b\" aria-label=\"S";
                    this.mUISzukajwGoogleButton.FilterProperties[HtmlButton.PropertyNames.TagInstance] = "9";
                    this.mUISzukajwGoogleButton.WindowTitles.Add("Google - Internet Explorer");
                    #endregion
                }
                return this.mUISzukajwGoogleButton;
            }
        }
        #endregion

        #region Fields
        private HtmlEdit mUISzukajEdit;

        private HtmlInputButton mUISzukajwGoogleButton;
        #endregion

        public GoogleSearchResultPage SearchGooglePhraseAndEnter(string phrase)
        {

            UISzukajEdit.SendKeys(phrase);
            UISzukajwGoogleButton.Click();

            return new GoogleSearchResultPage(browserWindow);
        }
    }
}
