using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;

namespace TibiaTekBot
{
    public class Tibia
    {
        #region Enumerations
        public enum WindowStates
        {
            Active,
            Minimized,
            Inactive,
            Hidden
        }
        #endregion

        #region Structures
        public struct Location
        {
            public uint X;
            public uint Y;
            public uint Z;

            public override bool Equals(object obj)
            {
                if (obj is Location)
                {
                    Location oLoc = (Location)obj;
                    return this.X == oLoc.X 
                        && this.Y == oLoc.Y
                        && this.Z == oLoc.Z;
                }
                else
                {
                    return base.Equals(obj);
                }
            }

            public override string ToString()
            {
                return String.Format("X: {0}, Y: {1}, Z: {2}", X, Y, Z);
            }

            public bool IsHigherThan(Location otherLoc)
            {
                return this.Z < otherLoc.Z;
            }

            public bool IsLowerThan(Location otherLoc)
            {
                return this.Z > otherLoc.Z;
            }
        }

        public struct Outfit
        {
            public uint OutfitID;
            public uint HeadColor;
            public uint BodyColor;
            public uint LegsColor;
            public uint FeetColor;
            public uint Addons;
            public uint MountID;
        }

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct Talkbox
        {
            public uint Number;
            public uint MessageNumber;
            public int TimeLeft;
            public uint Type;
            public Location Location;
            public uint NumLines;
            public fixed byte Lines[15*40];


        }
        #endregion

        #region Private Properties
        private Process clientProcess;
        #endregion

        #region Public Properties
        public LocalPlayer LocalPlayer { get; private set; }
        public bool IsConnected
        {
            get
            {
                return ReadByte(BaseAddress + (uint)Constants.Common.ConnectedState) >= 8;
            }
        }

        public uint XOR
        {
            get
            {
                return ReadUInt(BaseAddress + (uint)Constants.Common.XOR);
            }
        }

        public string Title
        {
            get
            {
                return clientProcess.MainWindowTitle;
            }
            set
            {
                Windows.SetWindowText(clientProcess.MainWindowHandle, value);
            }
        }

        IntPtr _WindowHandle = IntPtr.Zero;
        public IntPtr WindowHandle
        {
            get
            {
                if (_WindowHandle == IntPtr.Zero)
                {
                    if (clientProcess.MainWindowHandle == IntPtr.Zero)
                    {
                        clientProcess.Refresh();
                    }
                    _WindowHandle = clientProcess.MainWindowHandle;
                }
                return _WindowHandle;
            }
        }

        public IntPtr Handle
        {
            get
            {
                return clientProcess.Handle;
            }
        }

        public int PID
        {
            get
            {
                return clientProcess.Id;
            }
        }

        private uint _BaseAddress = 0;
        public uint BaseAddress
        {

            get
            {
                if (_BaseAddress == 0)
                {
                    _BaseAddress = (uint)clientProcess.MainModule.BaseAddress;
                }
                return _BaseAddress;
            }
        }

        public string Version { get; private set; }

        public WindowStates WindowState
        {
            get
            {
                Windows.WindowPlacement wp = default(Windows.WindowPlacement);
                wp.length = (byte)System.Runtime.InteropServices.Marshal.SizeOf(typeof(Windows.WindowPlacement));
                if (!Windows.GetWindowPlacement(WindowHandle, out wp))
                {
                    return WindowStates.Inactive;
                }
                switch (wp.showCmd)
                {
                    case Windows.ShowStates.SW_SHOWNORMAL:
                    case Windows.ShowStates.SW_SHOWMAXIMIZED:
                        if (Windows.GetForegroundWindow() == WindowHandle)
                        {
                            return WindowStates.Active;
                        }
                        return WindowStates.Inactive;
                    case Windows.ShowStates.SW_SHOWMINIMIZED:
                        return WindowStates.Minimized;
                    default:
                        return WindowStates.Inactive;
                }
            }
        }
        #endregion

        #region Public Methods
        public bool BringToFront()
        {
            return Windows.SetForegroundWindow(WindowHandle);
        }

        public bool Show()
        {
            return Windows.ShowWindow(WindowHandle, (uint)Windows.ShowStates.SW_SHOW);
        }

        public bool Restore()
        {
            return Windows.ShowWindow(WindowHandle, (uint)Windows.ShowStates.SW_RESTORE);
        }

        public bool Minimize()
        {
            return Windows.ShowWindow(WindowHandle, (uint)Windows.ShowStates.SW_SHOWMINIMIZED);
        }

        public bool Maximize()
        {
            return Windows.ShowWindow(WindowHandle, (uint)Windows.ShowStates.SW_SHOWMAXIMIZED);
        }

        public bool Hide()
        {
            return Windows.ShowWindow(WindowHandle, (uint)Windows.ShowStates.SW_HIDE);
        }

        public void Close(bool force = false)
        {
            if (force)
            {
                clientProcess.Kill();
            }
            else
            {
                clientProcess.CloseMainWindow();
            }
            
        }
        public bool SendKeys(string keys)
        {
            DateTime timeout = DateTime.Now.AddSeconds(3);
            WindowStates state;
            while ((state = WindowState) != WindowStates.Active)
            {
                if (DateTime.Now >= timeout)
                {
                    return false;
                }
                else if (state == WindowStates.Minimized)
                {
                    Restore();
                }
                else if (state == WindowStates.Hidden)
                {
                    Show();
                }
                else if (state == WindowStates.Inactive)
                {
                    BringToFront();
                }
                else if (state == WindowStates.Active)
                {
                    break;
                }
               // System.Threading.Thread.Sleep(1000);
                state = WindowState;
            }
            System.Windows.Forms.SendKeys.SendWait(keys);
            System.Windows.Forms.SendKeys.Flush();

            return true;
        }

        public bool IsOpened
        {
            get
            {
                return !clientProcess.HasExited;
            }
        }

        public void TakeScreenshot(string filenameWithoutExt, bool playSound = true, bool waitUntilActive = true)
        {
            string path = Path.Combine(Environment.CurrentDirectory, "ScreenCaptures");
            (new Thread(() =>
            {
                if (!IsOpened || !IsConnected)
                {
                    return;
                }
                
                do
                {
                    WindowStates state = WindowState;
                    if (state == WindowStates.Minimized)
                    {
                        Restore();
                    }
                    else if (state == WindowStates.Hidden)
                    {
                        Show();
                    }
                    else if (state == WindowStates.Inactive)
                    {
                        BringToFront();
                    }
                    Thread.Sleep(100);
                } while (waitUntilActive && WindowState != WindowStates.Active);
                
                var image = ScreenCapture.CaptureActiveWindow();
                string[] files = Directory.GetFiles(path, filenameWithoutExt + "*");
                string newFilename = filenameWithoutExt + (files.Length > 0 ? " (" + files.Length.ToString() + ")" : "") + ".jpg";
                image.Save(Path.Combine(path, newFilename), System.Drawing.Imaging.ImageFormat.Jpeg);
                SetStatusText("Screenshot saved.");
                string soundFile = Path.Combine(new string[] { Environment.CurrentDirectory, "Alarms", "Camera Shutter.wav" });
                if (playSound && File.Exists(soundFile))
                {
                    new SoundPlayer(soundFile).Play();
                }
            })).Start();
        }


        public void FlashWindow(bool stop = false)
        {
            if (stop)
            {
                var flags = Windows.FlashWindowFlags.FLASHW_STOP;
                Windows.FlashWindowInfo fwi = new Windows.FlashWindowInfo(WindowHandle, flags, 0, 0);
                Windows.FlashWindowEx(fwi);
            }
            else
            {
                var flags = Windows.FlashWindowFlags.FLASHW_TIMERNOFG
                    | Windows.FlashWindowFlags.FLASHW_TRAY
                    | Windows.FlashWindowFlags.FLASHW_CAPTION;
                Windows.FlashWindowInfo fwi = new Windows.FlashWindowInfo(WindowHandle, flags, 0, 0);
                Windows.FlashWindowEx(fwi);
            }
        }
        
        public BattleList GetBattlelist()
        {
            return new BattleList(this, 0);
        }
        public byte[] ReadBytes(uint Address, uint BytesToRead)
        {
            IntPtr ptrBytesRead;
            byte[] buffer = new byte[BytesToRead];
            if (BytesToRead > 0)
            {
                Windows.ReadProcessMemory(Handle, (IntPtr)Address, buffer, BytesToRead, out ptrBytesRead);
            }
            return buffer;
        }
        public uint ReadUInt(uint Address)
        {
            return BitConverter.ToUInt32(ReadBytes(Address, 4), 0);
        }
        public int ReadInt(uint Address)
        {
            return BitConverter.ToInt32(ReadBytes(Address, 4), 0);
        }
        public ulong ReadULong(uint Address)
        {
            return BitConverter.ToUInt64(ReadBytes(Address, 8), 0);
        }
        public long ReadLong(uint Address)
        {
            return BitConverter.ToInt64(ReadBytes(Address, 8), 0);
        }
        public byte ReadByte(uint Address)
        {
            return ReadBytes(Address, 1)[0];
        }
        public char ReadChar(uint Address)
        {
            return (char)ReadBytes(Address, 1)[0];
        }

        public bool ReadBool(uint Address)
        {
            return (ReadBytes(Address, 1)[0] & 0x1) == 0x1;
        }
        public Location ReadLocation(uint Address)
        {
            return Windows.ReadAs<Tibia.Location>(Handle, Address);
        }



        public string ReadString(uint Address, uint Length = 32)
        {
            return ASCIIEncoding.Default.GetString(ReadBytes(Address, Length)).Split('\0')[0];
        }
        public void WriteBytes(uint Address, byte[] bytes, uint BytesToWrite)
        {
            IntPtr ptrBytesWritten;
            Windows.WriteProcessMemory(Handle, (IntPtr)Address, bytes, BytesToWrite, out ptrBytesWritten);
        }
        public void WriteUInt(uint Address, uint value)
        {
            WriteBytes(Address, BitConverter.GetBytes(value), 4);
        }
        public void WriteInt(uint Address, int value)
        {
            WriteBytes(Address, BitConverter.GetBytes(value), 4);
        }
        public void WriteByte(uint Address, byte value)
        {
            WriteBytes(Address, new byte[] { value }, 1);
        }
        public void WriteULong(uint Address, ulong value)
        {
            WriteBytes(Address, BitConverter.GetBytes(value), 8);
        }
        public void WriteLong(uint Address, long value)
        {
            WriteBytes(Address, BitConverter.GetBytes(value), 8);
        }

        public void WriteString(uint Address, string value)
        {
            byte[] bytes = ASCIIEncoding.Default.GetBytes(value);
            uint len = (uint)bytes.Length;
            WriteBytes(Address, bytes, len);
            WriteByte(Address + len, 0);
        }

        public void SetStatusText(string text, uint time = 0x32)
        {
            WriteString(BaseAddress + (uint)Constants.Status.TextOffset, text);
            WriteUInt(BaseAddress + (uint)Constants.Status.TimeOffset, time);
        }
        #endregion

        #region Private Methods
        private Process GetNewClient()
        {
            Process clientProcess;
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "Tibia.exe";
            psi.WorkingDirectory = "C:\\Program Files (x86)\\Tibia";
            psi.UseShellExecute = true;
            clientProcess = Process.Start(psi);
            clientProcess.Exited += clientProcess_Exited;
            clientProcess.EnableRaisingEvents = true;
            clientProcess.Refresh();
            clientProcess.WaitForInputIdle();
            clientProcess.Refresh();

            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(System.IO.Path.Combine(psi.WorkingDirectory, psi.FileName));
            Version = fvi.FileVersion;
            return clientProcess;
        }

        private Process GetRunningClient()
        {
            Process[] localTibia = Process.GetProcessesByName("Tibia");
            if (localTibia.Length == 1)
            {
                localTibia[0].Exited += clientProcess_Exited;
                localTibia[0].EnableRaisingEvents = true;
                localTibia[0].Refresh();
                localTibia[0].WaitForInputIdle();
                localTibia[0].Refresh();
                
                return localTibia[0];
            }
            return null;
        }
        
        private void clientProcess_Exited(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.Abort();
        }
        #endregion

        public Tibia()
        {
            // Detect if Tibia is already running
            clientProcess = GetRunningClient();
            if (clientProcess == null)
            {
                clientProcess = GetNewClient();
            }
            Title = "TibiaTek Bot";
            LocalPlayer = new LocalPlayer(this);

        }

        ~Tibia()
        {
            if (clientProcess != null && !clientProcess.HasExited)
            {
                Title = "Tibia";
                clientProcess.Close();
            }
        }

    }
}
