using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public GameObject eatPillPanel;
    public GameObject nextLevelPanel;
    public GameObject overPanel;


    public OldLadyController oldLady;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(instance);
        }
    }

    public void MoveToSofa()
    {
        eatPillPanel.SetActive(false);
        oldLady.MoveToSofa();
    }

    public void NextLevel()
    {
        nextLevelPanel.SetActive(true);
    }

    public void GotoNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void DelayEatPill()
    {
        eatPillPanel.SetActive(false);
        overPanel.SetActive(true);
    }

    public void ShowEatPillPanel()
    {
        eatPillPanel.SetActive(true);
    }
}
