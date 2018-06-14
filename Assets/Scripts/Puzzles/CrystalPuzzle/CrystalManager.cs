using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalManager : Singleton<CrystalManager> {
    public SnapZone[] crystalHolder;
    public int numCrystals = 4;
    public bool puzzleDone = false;
    //public GameObject[] appearObj;
    public GameObject elevator;
    private List<bool> answerKey;
	// Use this for initialization
	void Start () {
        answerKey = new List<bool>(new bool[numCrystals]);
        for (int i = 0; i < answerKey.Count; i++)
        {
            answerKey[i] = true;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    /*private void showObjects()
    {
        for (int i = 0; i < appearObj.Length; i++)
        {
            appearObj[i].GetComponent<Door>().Open();
        }

    }*/
    public bool checkPuzzle(GameObject obj)
    {
        if (puzzleDone) return true;
        for (int i = 0; i < answerKey.Count; i++)
        {
            if (answerKey[i] != crystalHolder[i].objectSnapped)
            {
                return false;
            }
        }
        //showObjects();
        puzzleDone = true;
        elevator.GetComponent<PressurePlate>().enabled = true;
        return true;

    }
}
