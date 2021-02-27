using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagerWithOO : MonoBehaviour
{
    // 饮食
    public GameObject diet;
    public GameObject pill;
    public GameObject sport;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GotoDietScene()
    {
        SceneManager.LoadScene(9);
    }

    public void GotoPillScene()
    {
        SceneManager.LoadScene(12);
    }

    public void GotoSportScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
