using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIManagerWithFoodFirst : MonoBehaviour
{

    public GameObject FirstPanel;
    public GameObject SecondPanel;
    public GameObject ThirdPanel;
    public GameObject FourPanel;
    public GameObject FivePanel;
    public GameObject OverPanel;
    public GameObject RestartPanel;

    // Start is called before the first frame update
    void Start()
    {
        showFirstPanel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showFirstPanel()
    {
        FirstPanel.SetActive(true);
    }
}
