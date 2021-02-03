using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagerWithSport : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // NOTE: 返回到主菜单
    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    // NOTE: 案例一
    public void First()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
    }
}
