using UnityEngine;
using System.Collections;

public class setCursor : MonoBehaviour 
{

	public Texture2D cursor;

	public bool hideCursor;

	void Start () 
	{
		if (hideCursor)
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
		else
		{
			Cursor.lockState = CursorLockMode.None;
			Cursor.SetCursor(cursor, Vector2.zero, CursorMode.Auto);
		}
	}
	
}
