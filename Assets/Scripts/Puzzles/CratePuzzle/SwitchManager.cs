using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchManager : Singleton<SwitchManager> {

    public Text equationText;
    public TextPop glyphText;
    public SnapZone[] pedestolSnapZone;
    public GameObject[] appearObj;
    public bool puzzleDone = false;
    private int numPedestols = 5;
    private int numAnswer = 3;
    private int numEquations = 2;
    private List<bool> answerKey;

    
    // Use this for initialization
    void Start () {
        answerKey = new List<bool>(new bool[numPedestols]);
        generateEquation(numEquations);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void showObjects()
    {
        for (int i = 0; i < appearObj.Length; i++)
        {
            appearObj[i].GetComponent<Door>().Open();
        }
    }
    private void generateEquation(int numEq)
    {
        int i = 0;
        string text = "";
        while (i < numEq)
        {
            int firstNum = Random.Range(0, numPedestols);
            Debug.Log(firstNum);
            int secondNum = Random.Range(0, numPedestols - firstNum);
            Debug.Log(secondNum);
            int index = firstNum + secondNum;
            if (answerKey[index] != true)
            {
                text += firstNum + " + " + (secondNum + 1) + " = ?\n";
                answerKey[index] = true;
                i++;
            }
        }
        equationText.text = text;
        return;
    }
    public bool checkPuzzle(GameObject obj)
    {
        if (puzzleDone) return true;
        for (int i = 0; i < answerKey.Count; i++)
        {
            if (answerKey[i] != pedestolSnapZone[i].objectSnapped)
            {
                return false;
            }
        }
        puzzleDone = true;
        showObjects();
        glyphText.spawnText();
        return true;

    }
}
