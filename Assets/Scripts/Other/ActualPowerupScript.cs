using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActualPowerupScript : MonoBehaviour {
    PlayerMovement scriptReference;
    Transform myT;
    bool turn = true;
    int turnInt = 0;
    string playerS = "Player";
	// Use this for initialization
	void Start () {
        myT = GetComponent<Transform>();
        scriptReference = GameObject.Find(playerS).GetComponent<PlayerMovement>();
	}

    private void Update()
    {
        if (turn)
        {
            turnInt++;
            myT.Translate(0, 2 * Time.deltaTime, 0);
            if (turnInt == 20)
            {
                turn = !turn;
            }
        }
        else
        {
            turnInt--;
            myT.Translate(0, -2 * Time.deltaTime, 0);
            if (turnInt == -20)
            {
                turn = !turn;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == playerS)
        {
            scriptReference.powerUpActive = true;
            Destroy(this.gameObject);
        }
    }

}
