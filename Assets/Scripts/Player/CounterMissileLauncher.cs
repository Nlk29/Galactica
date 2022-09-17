using UnityEngine;
using System.Collections;

public class CounterMissileLauncher : MonoBehaviour
{
	public GameObject counterMissile;
	public GameObject crosshairs;

	public Camera camera;

	public Rigidbody2D rb;

	public Collider2D collider;

	public float speed = 5f;
	public float rotateSpeed = 200f;
	public float pivotOffcenter = 0.5f;
	public float range = 200f;



	private Vector3 target;


	void Start()
	{
		
	}

	void Update()
	{
		UpdateCrosshair();
		AimAtMouse();
		LaunchAttack();
	} 

	void UpdateCrosshair()
	{
		float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * speed;
		float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * speed;

		crosshairs.transform.position += new Vector3(mouseX,
			mouseY,
			0);
	}

	void AimAtMouse()
	{
		Vector2 offset = crosshairs.transform.position - transform.position;

		transform.rotation = Quaternion.LookRotation(Vector3.forward,
			offset);
	}

	public void ResetCrosshair()
	{
		crosshairs.transform.position = Vector3.zero;
	}

	void LaunchAttack()
	{
		if(Input.GetButtonDown("Fire1"))
		{
			//Instantiate(counterMissile, transform.position, transform.rotation);

			collider.enabled = false;

			RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up);

			Debug.Log(hit);

			if (hit.collider != null)
			{
				//hit.transform.GetComponent<Collided>();
			}

			collider.enabled = true;
		}
	}
}
