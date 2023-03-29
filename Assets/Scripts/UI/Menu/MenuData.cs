using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MenuData : MonoBehaviour
{
    [SerializeField] private UIDocument _uiMenuDocument;

    [SerializeField] private VisualTreeAsset _menuAsset;
    [SerializeField] private VisualTreeAsset _levelPanelAsset;
    [SerializeField] private VisualTreeAsset _settingsPanelAsset;

    List<Button> _levelsButtons = new List<Button>();

    private Button _buttonStart;
    private Button _buttonSetthings;
    private Button _buttonExit;
    private Button _buttonExitLevelPanel;


    public UIDocument UiMenuDocument
    {
        get { return _uiMenuDocument; }
    }

    public VisualTreeAsset MenuAsset
    {
        get { return _menuAsset; }
    }
    public VisualTreeAsset LevelPanelAsset
    {
        get { return _levelPanelAsset; }
    }
    public  VisualTreeAsset SettingsPanelAsset
    {
        get { return _settingsPanelAsset; }
    }

    public List<Button> ListOfLevelButtons
    {
        get { return _levelsButtons;  }
    }
    public Button ButtonStart
    {
        get { return _buttonStart; }
        set { _buttonStart = value; }
    }
    public Button ButtonSetthings
    {
        get { return _buttonSetthings; }
        set { _buttonSetthings = value; }
    }
    public Button ButtonExit
    {
        get { return _buttonExit; }
        set { _buttonExit = value; }
    }
    public Button ButtonExitLevelPanel
    {
        get { return _buttonExitLevelPanel; }
        set { _buttonExitLevelPanel = value; }
    }
}
