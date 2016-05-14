﻿using UnityEngine;
using System.Collections;

public class Cutie : MonoBehaviour {

    Rigidbody body;
    public float velocity;

	// Use this for initialization
	void Start () {
        body = GetComponent<Rigidbody>();

        if (velocity == 0)
            velocity = 1;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter (Collider col)
    {
        if (col.gameObject.tag == "KillZone")
        {
            Destroy(this.gameObject);
            Debug.Log("Death!");
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "KillZone")
        {
            Destroy(this.gameObject);
            Debug.Log("Death by cube!");
        }
    }
}
