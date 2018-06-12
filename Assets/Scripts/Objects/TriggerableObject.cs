using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(DecisionNode))]
public class TriggerableObject : MonoBehaviour {

    public string expectedTag;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == expectedTag)
        {
            GetComponent<DecisionNode>().Trigger();
        }
    }
}
