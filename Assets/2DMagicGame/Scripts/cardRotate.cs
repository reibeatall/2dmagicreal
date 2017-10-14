using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardRotate : MonoBehaviour {
    public GameObject gameObject;
    public int rotateSpeed;
    public string levelName;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

   }

    void OnMouseOver()
    {
        gameObject.transform.Rotate(Vector3.up * rotateSpeed);
        if (Input.GetMouseButton(0)){

            Application.LoadLevel(levelName);
        }
    }
}
