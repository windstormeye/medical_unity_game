using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagerPill : MonoBehaviour
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
        SceneManager.LoadScene(0);
    }

    // NOTE: 案例一
    public void First()
    {
        SceneManager.LoadScene(13);
    } 

    // NOTE: 案例二
    public void Second()
    {
        SceneManager.LoadScene(14);
    }

    // NOTE: 案例三
    public void Third()
    {
        SceneManager.LoadScene(15);
    }

    // NOTE: 案例四
    public void Four()
    {
        SceneManager.LoadScene(16);
    }

    // NOTE: 案例五
    public void Five()
    {
        SceneManager.LoadScene(17);
    }
}

