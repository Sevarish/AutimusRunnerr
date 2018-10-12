using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallMove : MonoBehaviour {
    float destructTimer = 0;
    PlayerMovement scriptReference;
	// Use this for initialization
	void Start () {
        scriptReference = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(30 * Time.deltaTime, 0, 0);
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 20))
        {
            Destroy(this.gameObject);
            scriptReference.isSlowed = true;
        }

        destructTimer += Time.deltaTime;
            if (destructTimer > 40)
            {
                Destroy(this.gameObject);
            }
        }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(this.gameObject);
            scriptReference.isSlowed = true;
        }
    }

}
