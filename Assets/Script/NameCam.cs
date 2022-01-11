using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameCam : MonoBehaviour
{
    public GameObject Cam;

    private void Awake()
    {
        Cam = GameObject.Find("PlayerCamera");
    }

    void Update()
    {
        transform.rotation = Cam.transform.rotation;
    }
}
