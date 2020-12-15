using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public GameObject eatPillPanel;


    public OldLadyController oldLady;


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

    public void MoveToSofa()
    {
        eatPillPanel.SetActive(false);
        oldLady.MoveToSofa();
    }
}
