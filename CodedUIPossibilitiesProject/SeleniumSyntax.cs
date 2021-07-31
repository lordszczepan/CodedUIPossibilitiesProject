using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedUIPossibilitiesProject
{
    public static class SeleniumSyntax
    {
        public static HtmlControl FindElement(this BrowserWindow browserWindow, Func<BrowserWindow, HtmlControl> controlConstructorFunct)
        {
            return controlConstructorFunct(browserWindow);
        }

        public static UITestControlCollection FindElements(this BrowserWindow browserWindow, Func<BrowserWindow, HtmlControl> controlsConstructorFunct)
        {
            return controlsConstructorFunct(browserWindow).FindMatchingControls();
        }

        public static void Click(this UITestControl control)
        {
            Mouse.Click(control);
        }

        public static void SendKeys(this UITestControl control, string text)
        {
            Keyboard.SendKeys(control, text);
        }
    }

    public class By
    {
        public static Func<BrowserWindow, HtmlControl> Id(string id)
        {
            return (browserWindow) =>
            {
                var control = new HtmlControl(browserWindow);
                control.SearchProperties.Add(HtmlControl.PropertyNames.Id, id);
                return control;
            };
        }

        public static Func<BrowserWindow, HtmlControl> ClassName(string classNameToFind)
        {
            return (browserWindow) =>
            {
                var control = new HtmlControl(browserWindow);
                control.SearchProperties.Add(HtmlControl.PropertyNames.ClassName, classNameToFind);
                return control;
            };
        }
        public static Func<BrowserWindow, HtmlControl> CssSelector(string cssSelectorToFind)
        {
            return (browserWindow) =>
            {
                var control = new HtmlControl(browserWindow);
                control.SearchProperties.Add(HtmlControl.PropertyNames.Class, cssSelectorToFind, PropertyExpressionOperator.Contains);
                return control;
            };
        }
        public static Func<BrowserWindow, HtmlControl> Name(string nameToFind)
        {
            return (browserWindow) =>
            {
                var control = new HtmlControl(browserWindow);
                control.SearchProperties.Add(HtmlControl.PropertyNames.Name, nameToFind);
                return control;
            };
        }
        public static Func<BrowserWindow, HtmlControl> LinkText(string linkTextToFind)
        {
            return (browserWindow) =>
            {
                var control = new HtmlHyperlink(browserWindow);
                control.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, linkTextToFind);
                return control;
            };
        }
        public static Func<BrowserWindow, HtmlControl> PartialLinkText(string partialLinkTextToFind)
        {
            return (browserWindow) =>
            {
                var control = new HtmlControl(browserWindow);
                control.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, partialLinkTextToFind, PropertyExpressionOperator.Contains);
                return control;
            };
        }
        public static Func<BrowserWindow, HtmlControl> TagName(string tagNameToFind)
        {
            return (browserWindow) =>
            {
                var control = new HtmlControl(browserWindow);
                control.SearchProperties.Add(HtmlControl.PropertyNames.TagName, tagNameToFind);
                return control;
            };
        }
    }
}
