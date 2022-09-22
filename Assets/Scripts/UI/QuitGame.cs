using UnityEngine;
using System.Collections;

public class QuitGame : MonoBehaviour
{
	void Update ()
	{
		if(Input.GetKey("space"))
		{
			Debug.Log("ended game");

			Application.Quit();
		}
	}
}
