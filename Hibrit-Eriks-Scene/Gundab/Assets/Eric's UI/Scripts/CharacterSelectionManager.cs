using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelectionManager : MonoBehaviour {

    public static int charSelect;

	


    public void CharSelect0()
    {
        charSelect = 0;
        SceneManager.LoadScene("MainScene");
    }

    public void CharSelect1()
    {
        charSelect = 1;
        SceneManager.LoadScene("MainScene");
    }

    

}
