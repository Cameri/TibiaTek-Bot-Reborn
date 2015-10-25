using System;
using System.Runtime.InteropServices; // for DllImport

namespace TibiaTekBot
{
    public static class Windows
    {
        #region Enumerations

        [Flags()]
        public enum FlashWindowFlags : uint
        {
            FLASHW_STOP = 0,
            FLASHW_CAPTION = 1,
            FLASHW_TRAY = 2,
            FLASHW_TIMER = 4,
            FLASHW_TIMERNOFG = 12
        }

        public enum ShowStates : uint
        {
            SW_FORCEMINIMIZE = 11,
            SW_HIDE = 0,
            SW_MAXIMIZE = 3,
            SW_MINIMIZE = 6,
            SW_RESTORE = 9,
            SW_SHOW = 5,
            SW_SHOWDEFAULT = 10,
            SW_SHOWMAXIMIZED = 3,
            SW_SHOWMINIMIZED = 2,
            SW_SHOWMINNOACTIVE = 7,
            SW_SHOWNA = 8,
            SW_SHOWNOACTIVATE = 4,
            SW_SHOWNORMAL = 1
        }
        #endregion

        #region Structures
        [StructLayout(LayoutKind.Sequential)]
        public struct FlashWindowInfo
        {
            public uint cbSize;
            public IntPtr hWnd;
            public FlashWindowFlags dwFlags;
            public uint uCount;
            public uint dwTimeout;

            public FlashWindowInfo(IntPtr Handle, FlashWindowFlags Flags, uint Count, uint Timeout)
            {
                hWnd = Handle;
                cbSize = (uint)Marshal.SizeOf(typeof(FlashWindowInfo));
                dwFlags = Flags;
                uCount = Count;
                dwTimeout = Timeout;
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct WindowPlacement
        {
            public uint length;
            public uint flags;
            public ShowStates showCmd;
            public System.Drawing.Point ptMinPosition;
            public System.Drawing.Point ptMaxPosition;
            public System.Drawing.Rectangle rcNormalPosition;
        }
        #endregion
        #region External functions
        [DllImport("kernel32.dll")]
        public static extern int ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In, Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        public static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

        [DllImport("user32.dll")]
        public static extern bool SetWindowText(IntPtr hWnd, string lpString);

        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, uint nCmdShow);

        [DllImport("user32.dll")]
        public static extern int FlashWindowEx([In] FlashWindowInfo fwiInfo);

        [DllImport("user32.dll")]
        public static extern bool GetWindowPlacement(IntPtr hWnd, out WindowPlacement windowPlacement);

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();
        #endregion

        public static T ReadAs<T>(IntPtr Handle, uint Address) where T : struct
        {
            IntPtr ptrBytesRead;
            T structure = default(T);
            uint size = (uint)System.Runtime.InteropServices.Marshal.SizeOf(structure);
            byte[] bytes = new byte[size];
            Windows.ReadProcessMemory(Handle, (IntPtr)Address, bytes, size, out ptrBytesRead);
            GCHandle handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            structure = (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));
            handle.Free();
            return structure;
        }
    }
}
