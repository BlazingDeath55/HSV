using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkMove : MonoBehaviour {

	gameObject g;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter (Collision c)
	{
		if(c.other==g.getcomponent<Collider>())
		{
			
		}
	}
}
