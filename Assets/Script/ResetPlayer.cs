using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayer : MonoBehaviour
{
    public Character Player;

    // Update is called once per frame
    void Update()
    {
        PlayerOBJCon.instance.currentPlayer = Player;
    }
}
