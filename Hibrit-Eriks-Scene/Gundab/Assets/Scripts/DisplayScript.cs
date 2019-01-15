using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class DisplayScript : MonoBehaviour {

    public static DisplayScript instance = null;

    public static int pose = 1;         // This ingeter resembles the current pose. 

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
                // Position the colliders.
                RHCollider.transform.position = new Vector3(cubeman.position.x + 1.41f, 3.05f, cubeman.position.z);
                LHCollider.transform.position = new Vector3(cubeman.position.x + -2.14f, 3.05f, cubeman.position.z);
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
                LHCollider.transform.position = new Vector3(cubeman.position.x + -1.46f, 3.62f, cubeman.position.z);
                RKCollider.transform.position = new Vector3(cubeman.position.x + 0.63f, 0f, cubeman.position.z);
                LKCollider.transform.position = new Vector3(cubeman.position.x + -0.63f, 0f, cubeman.position.z);

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
                RKCollider.transform.position = new Vector3(cubeman.position.x + 0.654f, 0f, cubeman.position.z);
                LKCollider.transform.position = new Vector3(cubeman.position.x + -0.654f, 0f, cubeman.position.z);

                // Activate the colliders.
                RHCollider.SetActive(true);
                LHCollider.SetActive(true);
                RKCollider.SetActive(true);
                LKCollider.SetActive(true);

                break;

            case 4: // EZ_FLEX
                // Position the colliders.
                RHCollider.transform.position = new Vector3(cubeman.position.x + -2.6f, 6.87f, cubeman.position.z);
                LHCollider.transform.position = new Vector3(cubeman.position.x + -2.6f, 8.24f, cubeman.position.z);
                RKCollider.transform.position = new Vector3(cubeman.position.x + 2.04f, 0f, cubeman.position.z);
                LKCollider.transform.position = new Vector3(cubeman.position.x + -1.17f, 0f, cubeman.position.z);

                // Activate the colliders.
                RHCollider.SetActive(true);
                LHCollider.SetActive(true);
                RKCollider.SetActive(true);
                LKCollider.SetActive(true);

                break;

            case 5: // MED_WAITER
                // Position the colliders.
                RHCollider.transform.position = new Vector3(cubeman.position.x + 0.237f, 1.508f, cubeman.position.z);
                LHCollider.transform.position = new Vector3(cubeman.position.x + -0.27f, 1.322f, cubeman.position.z);
                RKCollider.transform.position = new Vector3(cubeman.position.x + 0.54f, 0f, cubeman.position.z);
                LKCollider.transform.position = new Vector3(cubeman.position.x + -0.54f, 0, cubeman.position.z);

                // Activate the colliders.
                RHCollider.SetActive(true);
                LHCollider.SetActive(true);
                RKCollider.SetActive(true);
                LKCollider.SetActive(true);

                break;

            case 6: // MED_SUMO
                // Position the colliders.
                RHCollider.transform.position = new Vector3(cubeman.position.x + 2.668f, 1.988f, cubeman.position.z);
                LHCollider.transform.position = new Vector3(cubeman.position.x + -1.65f, 1.94f, cubeman.position.z);
                RKCollider.transform.position = new Vector3(cubeman.position.x + 1.27f, 0f, cubeman.position.z);
                LKCollider.transform.position = new Vector3(cubeman.position.x, 0f, cubeman.position.z);

                // Activate the colliders.
                RHCollider.SetActive(true);
                LHCollider.SetActive(true);
                RKCollider.SetActive(true);
                LKCollider.SetActive(true);

                break;

            case 7: // MED_ATTACK
                // Position the colliders.
                RHCollider.transform.position = new Vector3(cubeman.position.x + 0.76f, 3.23f, cubeman.position.z);
                LHCollider.transform.position = new Vector3(cubeman.position.x + 0.15f, 3.08f, cubeman.position.z);
                RKCollider.transform.position = new Vector3(cubeman.position.x + 0.79f, 0f, cubeman.position.z);
                LKCollider.transform.position = new Vector3(cubeman.position.x + -0.09f, 0f, cubeman.position.z);

                // Activate the colliders.
                RHCollider.SetActive(true);
                LHCollider.SetActive(true);
                RKCollider.SetActive(true);
                LKCollider.SetActive(true);

                break;

            case 8: // MED_DOWNFLEX
                // Position the colliders.
                RHCollider.transform.position = new Vector3(cubeman.position.x + 0f, 0.9f, cubeman.position.z);
                LHCollider.transform.position = new Vector3(cubeman.position.x + 0f, 0.9f, cubeman.position.z);
                RKCollider.transform.position = new Vector3(cubeman.position.x + 0.287f, 0f, cubeman.position.z);
                LKCollider.transform.position = new Vector3(cubeman.position.x + -0.287f, 0f, cubeman.position.z);

                // Activate the colliders.
                RHCollider.SetActive(true);
                LHCollider.SetActive(true);
                RKCollider.SetActive(true);
                LKCollider.SetActive(true);

                break;

            case 9: // MED_KAMEHAMEHA
                // Position the colliders.
                RHCollider.transform.position = new Vector3(cubeman.position.x + 1.468f, 2.286f, cubeman.position.z);
                LHCollider.transform.position = new Vector3(cubeman.position.x + 0.86f, 1.991f, cubeman.position.z);
                RKCollider.transform.position = new Vector3(cubeman.position.x + 0.457f, 0.1f, cubeman.position.z);
                LKCollider.transform.position = new Vector3(cubeman.position.x + -0.617f, -0.1f, cubeman.position.z);

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
                RHCollider.transform.position = new Vector3(cubeman.position.x + 1.819f, 2.369f, cubeman.position.z);
                LHCollider.transform.position = new Vector3(cubeman.position.x + -0.587f, 0.567f, cubeman.position.z);
                RKCollider.transform.position = new Vector3(cubeman.position.x + 0.74f, -0.09f, cubeman.position.z);
                LKCollider.transform.position = new Vector3(cubeman.position.x + 0.298f, 0.2094f, cubeman.position.z  + -0.02f);
                LKCollider.transform.localScale = new Vector3(1f, 1f, 0.5f);

                // Activate the colliders.
                RHCollider.SetActive(true);
                LHCollider.SetActive(true);
                RKCollider.SetActive(true);
                LKCollider.SetActive(true);

                break;

            case 12: // HARD_ONELEGWAVE
                // Position the colliders.
                RHCollider.transform.position = new Vector3(cubeman.position.x + 2.108f, 2.244f, cubeman.position.z);
                LHCollider.transform.position = new Vector3(cubeman.position.x + -0.645f, 1.09f, cubeman.position.z);
                RKCollider.transform.position = new Vector3(cubeman.position.x + 0.804f, 0.151f, cubeman.position.z);
                LKCollider.transform.position = new Vector3(cubeman.position.x + 0.282f, 0.528f, cubeman.position.z + -1f);
                LKCollider.transform.localScale = new Vector3(1f, 1f, 0.5f);

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
