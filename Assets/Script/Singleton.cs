using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Singleton
{
    private static Singleton Instance = null;
    
    public static Singleton GetInstance
    {
        get
        {
            if (Instance == null)
                Instance = new Singleton();
    
            return Instance;
        }
    }

    public int playerChoice = 0;
    
    public int ScoerCount = 0;
    public float TimeCount = 0;
    
    public Text ScoerTxt;
    public Text TimeTxt;

    public InputField InputName;

    private Singleton() { }
}
