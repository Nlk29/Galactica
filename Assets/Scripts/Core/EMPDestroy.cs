using UnityEngine;
using System.Collections;

public class EMPDestroy : MonoBehaviour 
{
	void Update () 
	{
		if (Input.GetKey(KeyCode.E))
		{
			Debug.Log("destroyed!");
			Destroy(gameObject);
		}
	}
}
