using UnityEngine;
using System.Collections;

public class CutieSpawner : MonoBehaviour {

    public FloatRange timeBetweenSpawns, scale;
    float currSpawnDelay;

    public Cutie[] cutiePrefabs;
    public float velocity; 

    float timeSinceLastSpawn;

    void FixedUpdate() {
        timeSinceLastSpawn += Time.deltaTime;
        if (timeSinceLastSpawn >= currSpawnDelay)
        {
            timeSinceLastSpawn -= currSpawnDelay;
            currSpawnDelay = timeBetweenSpawns.RandomInRange;
            SpawnCuties();
        }
    }

    void Awake() {
        timeSinceLastSpawn = 0;
    }

    // Use this for initialization
    void Start () {
        if (velocity == 0)
            velocity = 15;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void SpawnCuties()
    {
        Cutie cutiePrefab = cutiePrefabs[Random.Range(0, cutiePrefabs.Length)];
        Cutie currCutie = Instantiate<Cutie>(cutiePrefab);

        currCutie.transform.localPosition = transform.position;
        currCutie.transform.localScale = Vector3.one * scale.RandomInRange;
        currCutie.transform.localRotation = Random.rotation;
        currCutie.GetComponent<Rigidbody>().velocity = transform.up * velocity;
    }
}
