using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNameCon : MonoBehaviour
{
    public GameObject Player;
    public TextMesh PlayerName;
    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Name");
        PlayerName = Player.GetComponent<TextMesh>();
    }

    void Start()
    {
        PlayerName.text = Singleton.GetInstance.InputName.text;
    }

}
