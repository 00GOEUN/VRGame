using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iTemRanCon : MonoBehaviour
{
    public GameObject HpOBJ;

    public int ObjMax = 10;

    private void Awake()
    {
        HpOBJ = GameObject.FindGameObjectWithTag("HP");
    }

    void Start()
    {
        //Vector3 vector3 = transform.position;

        for(int i = 0; i < ObjMax; i++)
        {
            Point();
            //this.transform.position = new Vector3(Random.Range(-5, 5), 1.0f, Random.Range(0, 5));
            //HpOBJ.transform.parent = gameObject.transform;
        }

        HpOBJ.SetActive(false);
    }

    private Vector3 RanPoint()
    {
        Vector3 vector3 = transform.position;

        float posX = Random.Range(-60, -12);
        float posY = 1.0f;
        float posZ = Random.Range(-30, 20);

        Vector3 HpPoint = new Vector3(posX, posY, posZ);

        return HpPoint;

    }

    private void Point()
    {
        Vector3 spawnPos = RanPoint();//랜덤위치함수

        GameObject instance = Instantiate(HpOBJ, spawnPos, Quaternion.identity);
        //gameObject.Add(instance);
    }


}