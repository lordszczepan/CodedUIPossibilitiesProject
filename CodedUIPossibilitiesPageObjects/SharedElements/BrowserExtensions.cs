using Microsoft.VisualStudio.TestTools.UITesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedUIPossibilitiesPageObjects.SharedElements
{
    public static class BrowserExtensions
    {
        public static void Click(this UITestControl control)
        {
            Mouse.Click(control);
        }

        public static void SendKeys(this UITestControl control, string text)
        {
            Keyboard.SendKeys(control, text);
        }
    }
}
