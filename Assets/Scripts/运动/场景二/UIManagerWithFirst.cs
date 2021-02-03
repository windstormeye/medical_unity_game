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

    // NOTE: 加餐后再酌情运动
    public void EatFoodAfterSport()
    {

    }

    // NOTE: 继续出门运动
    public void continueSport()
    {

    }

    // NOTE: 躺下休息，不出门运动
    public void NotSport()
    {

    }

    // NOTE: 草莓
    public void Strawberry()
    {

    }

    // NOTE: 牛奶
    public void Milk()
    {

    }

    // NOTE: 桂圆干
    public void Longan()
    {

    }

    // NOTE: 糖友急救卡片
    public void HealthCard()
    {

    }

    // NOTE: 糖块
    public void Sugar()
    {

    }

    // NOTE: 饼干
    public void Cookies()
    {

    }

    // NOTE: 水
    public void Water()
    {

    }

    // NOTE: 鸡蛋
    public void egg()
    {

    }

    // NOTE: 出门运动
    public void OutdoorSport()
    {

    }

    // NOTE: 不出门运动
    public void indoorNotSport()
    {

    }
}
