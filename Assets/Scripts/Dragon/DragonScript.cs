using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonScript : MonoBehaviour {
    public float movement = 4f;
    float timer;
    float timer2;
    public GameObject fireBall;
    // Use this for initialization
    void Start () {
        timer = 0;
        timer2 = 0;
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        timer2 += Time.deltaTime;
        if (timer >= 60 && movement < 7f)
        {
            movement += 0.5f;
        }
        transform.Translate(movement * Time.deltaTime, 0, 0);

        if (timer2 > 8.2f)
        {
            Instantiate(fireBall, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            timer2 = 0;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
            Application.LoadLevel("StartMenu");
        }
    }
}
