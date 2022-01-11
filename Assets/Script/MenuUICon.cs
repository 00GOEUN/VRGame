using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuUICon : MonoBehaviour
{
    private bool MenuOnChake;
    private bool BTOnChake;

    public Image BTImage;

    public GameObject MenuOn;
    public GameObject MenuOff;
    public GameObject ARChange;
    public GameObject VRChange;
    public GameObject Color;
    public GameObject CarChange;
    public GameObject BluetoothOff;
    public GameObject BluetoothUI;
    public GameObject Setting;



    private void Awake()
    {
        MenuOn = GameObject.Find("MenuOn");
        MenuOff = GameObject.Find("MenuOff");
        ARChange = GameObject.Find("ARChange");
        VRChange = GameObject.Find("VRChange");
        Color = GameObject.Find("Color");
        CarChange = GameObject.Find("CarChange");
        BluetoothOff = GameObject.Find("BluetoothOff");
        BTImage = BluetoothOff.GetComponent<Image>();
        BluetoothUI = GameObject.Find("BluetoothBack");
        Setting = GameObject.Find("Setting");
    }

    // Start is called before the first frame update
    void Start()
    {
        MenuOnChake = false;

        ARChange.SetActive(false);
        VRChange.SetActive(false);
        Color.SetActive(false);
        CarChange.SetActive(false);
        BluetoothOff.SetActive(false);
        BluetoothUI.SetActive(false);
        Setting.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        

        if (MenuOnChake)
        {
            MenuOn.SetActive(false);
            MenuOff.SetActive(true);
            ARChange.SetActive(true);
            VRChange.SetActive(true);
            Color.SetActive(true);
            CarChange.SetActive(true);
            BluetoothOff.SetActive(true);
            Setting.SetActive(true);
            
        }
        if(MenuOnChake == false)
        {
            MenuOn.SetActive(true);
            MenuOff.SetActive(false);
            ARChange.SetActive(false);
            VRChange.SetActive(false);
            Color.SetActive(false);
            CarChange.SetActive(false);
            BluetoothOff.SetActive(false);
            Setting.SetActive(false);
        }

        if (BTOnChake)
        {
            BluetoothUI.SetActive(true);
            BTChange();
        }
        if (BTOnChake == false)
        {
            BluetoothUI.SetActive(false);
        }


    }

    public void ManuOnButton()
    {
        MenuOnChake = true;
    }

    public void ManuOffButton()
    {
        MenuOnChake = false;
    }

    public void BTOnbutton()
    {
        BTOnChake = true;
    }
    public void BTOffButton()
    {
        BTOnChake = false;
    }

    private void BTChange()
    {
        BTImage.sprite = Resources.Load<Sprite>("img/Menu_BlueToothOn") as Sprite;
    }
}
