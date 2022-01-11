using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Character
{
    Ambulance,
    Hatchback,
    Police,
    Sedan
}

public class PlayerOBJCon : MonoBehaviour
{
    public static PlayerOBJCon instance;
    private void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != null)
            return;
        DontDestroyOnLoad(gameObject);
    }

    public Character currentPlayer;
}
