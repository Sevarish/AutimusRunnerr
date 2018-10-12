using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupScript : MonoBehaviour {
    public GameObject powerUpSpeed;
    ChunkSpawner scriptReference;
    float timer = 0;
    float maxTime;
	// Use this for initialization
	void Start () {
        scriptReference = GameObject.Find("ChunkManager").GetComponent<ChunkSpawner>();
        maxTime = Random.Range(20, 40);
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        
        if (timer > maxTime)
        {
            
            Instantiate(powerUpSpeed, new Vector3(scriptReference.spawnPos - 10, 3, 0), Quaternion.identity);
            timer = 0;
            maxTime = Random.Range(30, 50);
        }
	}
}
