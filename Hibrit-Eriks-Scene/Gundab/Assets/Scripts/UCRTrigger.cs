using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UCRTrigger: MonoBehaviour {

    private void Update()
    {
        DisplayScript.leftArmInPlace = false;
        DisplayScript.rightArmInPlace = false;
        DisplayScript.leftLegInPlace = false;
        DisplayScript.rightLegInPlace = false;
    }

    void OnTriggerStay(Collider other)
    {
        if (this.name == "LeftHandCollider")
        {
            if (other.name == "11_Hand_Right")
            {
                Debug.Log("Left hand in place!");
                DisplayScript.leftArmInPlace = true;
                Debug.Log(DisplayScript.leftArmInPlace);
            }
        }
        if (this.name == "RightHandCollider")
        {
            if (other.name == "07_Hand_Left")
            {
                Debug.Log("Right hand in place!");
                DisplayScript.rightArmInPlace = true;
                Debug.Log(DisplayScript.rightArmInPlace);
            }
        }
        if (this.name == "LeftKneeCollider")
        {
            if (other.name == "17_Knee_Right")
            {
                Debug.Log("Left foot in place!");
                DisplayScript.leftLegInPlace = true;
                Debug.Log(DisplayScript.leftLegInPlace);
            }
        }
        if (this.name == "RightKneeCollider")
        {
            if (other.name == "13_Knee_Left")
            {
                Debug.Log("Right foot in place!");
                DisplayScript.rightLegInPlace = true;
                Debug.Log(DisplayScript.rightLegInPlace);
            }
        }
    }
}
