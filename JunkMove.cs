using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkMove : MonoBehaviour {

	public GameObject p;
    public GameObject box;
    public Vector3 start;
    public Vector3 v;
    public Quaternion q;
    public bool despawn;
	// Use this for initialization
	void Start () {
        start = p.transform.position -new Vector3(0, 150, 0);
        GetComponent<Rigidbody>().velocity = v;
        GetComponent<Rigidbody>().rotation = q;
        despawn = false;
    }
	
	// Update is called once per frame
	void Update () {

	}
	
	void OnCollisionEnter (Collision c)
	{
		if(c.other == p.GetComponent<Collider>())
		{
			//collided with ship
		}
        if (c.other == box.GetComponent<Collider>())
        {
            despawn = true;
        }


	}
}
