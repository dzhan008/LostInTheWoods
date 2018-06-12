using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour {

    public bool triggered = false;
    public GameObject wiredObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        triggered = true;
        wiredObject.GetComponent<Door>().Open();
    }

    private void OnTriggerExit(Collider other)
    {
        triggered = false;
        wiredObject.GetComponent<Door>().Close();
    }
}
