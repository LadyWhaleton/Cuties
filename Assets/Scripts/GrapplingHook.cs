using UnityEngine;
using System.Collections;

public class GrapplingHook : MonoBehaviour {
    public GameObject hook;
    bool hooked;

    private void shootHook()
    {
        GameObject bullet = (GameObject)Instantiate(hook, transform.position, Quaternion.identity);

        bullet.GetComponent<Rigidbody>().velocity = new Vector3(1, 0, 0);
    }

    private void pull()
    {

    }

	// Use this for initialization
	void Start () {
        hooked = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(1))
        {
            shootHook();
            Debug.Log("Pressed right click.");
        }

        hooked = false;

    }
}
