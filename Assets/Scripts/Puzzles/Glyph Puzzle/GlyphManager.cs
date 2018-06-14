using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlyphManager : Singleton<GlyphManager> {

    public List<string> answer;
    public List<Glyph> glyphs;
    public List<Door> doors;
    public bool solved = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CheckAnswer()
    {
        for(int i = 0; i < answer.Count; i++)
        {
            if(answer[i] != glyphs[i].symbolText.text)
            {
                Debug.Log("Incorrect!");
                return;
            }
        }
        Debug.Log("Correct!");
        GameManager.Instance.UpdateCondition("GlyphPuzzleCompleted");
        foreach(Door door in doors)
        {
            door.Open();
        }
        solved = true;
        SoundManager.Instance.PlaySFX("sfx_stone_door_slide");
    }
}
