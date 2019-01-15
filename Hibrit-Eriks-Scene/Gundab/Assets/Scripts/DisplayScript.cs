using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class DisplayScript : MonoBehaviour {

    public static DisplayScript instance = null;

    public static int pose = 1;         // This ingeter resembles the current pose. 

    public GameObject checkMark;

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

            case 1: // Prepares pose 1
                // Moving and scaling the pose colliders.
                RHCollider.transform.position = new Vector3(0.433f, 0.734f, 0f);
                RHCollider.transform.localScale = Vector3.one;

                LHCollider.transform.position = new Vector3(-0.395f, 1.506f, 0f);
                LHCollider.transform.localScale = Vector3.one;

                RKCollider.transform.position = new Vector3(0.25f, 0.493f, 0f);
                RKCollider.transform.localScale = Vector3.one;

                LKCollider.transform.position = new Vector3(-0.25f, 0.493f, 0f);
                LKCollider.transform.localScale = Vector3.one;

                RHCollider.SetActive(true); //
                LHCollider.SetActive(true); // Activates all
                RKCollider.SetActive(true); // colliders.
                LKCollider.SetActive(true); //

                break;

            case 2: // Prepares pose 2
                // Moving and scaling the pose colliders.
                RHCollider.transform.position = new Vector3(-0.067f, 0.657f, 0.252f);
                RHCollider.transform.localScale = new Vector3(0.5f, 0.5f, 1);

                LHCollider.transform.position = new Vector3(-0.223f, 0.598f, 0.252f);
                LHCollider.transform.localScale = new Vector3(0.5f, 0.5f, 1);

                RKCollider.transform.position = new Vector3(0.089f, 0.526f, 0.252f);
                RKCollider.transform.localScale = new Vector3(0.5f, 0.5f, 1);

                LKCollider.transform.position = new Vector3(-0.15f, 0.483f, 0.252f);
                LKCollider.transform.localScale = new Vector3(0.5f, 0.5f, 1);

                RHCollider.SetActive(true); //
                LHCollider.SetActive(true); // Activates all
                RKCollider.SetActive(true); // colliders.
                LKCollider.SetActive(true); //

                break;

            case 3:
                RHCollider.transform.position = new Vector3(0.35f, 1.236f, 0f);
                RHCollider.transform.localScale = new Vector3(0.5f, 0.5f, 1);

                LHCollider.transform.position = new Vector3(-0.35f, 1.236f, 0f);
                LHCollider.transform.localScale = new Vector3(0.5f, 0.5f, 1);

                RKCollider.transform.position = new Vector3(0.089f, 0.5f, 0f);
                RKCollider.transform.localScale = new Vector3(0.5f, 0.5f, 1);

                LKCollider.transform.position = new Vector3(-0.15f, 0.5f, 0f);
                LKCollider.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                break;

            case 4:  // Hip Wave (Joris)
                RHCollider.transform.position = new Vector3(2.7f, 0.03f, 0f);
                RHCollider.transform.localScale = new Vector3(6, 6, 6);

                LHCollider.transform.position = new Vector3(-4.14f, 7.98f, 0f);
                LHCollider.transform.localScale = new Vector3(6, 6, 6);

                RKCollider.transform.position = new Vector3(-1.43f, -2.7f, 0f);
                RKCollider.transform.localScale = new Vector3(6, 6, 6);

                LKCollider.transform.position = new Vector3(-1.03f, -2.7f, 0f);
                LKCollider.transform.localScale = new Vector3(6, 6, 6);
                break;

            case 5: // Hanging Man (Joris)
                RHCollider.transform.position = new Vector3(5.08f, 0.84f, 0f);
                RHCollider.transform.localScale = new Vector3(6, 6, 6);

                LHCollider.transform.position = new Vector3(-3.72f, 0.15f, 0f);
                LHCollider.transform.localScale = new Vector3(6, 6, 6);

                RKCollider.transform.position = new Vector3(2.41f, -1.22f, 0f);
                RKCollider.transform.localScale = new Vector3(6, 6, 6);

                LKCollider.transform.position = new Vector3(-1.93f, -1.22f, 0f);
                LKCollider.transform.localScale = new Vector3(6, 6, 6);
                break;

            case 6: // EZ_Pose1 (Mart)
                RHCollider.transform.position = new Vector3(5.49f, 10.14f, 0f);
                RHCollider.transform.localScale = new Vector3(6, 6, 6);

                LHCollider.transform.position = new Vector3(-3.27f, 9.61f, 0f);
                LHCollider.transform.localScale = new Vector3(6, 6, 6);

                RKCollider.transform.position = new Vector3(2.4f, -0.09f, 0f);
                RKCollider.transform.localScale = new Vector3(6, 6, 6);

                LKCollider.transform.position = new Vector3(-1.31f, -0.09f, 0f);
                LKCollider.transform.localScale = new Vector3(6, 6, 6);
                break;

            case 7: // EZ_Pose2 (Mart)
                RHCollider.transform.position = new Vector3(-2.6f, 6.87f, 0f);
                RHCollider.transform.localScale = new Vector3(6, 6, 6);

                LHCollider.transform.position = new Vector3(-2.6f, 8.24f, 0f);
                LHCollider.transform.localScale = new Vector3(6, 6, 6);

                RKCollider.transform.position = new Vector3(2.04f, 0f, 0f);
                RKCollider.transform.localScale = new Vector3(6, 6, 6);

                LKCollider.transform.position = new Vector3(-1.17f, 0f, 0f);
                LKCollider.transform.localScale = new Vector3(6, 6, 6);
                break;

            case 8: // EZ_Pose3 (Mart)
                RHCollider.transform.position = new Vector3(3.26f, 6.4f, 0f);
                RHCollider.transform.localScale = new Vector3(6, 6, 6);

                LHCollider.transform.position = new Vector3(-4.69f, 9.73f, 0f);
                LHCollider.transform.localScale = new Vector3(6, 6, 6);

                RKCollider.transform.position = new Vector3(2.16f, -1.21f, 0f);
                RKCollider.transform.localScale = new Vector3(6, 6, 6);

                LKCollider.transform.position = new Vector3(-0.96f, -1.21f, 0f);
                LKCollider.transform.localScale = new Vector3(6, 6, 6);
                break;

            case 9: // MED_Pose1 (Mart)
                RHCollider.transform.position = new Vector3(7.44f, 5.21f, 0f);
                RHCollider.transform.localScale = new Vector3(6, 6, 6);

                LHCollider.transform.position = new Vector3(-6.13f, 6.95f, 0f);
                LHCollider.transform.localScale = new Vector3(6, 6, 6);

                RKCollider.transform.position = new Vector3(2.69f, -1.62f, 0f);
                RKCollider.transform.localScale = new Vector3(6, 6, 6);

                LKCollider.transform.position = new Vector3(-0.58f, -1.62f, 0f);
                LKCollider.transform.localScale = new Vector3(6, 6, 6);
                break;

            case 10: // MED_Pose2 (Mart)
                RHCollider.transform.position = new Vector3(3.03f, 9.41f, 0f);
                RHCollider.transform.localScale = new Vector3(6, 6, 6);

                LHCollider.transform.position = new Vector3(3.03f, 9.41f, 0f);
                LHCollider.transform.localScale = new Vector3(6, 6, 6);

                RKCollider.transform.position = new Vector3(1.68f, -0.82f, 0f);
                RKCollider.transform.localScale = new Vector3(6, 6, 6);

                LKCollider.transform.position = new Vector3(-0.56f, -0.82f, 0f);
                LKCollider.transform.localScale = new Vector3(6, 6, 6);
                break;

            case 11: // MED_Pose3 (Mart)
                RHCollider.transform.position = new Vector3(-4.29f, 4f, 0f);
                RHCollider.transform.localScale = new Vector3(6, 6, 6);

                LHCollider.transform.position = new Vector3(-4.29f, 4f, 0f);
                LHCollider.transform.localScale = new Vector3(6, 6, 6);

                RKCollider.transform.position = new Vector3(2.26f, -0.55f, 0f);
                RKCollider.transform.localScale = new Vector3(6, 6, 6);

                LKCollider.transform.position = new Vector3(-0.84f, -0.55f, 0f);
                LKCollider.transform.localScale = new Vector3(6, 6, 6);
                break;

            case 12: // MED_Pose4 (Mart)
                RHCollider.transform.position = new Vector3(1.96f, 4.74f, 0f);
                RHCollider.transform.localScale = new Vector3(6, 6, 6);

                LHCollider.transform.position = new Vector3(1.96f, 3.49f, 0f);
                LHCollider.transform.localScale = new Vector3(6, 6, 6);

                RKCollider.transform.position = new Vector3(2.5f, -0.75f, 0f);
                RKCollider.transform.localScale = new Vector3(6, 6, 6);

                LKCollider.transform.position = new Vector3(-0.63f, -0.75f, 0f);
                LKCollider.transform.localScale = new Vector3(6, 6, 6);
                break;

            case 13: // MED_Pose3 (Mart)
                RHCollider.transform.position = new Vector3(-0.06f, 1.7f, 0f);
                RHCollider.transform.localScale = new Vector3(6, 6, 6);

                LHCollider.transform.position = new Vector3(-0.65f, 1.73f, 0f);
                LHCollider.transform.localScale = new Vector3(6, 6, 6);

                RKCollider.transform.position = new Vector3(1.12f, -0.62f, 0f);
                RKCollider.transform.localScale = new Vector3(6, 6, 6);

                LKCollider.transform.position = new Vector3(-1.47f, -0.79f, 0f);
                LKCollider.transform.localScale = new Vector3(6, 6, 6);
                break;

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

        // Choses the next pose at random.
        pose = Random.Range(1, 4);
    }
}
