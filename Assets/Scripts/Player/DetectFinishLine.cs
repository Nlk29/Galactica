using UnityEngine;
using System.Collections;

public class DetectFinishLine : MonoBehaviour
{

	public SceneController controller;

	void OnTriggerEnter2D(Collider2D collider)
	{
		controller.youWon();
	}
}
