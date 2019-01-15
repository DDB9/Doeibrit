using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPoser : MonoBehaviour {

    private int randomnumber;
    public int poseamt;
    public Animator animator1;
    public Animator animator2;
    public Animator animator3;

    public void Randomise() {

        randomnumber = Random.Range(1, poseamt);

        animator1.SetInteger("randomnumber", randomnumber);
        animator2.SetInteger("randomnumber", randomnumber);
        animator3.SetInteger("randomnumber", randomnumber);
        Debug.Log(Random.Range(1, poseamt));
    }

}
