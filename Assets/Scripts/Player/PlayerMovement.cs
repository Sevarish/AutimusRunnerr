using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Transform playerT;
    Rigidbody rb;
    public float moveSpeed;
    float normalMoveSpeed = 9;
    float maxMoveSpeed = 16;
    float jumpThrust = 500f;
    public float jumpTimer = 1.5f;
    public bool isSlowed = false;
    public bool powerUpActive = false;
    float powerUpTimer = 0;
    bool doOnce = true;
    float slowTimer = 0;
    SpriteRenderer sprt;
    Animator anim;
	// Use this for initialization
	private void Start () {
        playerT = GetComponent<Transform>();
        moveSpeed = normalMoveSpeed;
        rb = GetComponent<Rigidbody>();
        sprt = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        Physics.IgnoreLayerCollision(0, 8, true); 
    }
	
	// Update is called once per frame
	private void Update () {
        jumpTimer += Time.deltaTime;
		if (Input.GetKey(KeyCode.D))
        {
            playerT.Translate(moveSpeed * Time.deltaTime, 0, 0);
            sprt.flipX = false;
            anim.Play("Run");
        }
        else if (Input.GetKey(KeyCode.A))
        {
            playerT.Translate(-moveSpeed * Time.deltaTime, 0, 0);
            sprt.flipX = true;
            anim.Play("Run");
        }
        else
        {
            anim.Play("Idle");
        }

        if (Input.GetKeyDown(KeyCode.Space) && jumpTimer > 1.5f)
        {
            rb.AddForce(transform.up * jumpThrust);
            jumpTimer = 0;
        }


        if (isSlowed == true)
        {
            slowTimer += Time.deltaTime;
            if (doOnce)
            {
                moveSpeed -= 4;
                doOnce = false;
            }
            if (slowTimer > 4)
            {
                moveSpeed = normalMoveSpeed;
                isSlowed = false;
                slowTimer = 0;
                doOnce = true;
            }
        }


        if (powerUpActive)
        {
            powerUpTimer += Time.deltaTime;
            moveSpeed = maxMoveSpeed;
            if (powerUpTimer > 5)
            {
                powerUpTimer = 0;
                powerUpActive = false;
                moveSpeed = normalMoveSpeed;
            }
        }

        if (playerT.position.y < 1.02f)
        {
           playerT.Translate(0,1,0);
        }
        
	}

}
