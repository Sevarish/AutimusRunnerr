using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlenderScript : MonoBehaviour {
    Transform myT;
	// Use this for initialization
	void Start () {
        myT = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        myT.Rotate(new Vector3(0,0,5));
	}
}
