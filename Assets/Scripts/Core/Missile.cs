using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class Missile : MonoBehaviour 
{
	public Transform target;

	private Rigidbody2D rb;

	public GameObject Muzzleflash;

	public float speed = 5f;
	private float defaultSpeed;
	public float rotateSpeed = 200f;

	[Range(0, 5)]
	public int ignitionDelay = 3;

	public bool activeTracking = true;

	void Start () 
	{
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
		speed = defaultSpeed;
		Muzzleflash.SetActive(true);
	}

	IEnumerator jumpStart()
	{
		yield return new WaitForSeconds(ignitionDelay);

		startEngine();
	}
}
