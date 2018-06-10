using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(DecisionNode))]
public class TriggerableObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        GetComponent<DecisionNode>().Trigger();
    }
}
