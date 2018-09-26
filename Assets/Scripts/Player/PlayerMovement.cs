using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Transform playerT;
    Rigidbody rb;
    public float moveSpeed;
    float maxMoveSpeed = 15;
    float jumpThrust = 500f;
    float jumpTimer = 2;
	// Use this for initialization
	private void Start () {
        playerT = GetComponent<Transform>();
        moveSpeed = 8;
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	private void Update () {
        jumpTimer += Time.deltaTime;
		if (Input.GetKey(KeyCode.D))
        {
            playerT.Translate(moveSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            playerT.Translate(-moveSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space) && jumpTimer > 1.1f)
        {
            rb.AddForce(transform.up * jumpThrust);
            jumpTimer = 0;
        }
	}

}
