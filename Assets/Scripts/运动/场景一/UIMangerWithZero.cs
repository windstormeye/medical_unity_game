using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMangerWithZero : MonoBehaviour
{
    public GameObject OldMan;
    public GameObject FirstPannel;
    public GameObject SecondPannel;


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

    // NOTE: 深蹲
    public void Shendun()
    {
        
    }

    // NOTE: 慢跑
    public void Manpao()
    {
        ShowSecondPannel();
    }

    // NOTE: 餐前一小时
    public void FoodBeforeOneHour()
    {

    }

    // NOTE: 餐后一小时
    public void FoodAfterOneHour()
    {

    }

    // NOTE: 餐后立即
    public void FoodAfterNow()
    {

    }
}
