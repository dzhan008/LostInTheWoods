using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {

    public GameObject fire;
    public GameObject crystal_1;
    public GameObject crystal_2;
    private bool doused;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(!doused)
        {
            if (other.tag == "Pickable")
            {
                if (other.GetComponent<PickableObject>().name == "Water Bucket")
                {
                    other.GetComponent<Bucket>().ToggleWater(false);
                    fire.SetActive(false);
                    SoundManager.Instance.PlaySFX("sfx_fire_put_out");
                    doused = true;
                    GetComponent<TextPop>().spawnText();
                    crystal_1.tag = "Pickable";
                    crystal_2.tag = "Pickable";
                    GameManager.Instance.UpdateCondition("FirePuzzleCompleted");
                }
            }
        }

    }
}
