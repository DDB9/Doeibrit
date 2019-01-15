using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{

    public static Button easyButton;
    public static Button midButton;
    public static Button hardButton;

    public int pointReceivedEasy = 0;
    public int pointReceivedMid = 5;
    public int pointReceivedHard = 20;

    public Text pointValueEasy;
    public Text pointValueMid;
    public Text pointValueHard;


    void Start()
    {

        //I need the button vars to be static, so I need this shitty game to locate them for me
        easyButton = GameObject.FindGameObjectWithTag("easy").GetComponent<Button>();
        midButton = GameObject.FindGameObjectWithTag("mid").GetComponent<Button>();
        hardButton = GameObject.FindGameObjectWithTag("hard").GetComponent<Button>();

        easyButton.interactable = true;
        midButton.interactable = true;
        hardButton.interactable = true;

    }

    private void Update()
    {
        pointValueEasy.text = pointReceivedEasy.ToString();
        pointValueMid.text = pointReceivedMid.ToString();
        pointValueHard.text = pointReceivedHard.ToString();
    }


    public void EasyButton()
    {
        ButtonClicked.easyClicked = true;
        ScoreScript.points += pointReceivedEasy;
        easyButton.interactable = false;
        midButton.interactable = false;
        hardButton.interactable = false;

    }

    public void MidButton()
    {
        ButtonClicked.midClicked = true;
        ScoreScript.points += pointReceivedMid;
        easyButton.interactable = false;
        midButton.interactable = false;
        hardButton.interactable = false;

    }

    public void HardButton()
    {
        ButtonClicked.hardClicked = true;
        ScoreScript.points += pointReceivedHard;
        easyButton.interactable = false;
        midButton.interactable = false;
        hardButton.interactable = false;
    }

}


