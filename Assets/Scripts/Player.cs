using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public bool interacting = false;
    public Camera playerCamera;
    private bool holdingObject = false;
    private GameObject heldObject;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E))
        {

            if(!holdingObject)
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 100.0f))
                {
                    if (hit.transform.tag == "Glyph")
                    {
                        hit.transform.gameObject.GetComponent<Glyph>().ChangeSymbol();
                    }
                    else if (hit.transform.tag == "Pickable")
                    {
                        heldObject = hit.transform.gameObject;
                        if (hit.transform.gameObject.GetComponent<Rigidbody>() != null)
                        {
                            hit.transform.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                        }
                        hit.transform.parent = playerCamera.transform;
                        holdingObject = true;
                    }
                }
            }
            else
            {
                DetachObject();
            }

        }
        if(OVRInput.GetDown(OVRInput.Button.One))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(GameObject.Find("hands:b_r_index3").transform.position);
            if (Physics.Raycast(GameObject.Find("hands:b_r_index3").transform.position, transform.TransformDirection(Vector3.forward), out hit, 5.0f))
            {
                //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
                if (hit.transform.tag == "Glyph")
                {
                    hit.transform.gameObject.GetComponent<Glyph>().ChangeSymbol();
                }
                else if (hit.transform.tag == "Pickable")
                {
                    if(hit.transform.GetComponent<PickableObject>().name == "Headphones")
                    {
                        hit.transform.GetComponent<Headphone>().showObjects();
                    }
                }
            }
            else
            {
                //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
                Debug.Log("Did not Hit");
            }
        }
        if (Input.GetKey(KeyCode.F))
        {
            interacting = true;
        }
        else
        {
            interacting = false;
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            GameManager.Instance.ResetGame();
            Debug.Log("Resetting Game!");
        }
		
	}
    
    public void DetachObject()
    {
        Debug.Log("Detaching Object!");
        if (heldObject == null) return;
        heldObject.transform.parent = null;
        if (heldObject.GetComponent<Rigidbody>() != null)
        {
            heldObject.GetComponent<Rigidbody>().isKinematic = false;
        }
        holdingObject = false;
    }
}
