using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechHeadFade : MonoBehaviour {

    Renderer renderer;
    public float fadeamt = 0.0f;
    public float speed = 0.1f;
    public bool fadingin = false;

	void Start () {
        renderer = GetComponent<Renderer>();
	}

    void FadeIn()
    {
        fadingin = true;
    }

    void Update () {

        //updates the material
        renderer.material.SetFloat("_fadeamt", fadeamt);

        if (fadingin == true){
            fadeamt = fadeamt + speed;
        }
    }
}
