using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class Missile : MonoBehaviour 
{
	public Transform target;

	private Rigidbody2D rb;

	public Collider2D collider;

	public GameObject Muzzleflash;

	public float speed = 5f;
	private float defaultSpeed;
	public float rotateSpeed = 200f;

	[Range(0, 5)]
	public int ignitionDelay = 3;

	public bool activeTracking = true;

	void Start () 
	{
		collider.enabled = false;

		if (activeTracking)
		{
			
		}
		else   
		{
			startEngine();
		}
		defaultSpeed = speed;
		target = GameObject.FindGameObjectWithTag("Player").transform;
		rb = GetComponent<Rigidbody2D>();
		speed = 1;
		StartCoroutine(jumpStart());
	}
	
	void FixedUpdate () 
	{	if(activeTracking)
		{
			Vector2 direction = (Vector2)target.position - rb.position;
			direction.Normalize();

			float rotateAmount = Vector3.Cross(direction, transform.up).z;

			rb.angularVelocity = -rotateAmount * rotateSpeed;
		}

		rb.velocity = transform.up * speed;
	}

	void startEngine()
	{
		if (activeTracking)
		{
			collider.enabled = true;
		} else
		{
			//StartCoroutine(enableCollider());
		}

		speed = defaultSpeed;
		Muzzleflash.SetActive(true);
	}

	IEnumerator jumpStart()
	{
		yield return new WaitForSeconds(ignitionDelay);

		startEngine();
	}

	IEnumerator enableCollider()
	{
		yield return new WaitForSeconds(2);

		collider.enabled = true;
	}

	/*
	void OnTriggerExit(Collider2D other)
	{
		startEngine();
	}
	*/
}
