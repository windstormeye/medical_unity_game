using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public GameObject eatPillPanel;
    public GameObject nextLevelPanel;


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
}
