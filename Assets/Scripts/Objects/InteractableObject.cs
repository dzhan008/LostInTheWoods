using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(DecisionNode))]
public class InteractableObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player" && other.GetComponent<Player>().interacting)
        {
            GetComponent<DecisionNode>().Trigger();
            Destroy(this.gameObject);
        }
    }
}
