using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextPop : MonoBehaviour {
    public Text glyphText;
    public string glyphString;
    public float delay;
    IEnumerator SpawnText()
    {
        for (int i = 0; i < glyphString.Length; i++)
        {
            glyphText.text += glyphString[i];
            if (i % 2 == 0) SoundManager.Instance.PlaySFX("Flash");
            yield return new WaitForSeconds(delay);
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
