using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CodedUIPossibilitiesPageObjects.SharedElements
{

    public class SharedActionsAndElements
    {
        protected BrowserWindow browserWindow;

        public SharedActionsAndElements(BrowserWindow BrowserWindow)
        {
            this.browserWindow = BrowserWindow;
        }
    }
}
