using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] private MenuData _menuData;

    private VisualElement root;
    private void Start()
    {
        
        GetMenuButtons();


    }
    private void GetMenuButtons()
    {
        root = GetComponent<UIDocument>().rootVisualElement;
        _menuData.ButtonStart = root.Q<Button>("ButtonStart");
        _menuData.ButtonSetthings = root.Q<Button>("ButtonSettings");
        _menuData.ButtonExit = root.Q<Button>("ButtonExit");

        _menuData.ButtonStart.clicked += () => ButtonStart();
        _menuData.ButtonSetthings.clicked += () => ButtonSettings();
        _menuData.ButtonExit.clicked += () => ButtonExit();
    }
    private void GetLevelPanelButtons()
    {
        root = GetComponent<UIDocument>().rootVisualElement;
        _menuData.ButtonExitLevelPanel = root.Q<Button>("Exit");
        fillListOfLevelButtons();

        _menuData.ButtonExitLevelPanel.clicked += () => ButtonExitFormLevelPanel();
        CheckClicedLVButton();
    }
    private void fillListOfLevelButtons()
    {
        _menuData.ListOfLevelButtons.Add(root.Q<Button>("LV1"));
        _menuData.ListOfLevelButtons.Add(root.Q<Button>("LV2"));
        _menuData.ListOfLevelButtons.Add(root.Q<Button>("LV3"));
        _menuData.ListOfLevelButtons.Add(root.Q<Button>("LV4"));
        _menuData.ListOfLevelButtons.Add(root.Q<Button>("LV5"));
        _menuData.ListOfLevelButtons.Add(root.Q<Button>("LV6"));
    }
    private void CheckClicedLVButton()
    {
        _menuData.ListOfLevelButtons[0].clicked += () => ButtonLV(1);
        _menuData.ListOfLevelButtons[1].clicked += () => ButtonLV(2);
        _menuData.ListOfLevelButtons[2].clicked += () => ButtonLV(3);
        _menuData.ListOfLevelButtons[3].clicked += () => ButtonLV(4);
        _menuData.ListOfLevelButtons[4].clicked += () => ButtonLV(5);
        _menuData.ListOfLevelButtons[5].clicked += () => ButtonLV(6);
    }
    private void ButtonStart()
    {
        _menuData.UiMenuDocument.visualTreeAsset = _menuData.LevelPanelAsset;
        GetLevelPanelButtons();
    }
    private void ButtonSettings()
    {

    }
    private void ButtonExit()
    {
        Application.Quit();
    }
    private void ButtonExitFormLevelPanel()
    {
        _menuData.UiMenuDocument.visualTreeAsset = _menuData.MenuAsset;
        GetMenuButtons();
    }
    private void ButtonLV(int levelNumber)
    {
        SceneManager.LoadScene(levelNumber);
    }
    
}
