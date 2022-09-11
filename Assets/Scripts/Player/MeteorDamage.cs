using UnityEngine;
using System.Collections;

public class MeteorDamage : MonoBehaviour
{
	public int minimumMeteorDamage = 4;
	public int maximumMeteorDamage = 8;

	public HealthHandler healthHandler;

	void OnCollisionEnter2D(Collision2D collision)
	{
		healthHandler.takeDamage(Random.Range(minimumMeteorDamage, maximumMeteorDamage));
	}
}
