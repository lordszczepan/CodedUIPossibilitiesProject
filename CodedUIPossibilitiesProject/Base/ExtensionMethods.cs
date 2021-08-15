using Microsoft.VisualStudio.TestTools.UITesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CodedUIPossibilitiesProject.Base
{
    public static class ExtensionMethods
    {
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool SetWindowsPos(IntPtr hWnd, IntPtr hwndInsertAfter, int x, int y, int cx, int cy, uint uFlags);

        public static void ResizeWindow(this BrowserWindow control, int width, int height)
        {
            SetWindowsPos(control.WindowHandle, (IntPtr)(-1), 0, 0, width, height, 0x0002 | 0x0040);
        }
    }
}
