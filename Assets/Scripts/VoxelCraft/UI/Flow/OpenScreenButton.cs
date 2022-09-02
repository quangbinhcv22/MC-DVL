using UnityEngine;
using UnityEngine.UI;

namespace VoxelCraft.UI.Flow
{
    [RequireComponent(typeof(Button))]
    public class OpenScreenButton : MonoBehaviour
    {
        [SerializeField] private ScreenID screenID;

        private void Awake() => GetComponent<Button>().onClick.AddListener(OpenScreen);
        private void OpenScreen() => ScreenFlow.Open(screenID);
    }
}