using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardRotate : MonoBehaviour {
    public GameObject gameObject;
    public int rotateSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.Rotate(Vector3.up * rotateSpeed);
	}
}
