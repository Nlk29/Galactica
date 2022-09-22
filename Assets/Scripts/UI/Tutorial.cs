using UnityEngine;
using System.Collections;

public class Tutorial : MonoBehaviour 
{

    void Start()
    {
        if(PlayerPrefs.GetInt("doTutorial") != 1)
        {
            Debug.Log("loaded tutorial");

            PlayerPrefs.SetInt("doTutorial", 1);

            Application.LoadLevel("1");
        }
    }
}
