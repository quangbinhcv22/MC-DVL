using System;

namespace VoxelCraft.UI.Flow
{
    [Serializable]
    public class ScreenConfig
    {
        public ScreenID id;
        public ScreenType type;
        public string address;
    }
}