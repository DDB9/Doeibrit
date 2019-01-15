using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour{

    public Text timerText;
    public float timer = 5.0f;
    public static float startTime;
    string seconds;
    float t;

    public GameObject hackerImage;



	void Start ()
    {
        startTime = Time.time;

	}
	


	void Update ()
    {
        t = startTime - Time.time + timer;

        
        seconds = (t % 60).ToString("f2");

        timerText.text = seconds;
       
        

        if((t%60) <= 0.0f)
        {
            hackerImage.SetActive(false);
            JammerController.beingHacked = false;
        }

	}
}
