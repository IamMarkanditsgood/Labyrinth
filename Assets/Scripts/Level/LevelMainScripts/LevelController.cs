using DataScripts;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    [SerializeField] private LevelData _levelData;

    public event Action ActionWinedLevel;

    private void Start()
    {
        Time.timeScale = 1f;

        if (_levelData == null)
        {
            _levelData = LevelData.instance;
        }
        LevelCreator levelCreator= new LevelCreator();
        levelCreator.CreateScene();
    }

    public void VictoryInLevel()
    {
        ActionWinedLevel?.Invoke();
        Time.timeScale = 0f;
    }
    public void AddScore()
    {
        _levelData.Score++;
        print("Score: " + _levelData.Score);
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
