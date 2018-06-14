using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Glyph : MonoBehaviour {

    public List<string> symbols;
    public Text symbolText;
    private int currIndex = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeSymbol()
    {
        if (GlyphManager.Instance.solved) return;
        currIndex++;
        if (currIndex == symbols.Count)
        {
            currIndex = 0;
        }

        symbolText.text = symbols[currIndex];

        GlyphManager.Instance.CheckAnswer();
    }
}
