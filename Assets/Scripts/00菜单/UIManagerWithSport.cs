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

    // NOTE: 案例二
    public void Second()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
    }

    // NOTE: 案例三
    public void Third()
    {
        SceneManager.LoadScene(20);
    }

    // NOTE: 案例四
    public void Four()
    {
        SceneManager.LoadScene(21);
    }

    // NOTE: 案例五
    public void Five()
    {
        SceneManager.LoadScene(26);
    }

    // NOTE: 案例六
    public void Six()
    {
        SceneManager.LoadScene(27);
    }

    // NOTE: 案例七
    public void Seven()
    {
        SceneManager.LoadScene(28);
    }

    // NOTE: 案例八
    public void Eight()
    {
        SceneManager.LoadScene(36);
    }
}
