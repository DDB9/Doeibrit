using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class JammerController : MonoBehaviour {

    public GameObject hackerImage;
    //public GameObject feedbackImg;


    public static bool beingHacked = false;
    public static bool hackerSend = false;

    bool gotHacked = false;

    public Text hackWindow;

    public Camera UICamera;

    //these are my awesome Camera Shake variables
    public float intensity;
    public int shakes;
    public float speed;


    //these are also for the shaking of the camera, but during the hacking
    public float intensity_hack;
    public int shakes_hack;
    public float speed_hack;



    //public GameObject feedbackImg_Enemy;


    private void Start()
    {
        hackWindow.text = ""; 
    }

    // Update is called once per frame
    void Update()

    {

        if (Input.GetKeyDown("p") && !beingHacked || Input.GetKeyDown("joystick button 4") && !beingHacked)
        {
            hackerImage.SetActive(true);
            TimerScript.startTime = Time.time;
            beingHacked = true;
            UICamera.GetComponent<CameraControl>().Shake(intensity_hack, shakes_hack, speed_hack);

        }

        //if (Input.GetKeyDown("c") || Input.GetKeyDown("joystick button 3"))
        //{
        //    DamageTaken();
            
       // }

        

        if (hackerSend)
        {
            //feedbackImg.transform.position = Vector3.Lerp(feedbackImg.transform.position, new Vector3(28f, 716f, -660f), 9f * Time.deltaTime);
            

        }

        else
        {
            //feedbackImg.transform.position = Vector3.Lerp(feedbackImg.transform.position, new Vector3(-165.52f, 716f, -660f), 9f * Time.deltaTime);
        }

         if (Input.GetKeyDown("r") && ButtonClicked.ready)
        {
            gotHacked = true;
        }

        if (gotHacked)
        {
            //feedbackImg_Enemy.transform.position = Vector3.Lerp(feedbackImg_Enemy.transform.position, new Vector3(146f, -5f, -10f), 9f * Time.deltaTime);
            StartCoroutine("Yeet");

        }

        else
        {
            //feedbackImg_Enemy.transform.position = Vector3.Lerp(feedbackImg_Enemy.transform.position, new Vector3(344f, -5f, -10f), 17f * Time.deltaTime);
            
        }


    }

    public void HackScreen()
    {
        if(ScoreScript.points >= 40)
        {
            ScoreScript.points -= 40;
            hackerSend = true;
            StartCoroutine("Skrt");
            hackWindow.text += "\n" + DateTime.Now.ToString("HH:mm") + " - " + "HACK CONFIRMED: SCREEN HACK";
        }

    }

    public void HackPose()
    {
        if(ScoreScript.points >= 60)
        {
            ScoreScript.points -= 60;
            hackerSend = true;
            StartCoroutine("Skrt");
            hackWindow.text += "\n" + DateTime.Now.ToString("HH:mm") + " - " + "HACK CONFIRMED: POSE HACK";
        }
        

    }


    //This is the delay coroutine
    //I should stop using meme names for my code...
    IEnumerator Skrt()
    {
        yield return new WaitForSeconds(3.3f);
        hackerSend = false;
    }
    IEnumerator Yeet()
    {
        yield return new WaitForSeconds(4f);
        gotHacked = false;
    }

    public void DamageTaken()
    {
        Debug.Log("SCREEN SHAKE");
        UICamera.GetComponent<CameraControl>().Shake(intensity, shakes, speed);
        
    }

}
