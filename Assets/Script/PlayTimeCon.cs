using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayTimeCon : MonoBehaviour
{
    public float tTime = 60f;

    public Text TimeText;

    public GameObject OverUI;
    public GameObject ClearUI;

    private void Awake()
    {
        TimeText = GameObject.Find("TimeCount").GetComponent<Text>();
        OverUI = GameObject.Find("GameOver");
        ClearUI = GameObject.Find("GameClear");
    }

    void Start()
    {
        Singleton.GetInstance.TimeCount = tTime;
        OverUI.SetActive(false);
        ClearUI.SetActive(false);
    }

    void Update()
    {
        if (Mathf.Floor(Singleton.GetInstance.TimeCount) <= 0)
        {
            Invoke("GameOver", 0.1f);
        }
        else
        {
            if (ClearUI.activeSelf == false)
            {
                Singleton.GetInstance.TimeCount -= Time.deltaTime;
                TimeText.text = Mathf.Floor(Singleton.GetInstance.TimeCount).ToString();

            }
        }

    }
    private void GameOver()
    {
        OverUI.SetActive(true);

    }
}
