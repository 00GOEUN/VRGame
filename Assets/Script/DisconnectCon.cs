using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisconnectCon : MonoBehaviour
{

    private GameObject ARChoice;



    private void Awake()
    {
        ARChoice = GameObject.Find("ARChoice");
    }
    // Start is called before the first frame update
    void Start()
    {
        ARChoice.SetActive(false);
    }

    public void ARchoiceButton()
    {
        ARChoice.SetActive(true);
        
    }
    public void ARCancelButton()
    {
        ARChoice.SetActive(false);
    }
}
