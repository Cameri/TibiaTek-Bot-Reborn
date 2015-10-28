using System;

namespace TibiaTekBot
{
    public static class Constants
    {
        public enum Common : uint
        {
            XOR = 0x533658U,
            ConnectedState = 0x545168U,
        }

        public enum SkillsList : uint
        {
            BeginPointer = 0x6D1000U,
            FistFightingOffset = 0x0U,
            ClubFightingOffset = 0x4U,
            SwordFightingOffset = 0x8U,
            AxeFightingOffset = 0xCU,
            DistanceFightingOffset = 0x10U,
            ShieldingOffset = 0x14U,
            FishingOffset = 0x18U
        }

        public enum CharacterList : uint
        {
            BeginPointer = 0x6CDE68U,
            Selected = 0x6CDEF0U,
            ItemSize = 0x68U,
            NameOffset = 0x04U,
            WorldOffset = 0x14U,
            PortOffset = 0x60U,
        }

        public enum LocalPlayer : uint
        {
            IDOffset = 0x6D102CU,
            LevelOffset = 0x533670U,
            ExperienceOffset = 0x533660U,
            ExperienceRateOffset = 0x588AECU,
            SoulPointsOffset = 0x533674U,
            LocationOffset = 0x6D1038U,
            ManaPointsOffset = 0x533688U, // XORed
            MaxManaPointsOffset = 0x53365CU, // XORed
            HealthPointsOffset = 0x6D1030U, // XORed
            MaxHealthPointsOffset = 0x6D1024U, // XORed
            CapacityOffset = 0x6D101C, // XORed
        }

        public enum VipList : uint
        {

        }
        
        public enum BattleList : uint
        {
            BeginPointer = 0x0A993CU,
            ItemMaxCount = 1299U,
            ItemSize = 0xDCU,
            NameOffset = 0x4U,
            LocationOffset = 0x24U, 
            CoordZOffset = 0x24U,
            CoordYOffset = 0x28U,
            CoordXOffset = 0x2CU,
            HorizontalGfxOffset = 0x34U,
            VerticalGfxOffset = 0x30U, //
            DirectionOffset = 0x38U,
            WalkingOffset = 0xC4U,
            OutfitOffset = 0x60U,
            HeadOffset = 0x64U,
            BodyOffset = 0x68U,
            LegsOffset = 0x6CU,
            FeetOffset = 0x70U,
            AddonsOffset = 0x74U,
            MountOffset = 0x78U,
            LightIntensityOffset = 0x7CU,
            LightColorOffset = 0x80U,
            HPPercentOffset = 0x8CU,
            SpeedOffset = 0x90U,
            OnScreenOffset = 0xA4U, // show nametag
        };

    }
}
