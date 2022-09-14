using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{

	public float speed = 10f;
	public float brakingCoefficieant = 0.5f;
	public float sidewaysCoefficieant = 0.5f;

	public Rigidbody2D rb;

	//public Timer timer;


	void Update()
	{
		if (Input.GetButton("Accelerate")) //Accelerates the spaceship forwards / right.
		{
			rb.AddForce(Vector2.right * speed * Time.deltaTime); 
		}

		if (Input.GetButton("Brake")) //Accelerates the spaceship backwards / left to brake.
		{
			rb.AddForce(Vector2.left * speed * brakingCoefficieant * Time.deltaTime);
		}

		rb.AddForce(Input.GetAxis("Up/Down") * Vector2.up * speed * sidewaysCoefficieant * Time.deltaTime); //Accelerates the spaceship up or down to bypass asteroids.
	}
}
