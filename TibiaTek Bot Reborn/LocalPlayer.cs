using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TibiaTekBot
{
    public class LocalPlayer
    {
        private Tibia client;

        public LocalPlayer(Tibia client)
        {
            this.client = client;
        }

        public uint Level
        {
            get
            {
                return client.ReadUInt(client.BaseAddress + (uint)Constants.LocalPlayer.LevelOffset);
            }
        }

        public ulong Experience
        {
            get
            {
                return client.ReadULong(client.BaseAddress + (uint)Constants.LocalPlayer.ExperienceOffset);
            }
        }

        public Tibia.Location Location
        {
            get
            {
                return client.ReadLocation(client.BaseAddress + (uint)Constants.LocalPlayer.LocationOffset);
            }
        }

        public uint SoulPoints
        {
            get
            {
                return client.ReadUInt(client.BaseAddress + (uint)Constants.LocalPlayer.SoulPointsOffset);
            }
        }
        public uint HealthPoints
        {
            get
            {
                return client.ReadUInt(client.BaseAddress + (uint)Constants.LocalPlayer.HealthPointsOffset) ^ client.ReadUInt(client.BaseAddress + (uint)Constants.Common.XOR);
            }
        }

        public uint MaxHealthPoints
        {
            get
            {
                return client.ReadUInt(client.BaseAddress + (uint)Constants.LocalPlayer.MaxHealthPointsOffset) ^ client.ReadUInt(client.BaseAddress + (uint)Constants.Common.XOR);
            }
        }

        public uint ManaPoints
        {
            get
            {
                return client.ReadUInt(client.BaseAddress + (uint)Constants.LocalPlayer.ManaPointsOffset) ^ client.ReadUInt(client.BaseAddress + (uint)Constants.Common.XOR);
            }
        }

        public uint MaxManaPoints
        {
            get
            {
                return client.ReadUInt(client.BaseAddress + (uint)Constants.LocalPlayer.MaxManaPointsOffset) ^ client.ReadUInt(client.BaseAddress + (uint)Constants.Common.XOR);
            }
        }

        public uint Capacity
        {
            get
            {
                return client.ReadUInt(client.BaseAddress + (uint)Constants.LocalPlayer.CapacityOffset) ^ client.ReadUInt(client.BaseAddress + (uint)Constants.Common.XOR);
            }
        }

        public uint ExperienceRate
        {
            get
            {
                return client.ReadUInt(client.BaseAddress + (uint)Constants.LocalPlayer.ExperienceRateOffset);
            }
        }

        public uint ID
        {
            get
            {
                return client.ReadUInt(client.BaseAddress + (uint) Constants.LocalPlayer.IDOffset);
            }
        }
        public string Name
        {
            get
            {
                var bl = client.GetBattlelist();
                if (!bl.FindByID(ID))
                {
                    return "Unknown";
                }
                return bl.Name;
            }
        }
        
    }
}
