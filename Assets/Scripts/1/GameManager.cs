using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private OldLadyController oldLady;

    private void Start()
    {
        StartCoroutine(DelayShowEatPillPanel());
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        oldLady = FindObjectOfType<OldLadyController>();
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private IEnumerator DelayShowEatPillPanel()
    {
        // NOTE: 延迟 5s 出慈丹
        yield return new WaitForSeconds(5);
        UIManager.instance.ShowEatPillPanel();

    }
}
