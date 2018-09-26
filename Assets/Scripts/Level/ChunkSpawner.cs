using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkSpawner : MonoBehaviour {
    int spawnPos = 0;
    float timer = 0;
    public GameObject[] chunks = {};
	// Use this for initialization
	void Start () {
        Instantiate(chunks[Random.Range(0, 2)], new Vector3(0,0,0), Quaternion.identity);
        spawnPos += 20;
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        if (timer > 5)
        {
            timer = 0;
            Instantiate(chunks[Random.Range(0, 2)], new Vector3(spawnPos, 0, 0), Quaternion.identity);
            spawnPos += 20;
        }
	}
}
