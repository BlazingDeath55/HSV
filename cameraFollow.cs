using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {

    public GameObject c;
    public float velocityY;
    public float velocityX;
    public float velocityZ;
    public float speed;
    Vector3 off;
    Rigidbody rb;

	// Use this for initialization
	void Start () {
        off = transform.position - c.transform.position;
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        c.transform.position = transform.position - off;
	}

    private void FixedUpdate()
    {
        velocityX = 0;
        velocityZ = 0;

        if (Input.GetKey(KeyCode.W))
        {
            velocityZ += speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            velocityX -= speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            velocityZ -= speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            velocityX += speed;
        }


        rb.velocity = new Vector3(velocityX, velocityY, velocityZ);
    }
}
