using UnityEngine;
using System.Collections;

public class ExitGame : MonoBehaviour 
{
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			Debug.Log("ended game");

			Application.Quit();
		}
	}
}
