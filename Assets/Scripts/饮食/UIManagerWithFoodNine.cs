using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagerWithFoodNine : MonoBehaviour
{
    public GameObject FirstPanel;
    public GameObject SecondPanel;
    public GameObject ThirdPanel;
    public GameObject OverPanel0;
    public GameObject RestartPanel;

    // Start is called before the first frame update
    void Start()
    {
        ShowFirstPannel();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShowFirstPannel()
    {
        FirstPanel.SetActive(true);
    }

    public void ShowSecondPannel()
    {
        FirstPanel.SetActive(false);
        SecondPanel.SetActive(true);
    }

    public void ShowThirdPannel()
    {
        SecondPanel.SetActive(false);
        ThirdPanel.SetActive(true);
    }

    public void GameOver()
    {
        FirstPanel.SetActive(false);
        SecondPanel.SetActive(false);
        ThirdPanel.SetActive(false);

        OverPanel0.SetActive(true);
    }

    public void RestartGame()
    {
        FirstPanel.SetActive(false);
        SecondPanel.SetActive(false);
        ThirdPanel.SetActive(false);

        RestartPanel.SetActive(true);
    }

    // NOTE: 再来一次
    public void Restart()
    {
        RestartPanel.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // NOTE: 返回菜单
    public void BackMenu()
    {
        SceneManager.LoadScene(0);
    }
}
