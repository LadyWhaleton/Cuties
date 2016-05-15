using UnityEngine;
using System.Collections;

public class Cutie : MonoBehaviour {

    Rigidbody body;
    public float velocity;
    public GameObject GameManager;

	// Use this for initialization
	void Start () {

        if (GameManager == null)
            GameManager = GameObject.Find("GameManager");
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
        }

        if (col.CompareTag("Cup"))
        {
            Timer.instance.IncrementScore();
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "KillZone")
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("Cup"))
            Timer.instance.DecrementScore();
    }
}
