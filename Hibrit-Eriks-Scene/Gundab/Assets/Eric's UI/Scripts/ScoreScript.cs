using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

    public static int points;
    public Text powerText;

	// Use this for initialization
	void Start () {
        points = 0;

	}
	
	// Update is called once per frame
	void Update () {
        powerText.text = "Ultimate Power Points: " + points.ToString();


    }




}
