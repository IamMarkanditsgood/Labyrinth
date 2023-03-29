using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelPanelButton : MonoBehaviour
{
    private GameObject _levelPanel;
    private List<GameObject> objectToBeClosed;

    private void LoadLevel(int numberOfLevel)
    {
        SceneManager.LoadScene(numberOfLevel);
    }
    public void CloseButton()
    {
        _levelPanel = GetComponent<MainButtons>().LevelsPanel;
        objectToBeClosed = GetComponent<MainButtons>().ObjectsBeClosed;
        _levelPanel.SetActive(false);
        foreach (GameObject obj in objectToBeClosed)
        {
            obj.SetActive(true);
        }
    }
    public void LV1()
    {
        LoadLevel(1);
    }
    public void LV2()
    {
        LoadLevel(2);
    }
    public void LV3()
    {
        LoadLevel(3);
    }
    public void LV4()
    {
        LoadLevel(4);
    }

}
