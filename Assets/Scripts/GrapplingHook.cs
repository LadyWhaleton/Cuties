using UnityEngine;
using System.Collections;

public class GrapplingHook : MonoBehaviour {
    public GameObject bullet;
    Camera cam;
    public float velocity;
    float length;
    public float hookspeed;
    public GameObject player;
    bool hooking;
    RaycastHit hit;



    private void shootHook()
    {
        Vector3 dir = transform.TransformDirection(Vector3.forward);
        //if (!hooking)
        //{
        //    bullet = (GameObject)Instantiate(bullet, transform.position, transform.rotation);
        //}

        hooking = true;
        Debug.DrawRay(transform.position, dir, Color.yellow, 100);
        Ray ray = new Ray(transform.position, dir);
        if (!Physics.Raycast(transform.position, dir, out hit, length))
        {
            length += hookspeed;
            Debug.Log(length);
            bullet.transform.position = transform.forward * length;


        }
        else
        {
            player.transform.position = hit.point;
            length = 0;
            Destroy(bullet.gameObject);
            hooking = false;
        }

    }


	// Use this for initialization
	void Start () {
        hooking = false;
        cam = Camera.main;
        length = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(1))
        {
            shootHook();
            //Debug.Log("Pressed right click.");
        }

        else
        {
            length = 0;
            hooking = false;

        }

    }
}
