using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraView : MonoBehaviour {

    Camera c1;
    public Camera c2;
    Vector3 ypos;

	// Use this for initialization
	void Start () {
        c1 = Camera.main;
        c1.enabled = true;
        c2.enabled = false;
        ypos = c1.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(c1.transform.position);
		if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (c1.enabled)
            {
                c2.enabled = true;
                c1.enabled = false;

            }
            else if (!c1.enabled)
            {
                c1.enabled = true;
                c2.enabled = false;
            }
        }
	}
}
