using UnityEngine;
using System.Collections;

public class SetAsCanvasChild : MonoBehaviour 
{
	void Start () 
	{
		GameObject temp = GameObject.FindGameObjectWithTag("Canvas");

		Transform canvas = temp.GetComponent<Transform>();

		transform.SetParent(canvas);
	}
}
