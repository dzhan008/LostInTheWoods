using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Pickable")
        {
            if(other.GetComponent<PickableObject>().name == "Bucket")
            {
                other.GetComponent<Bucket>().ToggleWater(true);
                SoundManager.Instance.PlaySFX("sfx_water_pick_up");
            }
        }
    }
}
