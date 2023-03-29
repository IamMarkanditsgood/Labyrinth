using UnityEngine;
using DataScripts;
using System;

public class BallController : MonoBehaviour
{
    public event Action ActionPlayerDied;
    public event Action ActionTouched;
    public event Action ActionScorePoint;

    private void OnCollisionEnter(Collision collision)
    {
        ActionTouched?.Invoke();
        if (collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            Die();
        }
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            Die();
        }
        else if(collider.gameObject.tag == "VictoryPoint")
        {
            ActionScorePoint?.Invoke();
            LevelData levelData = LevelData.instance;
            levelData.LevelController.VictoryInLevel();
        }
        else if (collider.gameObject.tag == "ScorePoint")
        {
            ActionScorePoint?.Invoke();
            collider.gameObject.SetActive(false);
            LevelData levelData = LevelData.instance;
            levelData.LevelController.AddScore();
        }
    }

    private void Die()
    {
        ActionPlayerDied?.Invoke();
        Destroy(gameObject);
        Time.timeScale = 0f;
    }
}
