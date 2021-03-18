using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagerWithFood : MonoBehaviour
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
        SceneManager.LoadScene(10);
    }

    // NOTE: 案例二
    public void Second()
    {
        SceneManager.LoadScene(11);
    }

    // NOTE: 案例三
    public void Third()
    {
        SceneManager.LoadScene(22);
    }

    // NOTE: 案例四
    public void Four()
    {
        SceneManager.LoadScene(23);
    }

    // NOTE: 案例五
    public void Five()
    {
        SceneManager.LoadScene(29);
    }

    // NOTE: 案例六
    public void Six()
    {
        SceneManager.LoadScene(30);
    }

    // NOTE: 案例七
    public void Seven()
    {
        SceneManager.LoadScene(31);
    }

    // NOTE: 案例八
    public void Eight()
    {
        SceneManager.LoadScene(32);
    }

    // NOTE: 案例九
    public void Nine()
    {
        SceneManager.LoadScene(33);
    }
}
