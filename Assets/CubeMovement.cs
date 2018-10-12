using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour {
    int movePlace;
    bool isMovingUp;
    private void Start()
    {
        movePlace = Random.Range(-30, 30);
    }

    // Update is called once per frame
    void Update () {
        if (movePlace >= 30)
        {
            isMovingUp = !isMovingUp;
        }
        else if (movePlace <= -30)
        {
            isMovingUp = !isMovingUp;
        }



        if (isMovingUp)
        {
            movePlace++;
            transform.Translate(0, 15 * Time.deltaTime,0);
        }
        else
        {
            movePlace--;
            transform.Translate(0, -15 * Time.deltaTime, 0);
        }
        
	}
}
