using UnityEngine;
using System.Collections;

public class CounterMissileLauncher : MonoBehaviour
{
	public Transform firePoint;

	public GameObject counterMissile;
	public GameObject crosshairs;

	public Camera camera;

	public float speed = 5f;

	private Vector3 target;


	void Start()
	{
		
	}

	void Update()
	{
		UpdateCrosshair();
		AimAtMouse();
	}

	void UpdateCrosshair()
	{
		float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * speed;
		float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * speed;
		Debug.Log(mouseY);

		crosshairs.transform.position += new Vector3(mouseX,
			mouseY,
			0);
	}

	void AimAtMouse()
	{
		
	}

	public void ResetCrosshair()
	{
		crosshairs.transform.position = Vector3.zero;
	}
}
