using UnityEngine;
using System.Collections;

public class CutieSpawner : MonoBehaviour {

    public FloatRange timeBetweenSpawns, scale, randomVelocity, angularVelocity;
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
            velocity = 30;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void SpawnCuties()
    {
        Cutie cutiePrefab = cutiePrefabs[Random.Range(0, cutiePrefabs.Length)];
        Cutie currCutie = Instantiate<Cutie>(cutiePrefab);

        currCutie.transform.localPosition = transform.position;
        currCutie.transform.localScale = Vector3.one * scale.RandomInRangeAlt(0.25f, 1);
        currCutie.transform.localRotation = Random.rotation;

        // Randomize velocity 
        currCutie.GetComponent<Rigidbody>().velocity = transform.up * velocity +
             Random.onUnitSphere* randomVelocity.RandomInRange;
        currCutie.GetComponent<Rigidbody>().angularVelocity =
            Random.onUnitSphere * angularVelocity.RandomInRangeAlt(0, 3);
    }
}
