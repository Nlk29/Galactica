using UnityEngine;
using System.Collections;

public class MeteorDamage : MonoBehaviour
{
	public int minimumMeteorDamage = 4;
	public int maximumMeteorDamage = 8;
	public int shakeTime = 1;

	public HealthHandler healthHandler;

	public ShakeCamera shakeCamera;

	void OnCollisionEnter2D(Collision2D collision)
	{
		Debug.Log("took damage by collision");

		healthHandler.takeDamage(Random.Range(minimumMeteorDamage, maximumMeteorDamage));
		shakeCamera.shake(shakeTime);
	}
}
