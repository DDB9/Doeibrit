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
        if (Display.displays.Length > 2)
            Display.displays[2].Activate();
        if (Display.displays.Length > 3)
            Display.displays[3].Activate();
        if (Display.displays.Length >= 4)
            Display.displays[4].Activate();
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
            case 0:
                RHCollider.transform.position = new Vector3(0, 9, 0);
                LHCollider.transform.position = new Vector3(0, 9, 0);
                RKCollider.transform.position = new Vector3(0, 9, 0);
                LKCollider.transform.position = new Vector3(0, 9, 0);

                break;

            case 1:  // EZ_CHEER
                // Position the colliders.
                RHCollider.transform.position = new Vector3(cubeman.position.x + 1.41f, 3.05f, cubeman.position.z);
                LHCollider.transform.position = new Vector3(cubeman.position.x + -1.51f, 3.05f, cubeman.position.z);
                RKCollider.transform.position = new Vector3(cubeman.position.x + 0.5f, -0.2f, cubeman.position.z);
                LKCollider.transform.position = new Vector3(cubeman.position.x + -0.5f, -0.2f, cubeman.position.z);

                // Activate the colliders.
                RHCollider.SetActive(true);
                LHCollider.SetActive(true);
                RKCollider.SetActive(true);
                LKCollider.SetActive(true);

                break;

            case 2: // EZ_DAB
                // Position the colliders.
                RHCollider.transform.position = new Vector3(cubeman.position.x, 2.16f, cubeman.position.z);
                LHCollider.transform.position = new Vector3(cubeman.position.x + -1.41f, 3f, cubeman.position.z);
                RKCollider.transform.position = new Vector3(cubeman.position.x + 0.3f, 0f, cubeman.position.z);
                LKCollider.transform.position = new Vector3(cubeman.position.x + -0.3f, 0f, cubeman.position.z);

                // Activate the colliders.
                RHCollider.SetActive(true);
                LHCollider.SetActive(true);
                RKCollider.SetActive(true);
                LKCollider.SetActive(true);

                break;

            case 3: // EZ_BOXING
                // Position the colliders.
                RHCollider.transform.position = new Vector3(cubeman.position.x + 0.76f, 2.19f, cubeman.position.z);
                LHCollider.transform.position = new Vector3(cubeman.position.x, 2.372f, cubeman.position.z);
                RKCollider.transform.position = new Vector3(cubeman.position.x + 0.3f, 0f, cubeman.position.z);
                LKCollider.transform.position = new Vector3(cubeman.position.x + -0.3f, 0f, cubeman.position.z);

                // Activate the colliders.
                RHCollider.SetActive(true);
                LHCollider.SetActive(true);
                RKCollider.SetActive(true);
                LKCollider.SetActive(true);

                break;

            case 4: // EZ_FLEX
                // Position the colliders.
                RHCollider.transform.position = new Vector3(cubeman.position.x + -1.302f, 2.683f, cubeman.position.z);
                LHCollider.transform.position = new Vector3(cubeman.position.x + -1.153f, 2.56f, cubeman.position.z);
                RKCollider.transform.position = new Vector3(cubeman.position.x + 0.3f, 0f, cubeman.position.z);
                LKCollider.transform.position = new Vector3(cubeman.position.x + -0.3f, 0f, cubeman.position.z);

                // Activate the colliders.
                RHCollider.SetActive(true);
                LHCollider.SetActive(true);
                RKCollider.SetActive(true);
                LKCollider.SetActive(true);

                break;

            case 5: // MED_WAITER
                // Position the colliders.
                RHCollider.transform.position = new Vector3(cubeman.position.x + 0.891f, 1.127f, cubeman.position.z);
                LHCollider.transform.position = new Vector3(cubeman.position.x + -0.107f, 1.305f, cubeman.position.z);
                RKCollider.transform.position = new Vector3(cubeman.position.x + 0.3f, 0f, cubeman.position.z);
                LKCollider.transform.position = new Vector3(cubeman.position.x + -0.3f, 0, cubeman.position.z);

                // Activate the colliders.
                RHCollider.SetActive(true);
                LHCollider.SetActive(true);
                RKCollider.SetActive(true);
                LKCollider.SetActive(true);

                break;

            case 6: // MED_SUMO
                // Position the colliders.
                RHCollider.transform.position = new Vector3(cubeman.position.x + 2.586f, 1.7f, cubeman.position.z);
                LHCollider.transform.position = new Vector3(cubeman.position.x + -2.052f, 1.7f, cubeman.position.z);
                RKCollider.transform.position = new Vector3(cubeman.position.x + 0.3f, 0f, cubeman.position.z);
                LKCollider.transform.position = new Vector3(cubeman.position.x + -0.03f, 0f, cubeman.position.z);

                // Activate the colliders.
                RHCollider.SetActive(true);
                LHCollider.SetActive(true);
                RKCollider.SetActive(true);
                LKCollider.SetActive(true);

                break;

            case 7: // MED_ATTACK
                // Position the colliders.
                RHCollider.transform.position = new Vector3(cubeman.position.x + 0.201f, 2.368f, cubeman.position.z);
                LHCollider.transform.position = new Vector3(cubeman.position.x + -0.854f, 2.354f, cubeman.position.z);
                RKCollider.transform.position = new Vector3(cubeman.position.x + 0.3f, 0f, cubeman.position.z);
                LKCollider.transform.position = new Vector3(cubeman.position.x + -0.3f, 0f, cubeman.position.z);

                // Activate the colliders.
                RHCollider.SetActive(true);
                LHCollider.SetActive(true);
                RKCollider.SetActive(true);
                LKCollider.SetActive(true);

                break;

            case 8: // MED_DOWNFLEX
                // Position the colliders.
                RHCollider.transform.position = new Vector3(cubeman.position.x + 0.651f, 0.144f, cubeman.position.z);
                LHCollider.transform.position = new Vector3(cubeman.position.x + -0.651f, 0.144f, cubeman.position.z);
                RKCollider.transform.position = new Vector3(cubeman.position.x + 0.55f, 0f, cubeman.position.z);
                LKCollider.transform.position = new Vector3(cubeman.position.x + -0.55f, 0f, cubeman.position.z);

                // Activate the colliders.
                RHCollider.SetActive(true);
                LHCollider.SetActive(true);
                RKCollider.SetActive(true);
                LKCollider.SetActive(true);

                break;

            case 9: // MED_KAMEHAMEHA
                // Position the colliders.
                RHCollider.transform.position = new Vector3(cubeman.position.x + 1.465f, 1.009f, cubeman.position.z);
                LHCollider.transform.position = new Vector3(cubeman.position.x + 1.489f, 1.481f, cubeman.position.z);
                RKCollider.transform.position = new Vector3(cubeman.position.x + 0.5f, -0.231f, cubeman.position.z);
                LKCollider.transform.position = new Vector3(cubeman.position.x + -0.5f, -0.231f, cubeman.position.z);

                // Resize the colliders.
                LHCollider.transform.localScale = new Vector3(2, 2, 3);
                RHCollider.transform.localScale = new Vector3(2, 2, 3);
                RKCollider.transform.localScale = new Vector3(1, 2, 2);
                LKCollider.transform.localScale = new Vector3(1, 2, 2);

                // Activate the colliders.
                RHCollider.SetActive(true);
                LHCollider.SetActive(true);
                RKCollider.SetActive(true);
                LKCollider.SetActive(true);

                break;

            case 10: // HARD_DOWNDAB
                // Position the colliders.
                RHCollider.transform.position = new Vector3(cubeman.position.x + 0.669f, 2.873f, cubeman.position.z);
                LHCollider.transform.position = new Vector3(cubeman.position.x + -1.335f, 0.832f, cubeman.position.z);
                RKCollider.transform.position = new Vector3(cubeman.position.x + 0.371f, 0.053f, cubeman.position.z);
                LKCollider.transform.position = new Vector3(cubeman.position.x + -0.21f, 0.053f, cubeman.position.z);

                // Activate the colliders.
                RHCollider.SetActive(true);
                LHCollider.SetActive(true);
                RKCollider.SetActive(true);
                LKCollider.SetActive(true);

                break;

            case 11: // HARD_ONELEGTPOSE
                // Position the colliders.
                RHCollider.transform.position = new Vector3(cubeman.position.x + 2.132f, 1.692f, cubeman.position.z + -0.749f);
                LHCollider.transform.position = new Vector3(cubeman.position.x + -2.133f, 1.861f, cubeman.position.z);
                RKCollider.transform.position = new Vector3(cubeman.position.x + 0.2f, -0.231f, cubeman.position.z);
                LKCollider.transform.position = new Vector3(cubeman.position.x + -0.5f, 0.119f, cubeman.position.z  + -0.536f);

                // Activate the colliders.
                RHCollider.SetActive(true);
                LHCollider.SetActive(true);
                RKCollider.SetActive(true);
                LKCollider.SetActive(true);

                break;

            case 12: // HARD_ONELEGWAVE
                // Position the colliders.
                RHCollider.transform.position = new Vector3(cubeman.position.x + 1.116f, 2.524f, cubeman.position.z);
                LHCollider.transform.position = new Vector3(cubeman.position.x + -1.005f, 0.591f, cubeman.position.z);
                RKCollider.transform.position = new Vector3(cubeman.position.x + 0.33f, 0f, cubeman.position.z);
                LKCollider.transform.position = new Vector3(cubeman.position.x + -0.33f, 0.141f, cubeman.position.z + -0.475f);

                // Activate the colliders.
                RHCollider.SetActive(true);
                LHCollider.SetActive(true);
                RKCollider.SetActive(true);
                LKCollider.SetActive(true);

                break;
        }
        if (leftArmInPlace == true && rightArmInPlace == true &&
            leftLegInPlace == true && rightLegInPlace == true)
        {
            StartCoroutine("ResetAfterDelay");

            checkMark.SetActive(true);
            
            StartCoroutine("RemoveAfterDelay");
        }
    }

    IEnumerator RemoveAfterDelay()
    {
        yield return new WaitForSeconds(1f);
        checkMark.SetActive(false);
        leftArmInPlace = false;
        rightArmInPlace = false;
        leftLegInPlace = false;
        rightLegInPlace = false;
    }

    IEnumerator ResetAfterDelay()
    {
        yield return new WaitForSeconds(1f);

        if (leftArmInPlace == true && rightArmInPlace == true &&
            leftLegInPlace == true && rightLegInPlace == true)
        {
            Debug.Log("Pose correctly executed!");

            RHCollider.SetActive(false);
            LHCollider.SetActive(false);
            RKCollider.SetActive(false);
            LKCollider.SetActive(false);

            pose = 0;
        }
    }
}
