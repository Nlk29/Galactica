using UnityEngine;
using System.Collections;

public class Turret : MonoBehaviour 
{
	//Aim
	public Transform player;

	public Rigidbody2D rb;

	public int damp = 5;
	public int rotateSpeed = 200;

	[Space]

	//Fire
	[Range(20, 100)]
	public int fireRange = 20;

	public int cooldownTime = 3;

	public GameObject missile;

	public Transform firePoint;

	private bool cooldown;

	void Start () 
	{
	
	}
	
	void FixedUpdate () 
	{
		AimAtPlayer();
		FireAtPlayer();
	}

	void AimAtPlayer()
	{
		Vector2 direction = player.position - transform.position;
		direction.Normalize();

		float rotateAmount = Vector3.Cross(direction, transform.up).z;
		rb.angularVelocity = -rotateAmount * rotateSpeed;
	}

	void FireAtPlayer()
	{
		Debug.Log("fired at player");

		float length = Vector2.Distance(player.position, transform.position);

		if (length <= fireRange)
		{
			if (!cooldown)
			{
				Instantiate(missile, firePoint.position, transform.rotation);
				cooldown = true;
				StartCoroutine(doCooldown(cooldownTime));
				Debug.Log("fired");
			}
		}
	}

	IEnumerator doCooldown(int time)
	{
		yield return new WaitForSeconds(time);

		Debug.Log("ended turret cooldown");
		cooldown = false;
	}
}
