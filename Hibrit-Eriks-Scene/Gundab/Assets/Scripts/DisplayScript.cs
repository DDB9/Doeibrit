using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class DisplayScript : MonoBehaviour {

    public static DisplayScript instance = null;

    public static int pose;         // This ingeter resembles the current pose. 

    public GameObject checkMark;
    public Transform cubeman;       // Transform of the Cubeman rig.

    // Pose Colliders
    public GameObject RHCollider;
    public GameObject LHCollider;
    public GameObject RKCollider;
    public GameObject LKCollider;

    // Pose Collider Booleans
    public static bool leftArmInPlace = false;
    public static bool rightArmInPlace = false;
    public static bool leftLegInPlace = false;
    public static bool rightLegInPlace = false;

    private bool nextPose = false;

    //UI In Place Indicator
    public GameObject lArmLight;
    public GameObject rArmLight;
    public GameObject lLegLight;
    public GameObject rLegLight;

    private Color green = new Color(0, 255, 0);
    private Color red = new Color(255, 0, 0);

    // Use this for initialization
    void Start ()
    {
        Debug.Log("displays connected: " + Display.displays.Length);
        // Display.displays[0] is the primary, default display and is always ON.
        // Check if additional displays are available and activate each.
        if (Display.displays.Length > 1)
            Display.displays[1].Activate();
        if (Display.displays.Length >= 2)
            Display.displays[2].Activate();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (leftArmInPlace)
        {
            lArmLight.GetComponent<Image>().color = green;
        }

        if (!leftArmInPlace)
        {
            lArmLight.GetComponent<Image>().color = red;
        }

        if (rightArmInPlace)
        {
            rArmLight.GetComponent<Image>().color = green;
        }

        if (!rightArmInPlace)
        {
            rArmLight.GetComponent<Image>().color = red;
        }

        if (leftLegInPlace)
        {
            lLegLight.GetComponent<Image>().color = green;
        }

        if (!leftLegInPlace)
        {
            lLegLight.GetComponent<Image>().color = red;
        }

        if (rightLegInPlace)
        {
            rLegLight.GetComponent<Image>().color = green;
        }

        if (!rightLegInPlace)
        {
            rLegLight.GetComponent<Image>().color = red;
        }
       

        switch (pose)
        {

            case 1:  // EZ_CHEER
                RHCollider.transform.position = new Vector3(1.41f, 3.05f, 0f);
                LHCollider.transform.position = new Vector3(-2.14f, 3.05f, 0f);
                RKCollider.transform.position = new Vector3(0.5f, -0.2f, 0f);
                LKCollider.transform.position = new Vector3(-0.5f, -0.2f, 0f);
                break;

                //Activate colliders here.

            case 2: // EZ_DAB
                RHCollider.transform.position = new Vector3(0f, 2.16f, 0f);
                LHCollider.transform.position = new Vector3(-1.46f, 3.62f, 0f);
                RKCollider.transform.position = new Vector3(0.63f, 0f, 0f);
                LKCollider.transform.position = new Vector3(-0.63f, 0f, 0f);
                break;

                // Activate colliders here.

            case 3: // EZ_BOXING
                RHCollider.transform.position = new Vector3(0.76f, 2.19f, 0f);
                LHCollider.transform.position = new Vector3(0f, 2.372f, 0f);
                RKCollider.transform.position = new Vector3(0.654f, 0f, 0f);
                LKCollider.transform.position = new Vector3(-0.654f, 0f, 0f);
                break;

                // Activate colliders here.

            case 4: // EZ_FLEX
                RHCollider.transform.position = new Vector3(-2.6f, 6.87f, 0f);
                LHCollider.transform.position = new Vector3(-2.6f, 8.24f, 0f);
                RKCollider.transform.position = new Vector3(2.04f, 0f, 0f);
                LKCollider.transform.position = new Vector3(-1.17f, 0f, 0f);
                break;

                // Activate colliders here.

            case 5: // MED_WAITER
                RHCollider.transform.position = new Vector3(0.237f, 1.508f, 0f);
                LHCollider.transform.position = new Vector3(-0.27f, 1.322f, 0f);
                RKCollider.transform.position = new Vector3(0.54f, 0f, 0f);
                LKCollider.transform.position = new Vector3(-0.54f, 0, 0f);
               break;

            // Activate colliders here.

            case 6: // MED_SUMO
                RHCollider.transform.position = new Vector3(2.668f, 1.988f, 0f);
                LHCollider.transform.position = new Vector3(-1.65f, 1.94f, 0f);
                RKCollider.transform.position = new Vector3(1.27f, 0f, 0f);
                LKCollider.transform.position = new Vector3(0f, 0f, 0f);
                break;

                // Activate colliders here.

            case 7: // MED_ATTACK
                RHCollider.transform.position = new Vector3(0.76f, 3.23f, 0f);
                LHCollider.transform.position = new Vector3(0.15f, 3.08f, 0f);
                RKCollider.transform.position = new Vector3(0.79f, 0f, 0f);
                LKCollider.transform.position = new Vector3(-0.09f, 0f, 0f);
                break;

                // Activate colliders here.

            case 8: // MED_DOWNFLEX
                RHCollider.transform.position = new Vector3(0f, 0.9f, 0f);
                LHCollider.transform.position = new Vector3(0f, 0.9f, 0f);
                RKCollider.transform.position = new Vector3(0.287f, 0f, 0f);
                LKCollider.transform.position = new Vector3(-0.287f, 0f, 0f);
                break;

                // Activate colliders here.

            case 9: // MED_KAMEHAMEHA
                RHCollider.transform.position = new Vector3(1.468f, 2.286f, 0f);
                LHCollider.transform.position = new Vector3(0.86f, 1.991f, 0f);
                RKCollider.transform.position = new Vector3(0.457f, 0.1f, 0f);
                LKCollider.transform.position = new Vector3(-0.617f, -0.1f, 0f);
                break;

                // Activate colliders here.

            case 10: // HARD_DOWNDAB
                RHCollider.transform.position = new Vector3(0.669f, 2.873f, 0f);
                LHCollider.transform.position = new Vector3(-1.335f, 0.832f, 0f);
                RKCollider.transform.position = new Vector3(0.371f, 0.053f, 0f);
                LKCollider.transform.position = new Vector3(-0.21f, 0.053f, 0f);
                break;

                // Activate colliders here.

            case 14: // HARD_Pose1 (Mart)
                RHCollider.transform.position = new Vector3(1.5f, 9.73f, 0f);
                RHCollider.transform.localScale = new Vector3(6, 6, 6);

                LHCollider.transform.position = new Vector3(-5.88f, 5.78f, 0f);
                LHCollider.transform.localScale = new Vector3(6, 6, 6);

                RKCollider.transform.position = new Vector3(1.15f, -0.62f, 0f);
                RKCollider.transform.localScale = new Vector3(6, 6, 6);

                LKCollider.transform.position = new Vector3(-1.35f, -0.24f, 0f);
                LKCollider.transform.localScale = new Vector3(6, 6, 6);
                break;
        }
        if (leftArmInPlace == true && rightArmInPlace == true &&
            leftLegInPlace == true && rightLegInPlace == true)
        {
            Debug.Log("Pose correctly executed!");
            checkMark.GetComponent<Image>().enabled = true;

            RHCollider.SetActive(false);
            LHCollider.SetActive(false); 
            RKCollider.SetActive(false); 
            LKCollider.SetActive(false);

            StartCoroutine("RemoveAfterDelay");
        }
    }

    IEnumerator RemoveAfterDelay()
    {
        yield return new WaitForSeconds(1f);
        checkMark.GetComponent<Image>().enabled = false;
        leftArmInPlace = false;
        rightArmInPlace = false;
        leftLegInPlace = false;
        rightLegInPlace = false;
    }
}
