using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ThirdGameManager : MonoBehaviour
{
    public static ThirdGameManager instance;
    public GameObject menuPanel;
    public GameObject nextPanel;


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

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void NearHospital()
    {
        menuPanel.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ContinueGoNearHospital()
    {
        menuPanel.SetActive(false);
        StartCoroutine(DelayShowNextPanel());
    }

    private IEnumerator DelayShowNextPanel()
    {
        // NOTE: 延迟 5s 出菜单
        yield return new WaitForSeconds(5);
        nextPanel.SetActive(true);
    }

    private IEnumerator DelayShowMenuPanel()
    {
        // NOTE: 延迟 5s 出菜单
        yield return new WaitForSeconds(5);
        menuPanel.SetActive(true);
    }
}
