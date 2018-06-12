using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    public float openTime;
    public Transform targetPosition;
    private Vector3 originalPosition;
    private Vector3 currentPosition;
    // Use this for initialization
    void Start () {
         originalPosition = transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Open()
    {
        currentPosition = transform.position;
        StopAllCoroutines();
        StartCoroutine(OpenDoor());
    }

    public void Close()
    {
        currentPosition = transform.position;
        StopAllCoroutines();
        StartCoroutine(CloseDoor());
    }

    IEnumerator OpenDoor()
    {
        float elapsedTime = 0;
        while(elapsedTime < openTime)
        {
            transform.position = Vector3.Lerp(currentPosition, targetPosition.position, elapsedTime / openTime);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
    }

    IEnumerator CloseDoor()
    {
        float elapsedTime = 0;
        while (elapsedTime < openTime)
        {
            transform.position = Vector3.Lerp(currentPosition, originalPosition, elapsedTime / openTime);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
    }
}
