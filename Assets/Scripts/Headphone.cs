using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Headphone : MonoBehaviour {

    public GameObject[] appearObj;
    public void showObjects()
    {
        for (int i = 0; i < appearObj.Length; i++)
        {
            Debug.Log(i);
            appearObj[i].GetComponent<Door>().Open();
        }
        SoundManager.Instance.PlaySFX("sfx_sci_fi_door_open");
        Destroy(this.gameObject);
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && other.GetComponent<Player>().interacting)
        {
            showObjects();
            Destroy(this.gameObject);
        }
    }


}
