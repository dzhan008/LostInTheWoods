using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {

    public GameObject fire;
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
                if (other.GetComponent<PickableObject>().name == "Bucket")
                {
                    other.GetComponent<Bucket>().ToggleWater(false);
                    fire.SetActive(false);
                    SoundManager.Instance.PlaySFX("sfx_fire_put_out");
                    doused = true;
                    GameManager.Instance.UpdateCondition("FirePuzzleCompleted");
                }
            }
        }

    }
}
