using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneMng : MonoBehaviour
{
    public void ARButton()
    {
        SceneManager.LoadScene(0);
    }
    public void ColorButton()
    {
        SceneManager.LoadScene(1);
    }
    public void CarChangeButton()
    {
        SceneManager.LoadScene(2);

    }
    //public void Play3DButton()
    //{
    //    Invoke("Scene3D", 0.3f);
    //}
    //public void ResetData()
    //{
    //    Singleton.GetInstance.ScoerCount = 0;
    //    Singleton.GetInstance.TimeCount = 60;
    //}
    //public void Scene3D()
    //{
    //    SceneManager.LoadScene(3);
    //}
}
