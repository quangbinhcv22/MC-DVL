using UnityEngine;
using UnityEngine.UI;

namespace VoxelCraft.UI.Flow
{
    [RequireComponent(typeof(Button))]
    public class PopWindowButton : MonoBehaviour
    {
        [SerializeField] private bool playAnimation = true;

        private void Awake() => GetComponent<Button>().onClick.AddListener(OpenScreen);
        private void OpenScreen() => ScreenFlow.PopWindow(playAnimation);
    }
}