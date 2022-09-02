using UnityEngine;

namespace VoxelCraft.UI.Flow
{
    public class AutoOpenScreen : MonoBehaviour
    {
        [SerializeField] private ScreenID screenID;

        private void Start()
        {
            ScreenFlow.Open(screenID);
        }
    }
}