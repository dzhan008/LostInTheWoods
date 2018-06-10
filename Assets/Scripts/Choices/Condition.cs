using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Class for a simple condition made in a game
public class Condition : MonoBehaviour {

    private string conditionName; //The name of the condition. This is most likely going to be the ID of the condition that is checked.
    private string conditionDescription; //Some description for the condition
    public int counter
    {
        get
        {
            return _counter;
        }
        set
        {
            _counter = value;
            if(_counter >= maxCounter)
            {
                fulfilled = true;
                Debug.Log("Condition Fulfilled.");
            }
        }
    }
    private int _counter = 0;
    private int maxCounter; //The max counter for the condition. If there are multiple nodes a player needs to traverse, then it would be ideal to set it here.

    public bool fulfilled = false; //Checks if the condition is actually fulfilled
    public bool persistent; //Will the condition's state be persistent throughout playthroughs?

    public Condition(string name, string description)
    {
        conditionName = name;
        conditionDescription = description;
    }

    public Condition(string name, string description, int triggerAmount)
    {
        conditionName = name;
        conditionDescription = description;
        maxCounter = triggerAmount;
    }

    public void UpdateCondition()
    {
        Debug.Log("Updating Condition!");
        counter++;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
