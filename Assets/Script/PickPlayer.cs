using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PickPlayer : MonoBehaviour
{

    private GameObject Ambulance;
    private GameObject Hatchback;
    private GameObject Police;
    private GameObject Sedan;

    public int Player;

    public GameObject LoadingUI;
    public GameObject LoadingNotUI;

    private void Awake()
    {
        Ambulance = GameObject.Find("Ambulance");
        Hatchback = GameObject.Find("Hatchback");
        Police = GameObject.Find("Police");
        Sedan = GameObject.Find("Sedan");
        LoadingUI = GameObject.Find("Loading");
        LoadingNotUI = GameObject.Find("LoadingNot");
    }

    private void Start()
    {
        Player = 0;
        Ambulance.SetActive(true);
        Hatchback.SetActive(false);
        Police.SetActive(false);
        Sedan.SetActive(false);
        LoadingUI.SetActive(false);
        LoadingNotUI.SetActive(false);
    }

    private void Update()
    {
        PlayerPick();
    }


    public void RightButton()
    {
        Player += 1;
        if (Player > 3)
        {
            Player = 0;
        }
    }
    public void LeftButton()
    {
        Player -= 1;
        if(Player < 0)
        {
            Player = 3;
        }
    }

    public void PlayerPick()
    {
        if(Player == 0)
        {
            Ambulance.SetActive(true);
            Hatchback.SetActive(false);
            Police.SetActive(false);
            Sedan.SetActive(false);
        }
        if (Player == 1)
        {
            Ambulance.SetActive(false);
            Hatchback.SetActive(true);
            Police.SetActive(false);
            Sedan.SetActive(false);
        }
        if (Player == 2)
        {
            Ambulance.SetActive(false);
            Hatchback.SetActive(false);
            Police.SetActive(true);
            Sedan.SetActive(false);
        }
        if (Player == 3)
        {
            Ambulance.SetActive(false);
            Hatchback.SetActive(false);
            Police.SetActive(false);
            Sedan.SetActive(true);
        }
    }
    public void LoadingButton()
    {
        LoadingUI.SetActive(true);
        Invoke("Scene3D", 0.3f);
        //if (Application.internetReachability == NetworkReachability.NotReachable)
        //{
        //    LoadingUI.SetActive(true);
        //    Invoke("Scene3D", 0.3f);
        //}
        //else if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork)
        //{
        //    LoadingUI.SetActive(true);
        //    Invoke("Scene3D", 0.3f);
        //}
        //else
        //{
        //    LoadingNotUI.SetActive(true);
        //}

    }
    public void XButton()
    {
        LoadingNotUI.SetActive(false);
    }

    public void Scene3D()
    {
        Singleton.GetInstance.ScoerCount = 0;
        Singleton.GetInstance.TimeCount = 60;
        SceneManager.LoadScene(3);
    }
}
