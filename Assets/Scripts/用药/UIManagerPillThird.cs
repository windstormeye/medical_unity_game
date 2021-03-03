using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagerPillThird : MonoBehaviour
{
    public GameObject FirstPannel;
    public GameObject SecondPannel;
    public GameObject ThirdPannel;
    public GameObject FourPannel;
    public GameObject FivePannel;
    public GameObject GameOverPannel;
    public GameObject PassPannel;
    public GameObject TextPannel;

    public GameObject AYES;
    public GameObject BYES;
    public GameObject CYES;
    public GameObject DYES;
    public GameObject EYES;
    public GameObject SureButton;


    // Start is called before the first frame update
    void Start()
    {
        ShowFirstPannel();
    }

    // NOTE: 延迟出文本提示
    private IEnumerator DelayShowThirdPanel()
    {
        yield return new WaitForSeconds(2);
        ShowThirdPanel();
    }

    // NOTE: 展示第一个菜单
    private void ShowFirstPannel()
    {
        FirstPannel.SetActive(true);
    }

    // NOTE: 再来一次
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // NOTE: 返回菜单
    public void BackMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - SceneManager.GetActiveScene().buildIndex);
    }

    // NOTE: 游戏失败
    public void ShowGameOverPanel()
    {
        FirstPannel.SetActive(false);
        SecondPannel.SetActive(false);
        ThirdPannel.SetActive(false);
        FourPannel.SetActive(false);
        GameOverPannel.SetActive(true);
    }

    // NOTE: 游戏通过
    public void ShowPassPanel()
    {
        FirstPannel.SetActive(false);
        SecondPannel.SetActive(false);
        ThirdPannel.SetActive(false);
        FourPannel.SetActive(false);
        FivePannel.SetActive(false);
        PassPannel.SetActive(true);
    }

    // NOTE: 展示第三个菜单
    public void ShowThirdPanel()
    {
        SecondPannel.SetActive(false);
        ThirdPannel.SetActive(true);
    }

    public void ShowFourPanel()
    {
        ThirdPannel.SetActive(false);
        FourPannel.SetActive(true);
    }

    public void ShowFivePanel()
    {
        FourPannel.SetActive(false);
        FivePannel.SetActive(true);
    }

    // NOTE: 糖友急救卡片
    public void HealthCard()
    {
        AYES.SetActive(!AYES.activeSelf);
    }

    // NOTE: 糖块
    public void Sugar()
    {
        BYES.SetActive(!BYES.activeSelf);
    }

    // NOTE: 饼干
    public void Cookies()
    {
        CYES.SetActive(!CYES.activeSelf);
    }

    // NOTE: 水
    public void Water()
    {
        DYES.SetActive(!DYES.activeSelf);
    }

    // NOTE: 鸡蛋
    public void egg()
    {
        EYES.SetActive(!EYES.activeSelf);
    }

    // NOTE: 确认
    public void SureButtonClick()
    {
        if (AYES.activeSelf && BYES.activeSelf && CYES.activeSelf && DYES.activeSelf && EYES.activeSelf)
        {
            FirstPannel.SetActive(false);
            SecondPannel.SetActive(true);
        }
        else
        {
            ShowGameOverPanel();
        }
    }
}

