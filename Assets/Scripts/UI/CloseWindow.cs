using UnityEngine;
using System.Collections;

public class CloseWindow : MonoBehaviour 
{
	public void Close()
	{
		Destroy(gameObject);
	}
}
