using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Assertions;
using VoxelCraft.UI.Flow;

public class ScreenFlow : MonoBehaviour
{
    private static ScreenFlow _instance;


    private static readonly Dictionary<ScreenID, Screen> Screens = new();
    private static readonly Dictionary<ScreenID, Screen> ActiveScreens = new();

    private static readonly Stack<ScreenID> WindowHistory = new();


    [Space] [SerializeField] private ScreenFlowConfig config;
    private static ScreenFlowConfig Config => _instance.config;

    [Space] [SerializeField] private Transform windowContainer;
    [SerializeField] private Transform popupContainer;


    private void Awake()
    {
        if (_instance != null)
        {
            Destroy(gameObject);
            return;
        }

        _instance = this;
        DontDestroyOnLoad(gameObject);
    }


    public static void Open(ScreenID screenID, bool haveAnimation = true)
    {
        if (ActiveScreens.ContainsKey(screenID)) return;

        var isExist = Screens.ContainsKey(screenID);
        if (!isExist) Screens.Add(screenID, CreateScreen(screenID));


        var screen = Screens[screenID];

        if (Config.TypeOf(screenID) is ScreenType.Window)
        {
            if (WindowHistory.Any()) Close(WindowHistory.Last(), false);
            WindowHistory.Push(screenID);
        }

        screen.gameObject.SetActive(true);
        screen.transform.SetAsLastSibling();

        ActiveScreens.Add(screenID, screen);
    }

    public static void Close(ScreenID screenID, bool haveAnimation = true)
    {
        if (!ActiveScreens.ContainsKey(screenID)) return;

        var screen = ActiveScreens[screenID];

        screen.gameObject.SetActive(false);

        ActiveScreens.Remove(screenID);
    }

    public static void Close(Screen screen, bool haveAnimation = true)
    {
        Close(IDOf(screen), haveAnimation);
    }

    public static void PopWindow(bool playAnimation = true)
    {
        if (WindowHistory.Any()) Close(WindowHistory.Pop(), playAnimation);
        if (WindowHistory.Any()) Open(WindowHistory.Last(), false);
    }


    private static Screen CreateScreen(ScreenID screenID)
    {
        var screenPrefab = Addressables.LoadAssetAsync<GameObject>(Config.AddressOf(screenID)).WaitForCompletion();
        var screen = Instantiate(screenPrefab).GetComponent<Screen>();

        Assert.IsNotNull(screen, $"{screenPrefab.name} not attach component Screen");


        if (Config.TypeOf(screenID) is ScreenType.Window)
        {
            screen.transform.SetParent(_instance.windowContainer);
        }
        else
        {
            screen.transform.SetParent(_instance.popupContainer);
        }

        screen.GetComponent<RectTransform>().FillFull();


        return screen;
    }


    private static ScreenID IDOf(Screen screen)
    {
        return Screens.First(config => config.Value == screen).Key;
    }
}