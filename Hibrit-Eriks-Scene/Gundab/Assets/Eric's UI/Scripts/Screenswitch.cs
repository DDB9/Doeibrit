using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Screenswitch : MonoBehaviour {

    Animator animator;
    public bool explain;

    //difficulty = 0 = none chosen yet
    //difficulty = 1 = easy
    //difficulty = 2 = mid
    //difficulty = 3 = hard
    public static int difficulty = 0;

    public ButtonScript buttonScript;
    public Text hackWindow;


    //the following is used for the pose randomizer/pose cycles
    public Animator easyAnim;
    public Animator midAnim;
    public Animator hardAnim;

    int easyPoseNum;
    int midPoseNum;
    int hardPoseNum;
    int easyNumber;
    int midNumber;
    int hardNumber;

    //because I'm not too experienced with C# code, the following is going to be VERY dirty, so Daan or Timen, if you are bothered by it,  please feel free to clean it up.
    //well, here goes:
    public Animator explainEasyPixelFade;
    public Animator explainEasyWireframe;
    public Animator explainMidPixelFade;
    public Animator explainMidWireframe;
    public Animator explainHardPixelFade;
    public Animator explainHardWireframe;

    //in inspector set this int to the amount of poses for each difficulty
    public int maxPosesEasy;
    public int maxPosesMid;
    public int maxPosesHard;




    void Start () {
        animator = this.GetComponent<Animator>();
        easyNumber = easyAnim.GetInteger("randomnumber") + 1;
        midNumber = midAnim.GetInteger("randomnumber") + 1;
        hardNumber = hardAnim.GetInteger("randomnumber") + 1;
    }


    public void EasyExplain()
    {
        animator.SetBool("Explain", true);
        ScoreScript.points += buttonScript.pointReceivedEasy;
        difficulty = 1;
        explainEasyPixelFade.SetInteger("randomnumber", easyAnim.GetInteger("randomnumber"));
        explainEasyWireframe.SetInteger("randomnumber", easyAnim.GetInteger("randomnumber"));

        if (easyAnim.GetInteger("randomnumber") == 1) DisplayScript.pose = 1;
        if (easyAnim.GetInteger("randomnumber") == 2) DisplayScript.pose = 2;
        if (easyAnim.GetInteger("randomnumber") == 3) DisplayScript.pose = 3;
        if (easyAnim.GetInteger("randomnumber") == 4) DisplayScript.pose = 4;
    }

    public void MidExplain()
    {
        animator.SetBool("Explain", true);
        ScoreScript.points += buttonScript.pointReceivedMid;
        difficulty = 2;
        explainMidPixelFade.SetInteger("randomnumber", midAnim.GetInteger("randomnumber"));
        explainMidWireframe.SetInteger("randomnumber", midAnim.GetInteger("randomnumber"));

        if (midAnim.GetInteger("randomnumber") == 1) DisplayScript.pose = 5;
        if (midAnim.GetInteger("randomnumber") == 2) DisplayScript.pose = 6;
        if (midAnim.GetInteger("randomnumber") == 3) DisplayScript.pose = 7;
        if (midAnim.GetInteger("randomnumber") == 4) DisplayScript.pose = 8;
        if (midAnim.GetInteger("randomnumber") == 5) DisplayScript.pose = 9;
    }

    public void HardExplain()
    {
        animator.SetBool("Explain", true);
        ScoreScript.points += buttonScript.pointReceivedHard;
        difficulty = 3;
        explainHardPixelFade.SetInteger("randomnumber", hardAnim.GetInteger("randomnumber"));
        explainHardWireframe.SetInteger("randomnumber", hardAnim.GetInteger("randomnumber"));

        if (hardAnim.GetInteger("randomnumber") == 1) DisplayScript.pose = 10;
        if (hardAnim.GetInteger("randomnumber") == 2) DisplayScript.pose = 11;
        if (hardAnim.GetInteger("randomnumber") == 3) DisplayScript.pose = 12;
        if (hardAnim.GetInteger("randomnumber") == 4) DisplayScript.pose = 13;
    }

    public void Choose() {
        animator.SetBool("Explain", false);

        if(difficulty == 1)
        {
            easyAnim.SetInteger("randomnumber", easyNumber);
            

            easyNumber += 1;
            if (easyNumber > maxPosesEasy)
            {
                easyNumber = 1;
            }
        }

        if(difficulty == 2)
        {
            midAnim.SetInteger("randomnumber", midNumber);
            
            midNumber += 1;
            if (midNumber > maxPosesMid)
            {
                midNumber = 1;
            }
        }

        if(difficulty == 3)
        {
            hardAnim.SetInteger("randomnumber", hardNumber);
            
            hardNumber += 1;
            if (hardNumber > maxPosesHard)
            {
                hardNumber = 1;
            }
        }

        difficulty = 0;
        hackWindow.text = "";
    }

    private void Update()
    {
        
        if (Input.GetKeyDown("joystick button 3") || Input.GetKeyDown("joystick button 2") || Input.GetKeyDown("joystick button 1") || Input.GetKeyDown("c"))
        {
            Choose();

        }

    }
}

    
    

	

