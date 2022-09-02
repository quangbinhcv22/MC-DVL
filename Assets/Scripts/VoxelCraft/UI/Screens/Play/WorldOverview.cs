using System;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VoxelCraft.Gameplay.Define;
using VoxelCraft.Localization;

namespace VoxelCraft.UI.Screens.Play
{
    public class WorldOverview : MonoBehaviour
    {
        [Space] [SerializeField] private Image screenShot;

        [Space] [SerializeField] private TMP_Text nameText;
        [SerializeField] private TMP_Text infoText;

        [Space] [SerializeField] private TMP_Text createDateText;
        [SerializeField] private TMP_Text sizeText;

        [Space] [SerializeField] private Button openButton;
        [SerializeField] private Button editButton;


        private void Awake()
        {
            openButton.onClick.AddListener(OpenWorld);
            editButton.onClick.AddListener(OpenEditor);
        }


        public void UpdateView(WorldOverviewData data)
        {
            screenShot.sprite = data.screenShot;

            nameText.SetText(data.name);
            infoText.SetText($"{data.mode.Localized()}/{data.difficult.Localized()}");

            createDateText.SetText(data.createDate.ToString(CultureInfo.InvariantCulture));
            sizeText.SetText(data.bytes.ToString("N0"));
        }


        private void OpenWorld()
        {
            Debug.Log("Open World");
        }

        private void OpenEditor()
        {
            Debug.Log("Open Editor");
        }
    }

    [Serializable]
    public class WorldOverviewData
    {
        public Sprite screenShot;
        public string name;
        public GameMode mode;
        public GameDifficult difficult;
        public DateTime createDate;
        public int bytes;
    }
}