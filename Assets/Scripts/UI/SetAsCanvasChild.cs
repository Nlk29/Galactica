using UnityEngine;
using System.Collections;

public class SetAsCanvasChild : MonoBehaviour 
{
	void Start () 
	{
		Debug.Log("Set " + gameObject.name + " as child of canvas");

		GameObject temp = GameObject.FindGameObjectWithTag("Canvas");

		Transform canvas = temp.GetComponent<Transform>();

		transform.SetParent(canvas);
	}
}
