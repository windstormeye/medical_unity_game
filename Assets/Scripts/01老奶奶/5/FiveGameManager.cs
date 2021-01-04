using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FiveGameManager : MonoBehaviour
{
    public static FiveGameManager instance;
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

    // NOTE: 休息
    public void Break()
    {
        menuPanel.SetActive(false);
        overPanel.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }

    private IEnumerator DelayShowMenuPanel()
    {
        // NOTE: 延迟 5s 出菜单
        yield return new WaitForSeconds(5);
        menuPanel.SetActive(true);
    }
}
