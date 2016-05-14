using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class gameManager : MonoBehaviour {

    public static List<Vector3> spawnLocations;
    public GameObject cup;
    private void spawnCup()
    {
        int x = Random.Range(0, 2);
        Instantiate(cup, spawnLocations[x], Quaternion.identity);             
    }

    // Use this for initialization
    void Awake()
    {
        spawnLocations = new List<Vector3>();
        spawnLocations.Add(new Vector3(-.38f, 2.39f, -2.22f));
        spawnLocations.Add(new Vector3(-7.25f, 2.28f, -2.22f));
        spawnLocations.Add(new Vector3(-.38f, 2.39f, 3.22f));

    }
    void Start () {
        spawnCup();

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
