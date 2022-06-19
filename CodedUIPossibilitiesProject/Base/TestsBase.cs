using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodedUIPossibilitiesProject.Base
{
    [CodedUITest]
    public abstract class TestsBase
    {
        protected BrowserWindow driver;
        private readonly string url;
        
        public TestsBase(string url)
        {
            this.url = url;
        }

        //Use TestInitialize to run code before running each test 
        [TestInitialize()]
        public void MyTestInitialize()
        {
            BrowserWindow.CurrentBrowser = "chrome";
            driver = BrowserWindow.Launch(new Uri(url));
            driver.Maximized = Properties.Settings.Default.Fullscreen;

            if (Properties.Settings.Default.Fullscreen == false)
            {
                driver.ResizeWindow(Properties.Settings.Default.Width, Properties.Settings.Default.Height);
            }
            
            Playback.PlaybackSettings.WaitForReadyLevel = WaitForReadyLevel.Disabled;
        }

        //Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public void MyTestCleanup()
        {
            driver.Close();
        }
    }
}
