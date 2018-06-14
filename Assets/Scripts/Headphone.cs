using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Headphone : MonoBehaviour {

    public GameObject[] appearObj;
    private void showObjects()
    {
        for (int i = 0; i < appearObj.Length; i++)
        {
            Debug.Log(i);
            appearObj[i].GetComponent<Door>().Open();
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && other.GetComponent<Player>().interacting)
        {
            showObjects();
            Destroy(this.gameObject);
        }
    }


}
