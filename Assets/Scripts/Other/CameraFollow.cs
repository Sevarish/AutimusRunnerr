using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    Transform target;
    Transform camT;
	// Use this for initialization
	void Start () {
        camT = GetComponent<Transform>();
        target = GameObject.Find("Player").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        camT.transform.position = new Vector3(target.transform.position.x + 2,4,-10);
	}
}
