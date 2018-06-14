using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextPop : MonoBehaviour {
    public Text glyphText;
    public string glyphString;
    IEnumerator SpawnText()
    {
        for (int i = 0; i < glyphString.Length; i++)
        {
            glyphText.text += glyphString[i];
            yield return new WaitForSeconds(1);
        }
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void spawnText()
    {
        StartCoroutine(SpawnText());
    }
}
