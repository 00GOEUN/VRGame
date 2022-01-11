using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameCon : MonoBehaviour
{
    //public InputField InputName;

    public GameObject NameUI;



    private void Awake()
    {
        NameUI = GameObject.Find("Name");
        Singleton.GetInstance.InputName = GameObject.Find("InputName").GetComponent<InputField>();
    }

    private void Start()
    {
        NameUI.SetActive(false);
        Singleton.GetInstance.InputName.text = "À¯Àú123";

    }

    public void SettingOn()
    {
        NameUI.SetActive(true);
    }

    public void SettingOff()
    {
        NameUI.SetActive(false);

    }

}
