using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject pr1;
    public GameObject pr2;
    public GameObject pr3;
    public GameObject pr4;
    public GameObject pr5;
    public GameObject pr6;
    public GameObject pr7;
    public GameObject play;
    int rand;
    float timer;
    public float diff;
    Vector3 pos;


    // Use this for initialization
    void Start () {
        timer = diff;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            rand = (int)Random.Range(1f, 7.99f);
            pos = new Vector3(Random.Range(-20f, 20f), play.transform.position.y - 150, Random.Range(-20f, 20f));
            if (rand == 1)
            {
                Instantiate(pr1, pos, Quaternion.identity);

            }
            if (rand == 2)
            {
                Instantiate(pr2, pos, Quaternion.identity);

            }
            if (rand == 3)
            {
                Instantiate(pr3, pos, Quaternion.identity);

            }
            if (rand == 4)
            {
                Instantiate(pr4, pos, Quaternion.identity);

            }
            if (rand == 5)
            {
                Instantiate(pr5, pos, Quaternion.identity);

            }
            if (rand == 6)
            {
                Instantiate(pr6, pos, Quaternion.identity);

            }
            if (rand == 7)
            {
                Instantiate(pr7, pos, Quaternion.identity);

            }
            timer = diff;
        }
        
	}
}
