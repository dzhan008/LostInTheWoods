using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager> {

    public Dictionary<string, Condition> conditions;

	// Use this for initialization
	void Start () {
        conditions = new Dictionary<string, Condition>();
        LoadConditions();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadConditions()
    {
        Object[] conditionData = Resources.LoadAll("Conditions", typeof(ConditionData));
        foreach (ConditionData data in conditionData)
        {
            if(!conditions.ContainsKey(data.conditionName))
            {
                Condition condition = new Condition(data.conditionName, data.description, data.triggerAmount);
                conditions.Add(data.conditionName, condition);
            }

        }
    }

    public void UpdateCondition(string conditionName)
    {
        if(conditions.ContainsKey(conditionName))
        {
            conditions[conditionName].UpdateCondition();
        }
    }

    //Checks if a set of conditions has been fulfilled already.
    public bool CheckConditions(List<string> conditionNames)
    {
        foreach(string conditionName in conditionNames)
        {
            if (!conditions.ContainsKey(conditionName) || !conditions[conditionName].fulfilled)
            {
                Debug.Log("Failed condition!");
                return false;
            }
        }
        return true;
    }

    public void FireEvent(string eventName)
    {
        Debug.Log(eventName + " has been fired!");
    }

    //Resets the game if an ending is reached
    public void ResetGame()
    {
        List<string> conditionKeys = new List<string>(conditions.Keys);
        //Look for any persistent conditions and delete them.
        foreach(string key in conditionKeys)
        {
            if(!conditions[key].persistent)
            {
                conditions.Remove(key);
            }
        }
        LoadConditions();
    }
}
