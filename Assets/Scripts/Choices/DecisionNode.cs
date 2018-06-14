using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionNode : MonoBehaviour {

    public string targetCondition; //The condition you want to trigger.

    //Conditions that you want to disable upon triggering this decision.
    //We may want this if we don't want to trigger specific events on accident
    //For example, if I chose from 3 different paths I may want to disable the events for the other two
    //Once I pick one.
    public List<string> disabledConditions;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Trigger()
    {
        if(enabled)
        {
            GameManager.Instance.UpdateCondition(targetCondition);
            this.enabled = false;
        }
    }
}
