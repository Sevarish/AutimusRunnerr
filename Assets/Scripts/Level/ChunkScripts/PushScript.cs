using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushScript : MonoBehaviour {
    Transform myT;
	// Use this for initialization
	void Start () {
        myT = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
                myT.transform.Rotate(0, 5, 0);
	}
}
