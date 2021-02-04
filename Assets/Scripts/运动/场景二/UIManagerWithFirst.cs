using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIManagerWithFirst : MonoBehaviour
{

    public GameObject FirstPannel;
    public GameObject SecondPannel;
    public GameObject ThirdPannel;
    public GameObject FourPannel;
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
        StartCoroutine(DelayShowMenuPanel());
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator DelayShowMenuPanel()
    {
        // NOTE: 延迟 3s 出菜单
        yield return new WaitForSeconds(3);
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
        PassPannel.SetActive(true);
    }

    // NOTE: 展示第三个菜单
    public void ShowThirdPanel()
    {
        TextPannel.SetActive(false);
        ThirdPannel.SetActive(true);
    }

    // NOTE: 加餐后再酌情运动
    public void EatFoodAfterSport()
    {
        ShowGameOverPanel();
    }

    // NOTE: 继续出门运动
    public void continueSport()
    {
        FirstPannel.SetActive(false);
        SecondPannel.SetActive(true);
    }

    // NOTE: 躺下休息，不出门运动
    public void NotSport()
    {
        FirstPannel.SetActive(false);
        TextPannel.SetActive(true);
        StartCoroutine(DelayShowThirdPanel());
    }

    // NOTE: 草莓
    public void Strawberry()
    {
        SecondPannel.SetActive(false);
        ThirdPannel.SetActive(true);
    }

    // NOTE: 牛奶
    public void Milk()
    {
        SecondPannel.SetActive(false);
        ThirdPannel.SetActive(true);
    }

    // NOTE: 桂圆干
    public void Longan()
    {
        ThirdPannel.SetActive(false);
        FourPannel.SetActive(true);
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
    public  void SureButtonClick()
    {
        if (AYES.activeSelf && BYES.activeSelf && CYES.activeSelf && DYES.activeSelf && !EYES.activeSelf)
        {
            ThirdPannel.SetActive(false);
            FourPannel.SetActive(true);
        }
        else
        {
            ShowGameOverPanel();
        }
    }

    // NOTE: 出门运动
    public void OutdoorSport()
    {
        ShowGameOverPanel();
    }

    // NOTE: 不出门运动
    public void indoorNotSport()
    {
        ShowPassPanel();
    }
}
