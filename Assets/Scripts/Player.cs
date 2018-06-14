using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public bool interacting = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.E))
        {
            interacting = true;
        }
        else
        {
            interacting = false;
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            GameManager.Instance.ResetGame();
            Debug.Log("Resetting Game!");
        }
		
	}
}
