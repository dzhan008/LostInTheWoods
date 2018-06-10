using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionNode : MonoBehaviour {

    public List<string> requiredConditions; //The conditions you want to check in order to fire an event
    public string eventName; //The event you want to fire if the conditions are fulfilled.
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if(GameManager.Instance.CheckConditions(requiredConditions))
            {
                Trigger();
                Destroy(this.gameObject);
            }
            else
            {
                Debug.Log("Conditions not fulfilled! Please come back when you passed all the conditions!");
            }
        }
    }

    public void Trigger()
    {
        GameManager.Instance.FireEvent(eventName);
    }
}
