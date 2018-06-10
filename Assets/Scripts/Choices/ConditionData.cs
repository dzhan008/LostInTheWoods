using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ConditionData", order = 1)]
public class ConditionData : ScriptableObject {

    public string conditionName;
    public string description;
    public int triggerAmount;
    public bool persistent;
}
