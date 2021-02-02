using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMangerWithZero : MonoBehaviour
{
    public GameObject OldMan;
    public GameObject FirstPannel;
    public GameObject SecondPannel;
    public GameObject ThirdPannel;
    public GameObject FourPannel;
    public GameObject GameOverPannel;
    public GameObject PassPannel;


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

    // NOTE: 展示第一个菜单
    private void ShowFirstPannel()
    {
        FirstPannel.SetActive(true);
    }

    // NOTE: 展示第二个菜单
    public void ShowSecondPannel()
    {
        FirstPannel.SetActive(false);
        SecondPannel.SetActive(true);
    }

    // NOTE: 展示第三个菜单
    public void ShowThirdPannel()
    {
        SecondPannel.SetActive(false);
        ThirdPannel.SetActive(true);
    }

    // NOTE: 展示第四个菜单
    public void ShowFourPannel()
    {
        ThirdPannel.SetActive(false);
        FourPannel.SetActive(true);
    }

    public void ShowGameOverPanel()
    {
        FirstPannel.SetActive(false);
        SecondPannel.SetActive(false);
        ThirdPannel.SetActive(false);
        FourPannel.SetActive(false);
        GameOverPannel.SetActive(true);
    }

    public void ShowPassPanel()
    {
        FirstPannel.SetActive(false);
        SecondPannel.SetActive(false);
        ThirdPannel.SetActive(false);
        FourPannel.SetActive(false);
        PassPannel.SetActive(true);
    }

    // NOTE: 深蹲
    public void Shendun()
    {
        ShowGameOverPanel();
    }

    // NOTE: 慢跑
    public void Manpao()
    {
        ShowSecondPannel();
    }

    // NOTE: 餐前一小时
    public void FoodBeforeOneHour()
    {
        ShowGameOverPanel();
    }

    // NOTE: 餐后一小时
    public void FoodAfterOneHour()
    {
        ShowThirdPannel();
    }

    // NOTE: 餐后立即
    public void FoodAfterNow()
    {
        ShowGameOverPanel();
    }

    // NOTE: 心跳 100-120次
    public void HealthFrom100To120()
    {
        ShowFourPannel();
    }

    // NOTE: 心跳 120-136次
    public void HealthFrom120To136()
    {
        ShowGameOverPanel();
    }

    // NOTE: 心跳 136-150次
    public void HealthFrom136To150()
    {
        ShowGameOverPanel();
    }

    // NOTE: 运动不适合
    public void NODO()
    {
        ShowGameOverPanel();
    }

    // NOTE: 运动适合
    public void YESDO()
    {
        ShowPassPanel();
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
}
