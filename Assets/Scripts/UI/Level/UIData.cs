using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIData : MonoBehaviour
{
    [SerializeField] private GameObject _playerBall;
    [SerializeField] private GameObject _loserPanel;
    [SerializeField] private GameObject _winPanel;
    [SerializeField] private GameObject _buttonPauseOn;
    [SerializeField] private GameObject _buttonPauseOff;

    [SerializeField] private Button _mainMenu;
    [SerializeField] private Button _pauseOn;
    [SerializeField] private Button _pauseOff;
    [SerializeField] private Button _restartLevel;
    [SerializeField] private Button _nextLevel;

    public GameObject PlayerBall
    {
        get { return _playerBall; }
    }
    public GameObject LoserPanel
    {
        get { return _loserPanel; }
    }
    public GameObject WinPanel
    {
        get { return _winPanel; }
    }
    public GameObject ButtonPauseOn
    {
        get { return _buttonPauseOn; }
    }
    public GameObject ButtonPauseOff
    {
        get { return _buttonPauseOff; }
    }
    public Button MainMenu
    {
        get { return _mainMenu; }
    }
    public Button PauseOn
    {
        get { return _pauseOn; }
    }
    public Button PauseOff
    {
        get { return _pauseOff; }
    }
    public Button RestartLevel
    {
        get { return _restartLevel; }
    }
    public Button NextLevel
    {
        get { return _nextLevel; }
    }
}
