using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image currentHealthbar;
    public Text ratioText;

    public Image currentHealthbarEnemy;
    public Text ratioTextEnemy;

    public GameObject yousuck;
    public GameObject winningIMG;

    public TextMesh damageValueEasy;
    public TextMesh damageValueMid;
    public TextMesh damageValueHard;


    private float hitpoint = 150;
    private float maxHitpoint = 150;

    private float hitpointEnemy = 150;
    private float maxHitpointEnemy = 150;

    public float damageEasy = 10;
    public float damageMid = 20;
    public float damageHard = 30;

    private float damageEnemy;

    private void Start()
    {
        UpdateHealthbar();

    }

    private void Update()
    {

        damageValueEasy.text = damageEasy.ToString();
        damageValueMid.text = damageMid.ToString();
        damageValueHard.text = damageHard.ToString();

        
       // if (Input.GetKeyDown("c") || Input.GetKeyDown("joystick button 3"))
       // {
        //    TakeDamage(23f);
       // }

       // if(Input.GetKeyDown("a") || Input.GetKeyDown("joystick button 4"))
        //{
        //    DealDamage();
       // }

        if(Screenswitch.difficulty == 0)
        {
            damageEnemy = 0;
        }

       if (Screenswitch.difficulty == 1)
        {
            damageEnemy = damageEasy;
        }

        if (Screenswitch.difficulty == 2)
        {
            damageEnemy = damageMid;
        }

        if (Screenswitch.difficulty == 3)
        {
            damageEnemy = damageHard;
        }
    }

    private void UpdateHealthbar()
    {
        float ratio = hitpoint / maxHitpoint;
        currentHealthbar.rectTransform.localScale = new Vector3(ratio, 1, 1);
        ratioText.text = (ratio*100).ToString("0") + "%";

        float ratioEnemy = hitpointEnemy / maxHitpointEnemy;
        currentHealthbarEnemy.rectTransform.localScale = new Vector3(ratioEnemy, 1, 1);
        ratioTextEnemy.text = (ratioEnemy * 100).ToString("0") + "%";

    }


    public void TakeDamage(float damage)
    {
        hitpoint -= damage;
        if (hitpoint < 1)
        {
            hitpoint = 0;
            ratioText.text = "DEAD";
            yousuck.SetActive(true);
        }
        UpdateHealthbar();
    }

    public void DealDamage()
    {
        hitpointEnemy -= damageEnemy;
        if(hitpointEnemy < 1)
        {
            hitpoint = 0;
            winningIMG.SetActive(true);
        }
        UpdateHealthbar();
    }



}
