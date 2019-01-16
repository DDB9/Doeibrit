using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour {

    private float timer = 10.0f;
    private static float startTime;
    string seconds;
    float t;

    // Use this for initialization
    void Start () {
        startTime = Time.time;
    }
	
	// Update is called once per frame
	void Update () {
		t = startTime - Time.time + timer;

        if ((t % 60) <= 0.0f) {
            Debug.Log("SCENE SWITCH");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }


}
