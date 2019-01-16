using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyConRManager : MonoBehaviour {

    public GameObject canvas;
    public GameObject movingUI;

    float dmgEasy;
    float dmgMid;
    float dmgHard;

	void Start ()
    {
		
	}

	void Update ()
    {

        dmgEasy = canvas.GetComponent<HealthBar>().damageEasy;
        dmgMid = canvas.GetComponent<HealthBar>().damageMid;
        dmgHard = canvas.GetComponent<HealthBar>().damageHard;

        
        //B button
        if (Input.GetKeyDown("joystick button 2"))
        {
            TakeDamageEasy();
        }

        //Y button
        if (Input.GetKeyDown("joystick button 3"))
        {
            TakeDamageMid();
        }

        //X button
        if (Input.GetKeyDown("joystick button 1"))
        {
            TakeDamageHard();
        }

        //+ Button = joystick button 9
        //- Button = joystick button 8
        if (Input.GetKeyDown("joystick button 9") || Input.GetKeyDown("joystick button 8"))
        {
            DealDamage();
        }
        





	}



    void DealDamage()
    {
        canvas.GetComponent<HealthBar>().DealDamage();
        movingUI.GetComponent<Screenswitch>().Choose();
    }

    void TakeDamageEasy()
    {
        canvas.GetComponent<HealthBar>().TakeDamage(dmgEasy);
        canvas.GetComponent<JammerController>().DamageTaken();
    }

    void TakeDamageMid()
    {
        canvas.GetComponent<HealthBar>().TakeDamage(dmgMid);
        canvas.GetComponent<JammerController>().DamageTaken();
    }

    void TakeDamageHard()
    {
        canvas.GetComponent<HealthBar>().TakeDamage(dmgHard);
        canvas.GetComponent<JammerController>().DamageTaken();
    }

    void Hacking()
    {
        
    }




}
