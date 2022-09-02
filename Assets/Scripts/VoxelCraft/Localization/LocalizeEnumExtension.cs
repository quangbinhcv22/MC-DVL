using VoxelCraft.Gameplay.Define;

namespace VoxelCraft.Localization
{
    public static class LocalizeEnumExtension
    {
        public static string Localized(this GameMode mode)
        {
            return mode.ToString();
        }

        public static string Localized(this GameDifficult difficult)
        {
            return difficult.ToString();
        }
    }
}