using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ITemCon : MonoBehaviour {

	public enum CollectibleTypes { Scoer, Time };

	public CollectibleTypes CollectibleType;

	private void Awake()
    {
		Singleton.GetInstance.ScoerTxt = GameObject.Find("RedScore").GetComponent<Text>();
		//Singleton.GetInstance.TimeTxt = GameObject.Find("TimeCount").GetComponent<Text>();
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			Collect ();
		}

		gameObject.SetActive(false);
	}

	public void Collect()
	{

		if (CollectibleType == CollectibleTypes.Scoer)
		{

			Singleton.GetInstance.ScoerCount += 10;
		}

		Singleton.GetInstance.ScoerTxt.text = Singleton.GetInstance.ScoerCount.ToString();
	}
}
