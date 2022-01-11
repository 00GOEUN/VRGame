using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPoint : MonoBehaviour
{
    public GameObject[] charPrefabs;
    public GameObject PlayerOBJ;

    void Start()
    {
        PlayerOBJ = Instantiate(charPrefabs[(int)PlayerOBJCon.instance.currentPlayer]);
        PlayerOBJ.transform.parent = gameObject.transform;
    }

    private void Update()
    {
        PlayerOBJ.transform.position = transform.position;
    }
}
