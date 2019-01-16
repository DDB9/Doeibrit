using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoseRandomizer : MonoBehaviour {

  
    public Sprite[] posesKnight;
    public Sprite[] posesJavolta;

    //this is an array of arrays of Sprites for all characters
    public Sprite[][] characterPoses;


    public SpriteRenderer spriteRen;

    SpriteRenderer easyRen;
    SpriteRenderer midRen;
    SpriteRenderer hardRen;

    GameObject easyPose;
    GameObject midPose;
    GameObject hardPose;

    int poseChosen;



    public static bool moving = false;

	// Use this for initialization
	void Start () {
        characterPoses = new Sprite[2][];
        characterPoses[0] = posesKnight;
        characterPoses[1] = posesJavolta;

        spriteRen = gameObject.GetComponent<SpriteRenderer>();
        poseChosen = Random.Range(0, characterPoses[CharacterSelectionManager.charSelect].Length);

        //I need to get the sprite Renderers for all the poseRandomizers so I can disable certain renderers and keep others active

        easyPose = GameObject.Find("EasyPoseRandomizer");
        midPose = GameObject.Find("MidPoseRandomizer");
        hardPose = GameObject.Find("HardPoseRandomizer");

        easyRen = easyPose.GetComponent<SpriteRenderer>();
        midRen = midPose.GetComponent<SpriteRenderer>();
        hardRen = hardPose.GetComponent<SpriteRenderer>();




    }
	
	// Update is called once per frame
	void Update () {
        spriteRen.sprite = characterPoses[CharacterSelectionManager.charSelect][poseChosen];

        if (ButtonClicked.easyClicked)
        {
            midRen.enabled = false;
            hardRen.enabled = false;
        }

        if (ButtonClicked.midClicked)
        {
            easyRen.enabled = false;
            hardRen.enabled = false;
        }

        if (ButtonClicked.hardClicked)
        {
            easyRen.enabled = false;
            midRen.enabled = false;
        }

        //we need a way to reset this bitch
        
            if (Input.GetKeyDown("space") && !moving)
            {
                //randomize the poses 
                poseChosen = Random.Range(0, characterPoses[CharacterSelectionManager.charSelect].Length);
                

                //these buttons can be clicked again
                ButtonScript.easyButton.interactable = true;
                ButtonScript.midButton.interactable = true;
                ButtonScript.hardButton.interactable = true;

                //send the poses back to their original position
                ButtonClicked.easyPose.transform.position = new Vector2(-181, 0);
                ButtonClicked.hardPose.transform.position = new Vector2(183, 0);

                //turn on the visuals
                easyRen.enabled = true;
                midRen.enabled = true;
                hardRen.enabled = true;

                ButtonClicked.ready = false;
                
            }

        if (Input.GetKeyDown("r") && ButtonClicked.ready)
        {
            poseChosen = Random.Range(0, characterPoses[CharacterSelectionManager.charSelect].Length);
        }

    }

    
}
