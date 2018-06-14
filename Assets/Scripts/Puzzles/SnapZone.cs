using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SnapZone : MonoBehaviour {

    public Transform snapPoint;
    public bool objectSnapped;
    public GameObject snappedObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if(other.tag != "Player")
        {
            SnapObject(other.gameObject);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == snappedObject)
        {
            Debug.Log("Exiting snap zone!");
            objectSnapped = false;
            if (!SwitchManager.Instance.puzzleDone) SwitchManager.Instance.checkPuzzle(other.gameObject);
            //if (!CrystalManager.Instance.puzzleDone) CrystalManager.Instance.checkPuzzle(other.gameObject);
        }
    }

    public void SnapObject(GameObject obj)
    {
        if (objectSnapped) return;

        snappedObject = obj;
        Debug.Log(obj.transform.root.tag);
        obj.transform.position = snapPoint.position;
        obj.transform.rotation = snapPoint.rotation;
        if (obj.transform.root.tag == "Player")
        {
            obj.transform.root.GetComponent<Player>().DetachObject();
            if(obj.GetComponent<Rigidbody>())
            {
                obj.GetComponent<Rigidbody>().isKinematic = true;
            }
        }
        objectSnapped = true;
        if (!SwitchManager.Instance.puzzleDone) SwitchManager.Instance.checkPuzzle(obj);
        //if (!CrystalManager.Instance.puzzleDone) CrystalManager.Instance.checkPuzzle(obj);
    }
}
