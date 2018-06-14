using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalPedestal : MonoBehaviour {

    public bool crystalPlaced = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Pickable" && other.GetComponent<PickableObject>().name == "Crystal")
        {
            Debug.Log("Crystal inside!");
            CrystalManager.Instance.UpdatePuzzle();
            crystalPlaced = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Pickable" && other.GetComponent<PickableObject>().name == "Crystal")
        {
            Debug.Log("Crystal outside!");
            CrystalManager.Instance.UpdatePuzzle();
            crystalPlaced = false;
        }
    }
}
