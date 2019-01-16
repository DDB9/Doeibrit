using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClicked : MonoBehaviour {

    public static GameObject easyPose;
    public static GameObject midPose;
    public static GameObject hardPose;

    public static bool easyClicked;
    public static bool midClicked;
    public static bool hardClicked;

    public static bool ready = false;
    

    private void Awake()
    {
        easyPose = GameObject.Find("EasyPoseRandomizer");
        midPose = GameObject.Find("MidPoseRandomizer");
        hardPose = GameObject.Find("HardPoseRandomizer");


        easyClicked = false;
        midClicked = false;
        hardClicked = false;
    }

    public void Update()
    {
        if (easyClicked)
        {

            easyPose.transform.position = Vector2.Lerp(easyPose.transform.position, new Vector2(0, 0), 2f * Time.deltaTime);
            StartCoroutine("Delay");
            ready = true;
        }

        if (midClicked)
        { 
            StartCoroutine("Delay");
            ready = true;
        }

        if (hardClicked)
        {
            hardPose.transform.position = Vector2.Lerp(hardPose.transform.position, new Vector2(0, 0), 2f * Time.deltaTime);
            StartCoroutine("Delay");
            ready = true;
        }
    }

    IEnumerator Delay()
    {
        
        yield return new WaitForSeconds(1.3f);
        easyClicked = false;
        midClicked = false;
        hardClicked = false;
        
    }

}
