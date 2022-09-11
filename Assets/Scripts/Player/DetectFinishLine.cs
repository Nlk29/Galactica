using UnityEngine;
using System.Collections;

public class DetectFinishLine : MonoBehaviour
{
	public float finishLine = 245.6f;
	float currentPosition;

	public SceneController controller;

	//public Transform transform;

	void Update ()
	{
		currentPosition = transform.position.x;

		if(currentPosition >= finishLine)
		{
			controller.youWon();

			//call stop time function
		}
	}
}
