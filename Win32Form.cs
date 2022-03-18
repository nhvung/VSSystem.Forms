using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace VSSystem.Forms
{
   public  class Win32Form
    {
        public const int SW_SHOWNORMAL = 1;
        public const int SW_SHOWMAXIMIZED = 3;
        public const int SW_RESTORE = 9;

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        const uint WM_SETTEXT = 0x000C;
        public const uint WM_CLOSE = 0x0010;

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string className, string windowTitle);

        [DllImport("user32.dll")]
        public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        public static extern bool MoveWindow(IntPtr Handle, int x, int y, int w, int h, bool repaint);

        public static readonly int GWL_STYLE = -16;
        public static readonly int WS_VISIBLE = 0x10000000;

        //SetText function
        public static void SetText(IntPtr HWnd, double strTextToSet)
        {
            IntPtr text = System.Runtime.InteropServices.Marshal.StringToCoTaskMemUni(strTextToSet.ToString("#0.00#"));
            SendMessage(HWnd, WM_SETTEXT, IntPtr.Zero, text);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(text);

        }

        public static void SetText(IntPtr HWnd, string strTextToSet)
        {
            IntPtr text = System.Runtime.InteropServices.Marshal.StringToCoTaskMemUni(strTextToSet);
            SendMessage(HWnd, WM_SETTEXT, IntPtr.Zero, text);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(text);

        }
    }
}
