using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FourGameManager : MonoBehaviour
{
    public static FourGameManager instance;
    public GameObject menuPanel;
    public GameObject overPanel;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(instance);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DelayShowMenuPanel());
    }

    // Update is called once per frame
    void Update()
    {

    }

    // NOTE: 在医院输液
    public void InHospital()
    {
        menuPanel.SetActive(false);
        overPanel.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }

    // NOTE: 回家
    public void GoHome()
    {
        menuPanel.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private IEnumerator DelayShowMenuPanel()
    {
        // NOTE: 延迟 5s 出菜单
        yield return new WaitForSeconds(5);
        menuPanel.SetActive(true);
    }
}
