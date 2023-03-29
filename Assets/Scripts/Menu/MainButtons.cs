using System.Collections.Generic;
using UnityEngine;

public class MainButtons : MonoBehaviour
{
    [SerializeField] private GameObject _levelsPanel;
    [SerializeField] private List<GameObject> _objectsBeClosed = new List<GameObject>();

    public GameObject LevelsPanel
    {
        get { return _levelsPanel; }
    }
    public List<GameObject> ObjectsBeClosed
    {
        get { return _objectsBeClosed; }
    }
    public void StartButton()
    {
        _levelsPanel.SetActive(true);
        foreach (GameObject level in _objectsBeClosed)
        {
            level.SetActive(false);
        }
    }
    public void SettingsButton()
    {
        print("Settings");
    }
    public void ExitButton()
    {
        Application.Quit();
    }
}
