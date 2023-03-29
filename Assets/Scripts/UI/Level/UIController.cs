using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using DataScripts;

public class UIController : MonoBehaviour
{
    [SerializeField] private UIData _UIData;

    private bool _pauseState = false;
    void Start()
    {
        LevelData levelData = LevelData.instance;
        levelData.LevelController.ActionWinedLevel += ShowWinnerPanel;

        BallController ballController = _UIData.PlayerBall.GetComponent<BallController>();
        ballController.ActionPlayerDied += ShowLoserPanel;

        _UIData.MainMenu.onClick.AddListener(MainMenu);
        _UIData.PauseOn.onClick.AddListener(PauseChange);
        _UIData.PauseOff.onClick.AddListener(PauseChange);
        _UIData.NextLevel.onClick.AddListener(NextLevel);
        _UIData.RestartLevel.onClick.AddListener(levelData.LevelController.RestartLevel);
    }
    private void ShowWinnerPanel()
    {
        _UIData.WinPanel.SetActive(true);
    }
    private void ShowLoserPanel()
    {
        _UIData.LoserPanel.SetActive(true);
    }
    private void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    private void PauseChange()
    {
        if(!_pauseState)
        {
            _UIData.ButtonPauseOn.SetActive(false);
            _UIData.ButtonPauseOff.SetActive(true);
            Time.timeScale = 0;
            _pauseState = !_pauseState;
        }
        else if (_pauseState)
        {
            _UIData.ButtonPauseOn.SetActive(true);
            _UIData.ButtonPauseOff.SetActive(false);
            Time.timeScale = 1;
            _pauseState = !_pauseState;
        }
    }
    private void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
