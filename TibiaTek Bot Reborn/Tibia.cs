using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices; // for DllImport
using System.Diagnostics;


namespace TibiaTekBot
{
    public class Tibia
    {
        #region External functions
        [DllImport("kernel32.dll")]
        public static extern int ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In, Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        public static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

        [DllImport("user32.dll")]
        public static extern bool SetWindowText(IntPtr hWnd, string lpString);
        #endregion

        public struct Location
        {
            public uint X;
            public uint Y;
            public uint Z;

            public override string ToString()
            {
                return String.Format("X: {0}, Y: {1}, Z: {2}", X, Y, Z);
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

        private Process clientProcess;
        public LocalPlayer LocalPlayer { get; private set; }

        public BattleList GetBattlelist()
        {
            return new BattleList(this, 0);
        }

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

        #region Properties

        public string Title
        {
            get
            {
                return clientProcess.MainWindowTitle;
            }
            set
            {
                try
                {
                    SetWindowText(clientProcess.MainWindowHandle, value);
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                
            }
        }

        public IntPtr WindowHandle
        {
            get
            {
                if (clientProcess.MainWindowHandle == IntPtr.Zero)
                {
                    clientProcess.Refresh();
                }
                return clientProcess.MainWindowHandle;
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

        public uint BaseAddress
        {
            get
            {
                return (uint)clientProcess.MainModule.BaseAddress;
            }
        }

        public string Version { get; private set; }
        #endregion

        #region Memory Functions
        public byte[] ReadBytes(uint Address, uint BytesToRead)
        {
            IntPtr ptrBytesRead;
            byte[] buffer = new byte[BytesToRead];
            if (BytesToRead > 0)
            {
                ReadProcessMemory(Handle, (IntPtr)Address, buffer, BytesToRead, out ptrBytesRead);
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
            byte[] bytes = ReadBytes(Address, 12);
            GCHandle handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            Tibia.Location loc = (Tibia.Location)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(Tibia.Location));
            handle.Free();
            return loc;
        }

        public static T ReadAs<T>(Tibia client, uint Address) where T : struct
        {
            T structure = default(T);
            byte[] bytes = client.ReadBytes(Address, (uint)System.Runtime.InteropServices.Marshal.SizeOf(structure));
            GCHandle handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            structure = (T) Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));
            handle.Free();
            return structure;
        }

        public string ReadString(uint Address, uint Length = 32)
        {
            return ASCIIEncoding.Default.GetString(ReadBytes(Address, Length)).Split('\0')[0];
        }
        public void WriteBytes(uint Address, byte[] bytes, uint BytesToWrite)
        {
            IntPtr ptrBytesWritten;
            WriteProcessMemory(Handle, (IntPtr)Address, bytes, BytesToWrite, out ptrBytesWritten);
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

        #endregion


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

        private void clientProcess_Exited(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.Abort();
        }
    }
}
