using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {
    public Slider jumpSlider;
    float jumpTimer;
    PlayerMovement scriptReference;
    Transform playerT;
    public Text distanceText;
    public Text highScoreText;
    float highScoreCount;
	// Use this for initialization
	void Start () {
        jumpSlider.value = 1;
        scriptReference = GameObject.Find("Player").GetComponent<PlayerMovement>();
        playerT = GameObject.Find("Player").GetComponent<Transform>();

        if (PlayerPrefs.HasKey("HighScoreDistance"))
        {
            highScoreCount = PlayerPrefs.GetFloat("HighScoreDistance");
        }
        highScoreText.text = "Furthest Distance: " + highScoreCount + " Miles";
    }
	
	// Update is called once per frame
	void Update () {
        if (jumpTimer <= 1)
        {
            jumpSlider.value = scriptReference.jumpTimer - 0.5f;
        }
        float distance = playerT.position.x / 40;
        string distanceRoundString = distance.ToString("n3");
        distanceText.text = "Distance: " + distanceRoundString + " miles";
        if (distance> highScoreCount)
        {
            highScoreCount = distance;
            PlayerPrefs.SetFloat("HighScoreDistance", highScoreCount);
            highScoreText.text = "Furthest Distance: " + distanceRoundString + " Miles";
        }
    }
}
