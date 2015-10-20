using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TibiaTekBot
{
    public class BattleList
    {
        private Tibia client;
        public uint Index { get; private set; }
        public uint BattlelistBegin = 0;

        public BattleList (Tibia client, uint Index)
        {
            this.client = client;
            this.Index = Index;
            this.BattlelistBegin = client.ReadUInt(client.BaseAddress + (uint)Constants.BattleList.BeginPointer);
        }

        #region Properties

        #endregion

        
        public Tibia.Location Location
        {
            get
            {
                //return client.ReadLocation(BattlelistBegin + Index * (uint)Constants.Battlelist.ItemSize + (uint)Constants.Battlelist.LocationOffset);
                Tibia.Location loc = Tibia.ReadAs<Tibia.Location>(client, BattlelistBegin + Index * (uint)Constants.BattleList.ItemSize + (uint)Constants.BattleList.LocationOffset);
                // but Cipsoft fuckered the order here
                loc.X ^= loc.Z;
                loc.Z ^= loc.X;
                loc.X ^= loc.Z;
                return loc;
            }
        }

        public Tibia.Outfit Outfit
        {
            get
            {
                return Tibia.ReadAs<Tibia.Outfit>(client, BattlelistBegin + Index * (uint)Constants.BattleList.ItemSize + (uint)Constants.BattleList.OutfitOffset);
            }
        }

        public bool OnScreen
        {
            get
            {
                return client.ReadBool(BattlelistBegin + Index * (uint)Constants.BattleList.ItemSize + (uint)Constants.BattleList.OnScreenOffset);
            }
        }

        public uint ID
        {
            get
            {
                return client.ReadUInt(BattlelistBegin + Index * (uint)Constants.BattleList.ItemSize);
            }
        }

        public string Name
        {
            get
            {
                return client.ReadString(BattlelistBegin + Index * (uint)Constants.BattleList.ItemSize + (uint)Constants.BattleList.NameOffset);
            }
        }

        public void Reset()
        {
            this.Index = 0;
        }

        public bool NextVisible()
        {
            bool isOnScreen = false;

            while (Next() && !(isOnScreen = (OnScreen && client.LocalPlayer.Location.Z == Location.Z)));
            return isOnScreen;
        }

        public bool PreviousVisible()
        {
            bool isOnScreen = false;
            while (Previous() && !(isOnScreen = (OnScreen && client.LocalPlayer.Location.Z == Location.Z))) ;
            return isOnScreen;
        }

        public bool Next()
        {
            if (Index + 1 > (uint)Constants.BattleList.ItemMaxCount) { 
                return false;
            }
            Index++;
            return true;
        }

        public bool Previous()
        {
            if (this.Index == 0)
            {
                return false;
            }
            this.Index--;
            return true;
        }


        public bool FindByID(uint ID)
        {
            Reset();
            do
            {
                if (this.ID == ID)
                {
                    return true;
                }
            } while (Next());

            return false;
        }

        public bool FindByName(string Name)
        {
            Reset();
            do
            {
                if (this.Name == Name)
                {
                    return true;
                }
            } while (Next());

            return false;
        }

        public void Seek(uint Index)
        {
            this.Index = Math.Max(0, Math.Min((uint)Constants.BattleList.ItemMaxCount, Index));
        }
    }
}
