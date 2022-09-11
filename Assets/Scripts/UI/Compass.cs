using UnityEngine;
using System.Collections;

public class Compass : MonoBehaviour 
{
	public Transform player;

	Vector3 vector;

	void Update()
	{
		transform.rotation = Quaternion.Inverse(player.rotation);
	}
}
