using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public GameObject player;
    public Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector3(0, 0, 5);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector3(0, 0, -5);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3(5, 0, 0);
        }

        else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(-5, 0, 0);
        }

        else
        {
            rb.velocity = new Vector3(0, 0, 0);
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
