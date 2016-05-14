using UnityEngine;
using System.Collections;

/*
    CutieSpawnerRing's purpose is to spawn multiple CutieSpawners 
    so that the Cuties will spawn in a fountain formation or whatever
    shape you want. You just have to change the position of each
    CutieSpawner in the scene to get a different shape.
*/

public class CutieSpawnerRing : MonoBehaviour {

    public int numSpawners;
    public float radius, tiltAngle;
    public CutieSpawner spawnerPrefab;


    void Awake() {
        numSpawners = transform.childCount;

        if (numSpawners == 0)
            numSpawners = 20;

        if (radius == 0)
            radius = 20;

        if (tiltAngle == 0)
            tiltAngle = -20;

        for (int i = 0; i < numSpawners; i++)
            CreateSpawner(i);

    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void CreateSpawner (int index) {
        Transform rotater = new GameObject("Rotater").transform;
        rotater.SetParent(transform, false);
        rotater.localRotation =
            Quaternion.Euler(0f, index * 360f / numSpawners, 0f);

        CutieSpawner currSpawner = Instantiate<CutieSpawner>(spawnerPrefab);
        currSpawner.transform.SetParent(rotater, false);
        currSpawner.transform.localPosition = new Vector3(0f, 0f, radius);
        currSpawner.transform.localRotation = Quaternion.Euler(tiltAngle, 0f, 0f);
    }
}
