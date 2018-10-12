using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkSpawner : MonoBehaviour {
    int spawnPos = 0;
    public Transform target;
    public GameObject[] chunks = {};
    // Use this for initialization
    void Start() {
        Instantiate(chunks[1], new Vector3(0,0,0), Quaternion.identity);
        spawnPos += 20;
	}
	
	// Update is called once per frame
	void Update () {
        

        if (target.transform.position.x > spawnPos - 25)
        {
           
            Instantiate(chunks[Random.Range(0, 8)], new Vector3(spawnPos, 0, 0), Quaternion.identity);
            spawnPos += 20;
        }
	}
}
