using UnityEngine;
using System.Collections;

public class DetectFinishLine : MonoBehaviour
{

	public SceneController controller;

	void OnTriggerEnter2D(Collider2D collider)
	{
		string colliderName = collider.gameObject.ToString();

		Debug.Log(colliderName);

		if(colliderName == "base (UnityEngine.GameObject)")
		{
			controller.youWon();
		}
	}
}
