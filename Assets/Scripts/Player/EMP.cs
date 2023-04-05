using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class EMP : MonoBehaviour
{
	[HideInInspector]
	public bool emp;
	public bool isUI;

	public GameObject text;

	[SerializeField]
	private Text EMPCooldown;

	[SerializeField]
	private int flashes = 6;
	[SerializeField]
	private float randomDiscrepancyMax = 0.1f;
	[SerializeField]
	private float explodingAnimationTime = 1.25f;
	[Range(10f, 100f)]
	[SerializeField]
	private float minRotation = 50f;
	[Range(110f, 350f)]
	[SerializeField]
	private float maxRotation = 250f;
	[Range(0f, 1f)]
	[SerializeField]
	private float lrDistribution = 0.5f;
	[SerializeField]
	private float cooldownTime = 10f;
	[SerializeField]
	private float cooldownStep = 1f;
	private float cooldown = 0f;


	Image _image = null;

	void Awake()
	{
		_image = GetComponent<Image>();
		_image.enabled = false;
	}

	void Update()
	{
		if(Input.GetButtonDown("Fire1") && !emp && cooldown <= 0f)
		{
			emp = true;

			StartCoroutine(FlashScreen());
		}

		if(emp)
		{
			if(isUI)
			{
				//GameObject.FindGameObjectsWithTag("Missile");
				foreach (GameObject i in GameObject.FindGameObjectsWithTag("Missile"))
				{
					StartCoroutine(DestroyMissiles(i));
				}

				
			}
		}

		if(cooldown > 0f)
		{
			cooldown -= Time.deltaTime;
			EMPCooldown.gameObject.SetActive(true);
		} else
		{
			EMPCooldown.gameObject.SetActive(false);
		}

		int tempCooldown = (int)cooldown * 100000;
		EMPCooldown.text = ((float)tempCooldown / 100000f).ToString() + "s";
	}

	IEnumerator DestroyMissiles(GameObject missile)
	{
		if(!missile.GetComponent<Missile>().destroyed)
		{
			missile.GetComponent<Missile>().destroyed = true;

			missile.GetComponent<Animator>().SetTrigger("Exploding");
			Debug.Log(missile.GetComponent<Animator>().ToString());
			missile.GetComponent<Missile>().enabled = false;

			float rotation = Random.Range(minRotation, maxRotation);
			if(Random.Range(0f, 1f) < lrDistribution)
			{
				rotation = -rotation;
			}
			missile.transform.rotation = new Quaternion(0f, 0f, rotation, 0f);
			missile.GetComponent<Rigidbody2D>().isKinematic = false;
			missile.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(1000, -1000), Random.Range(1000, -1000)));

			yield return new WaitForSeconds(explodingAnimationTime);

			Destroy(missile);
		}

	}

	IEnumerator FlashScreen()
	{
		text.SetActive(true);

		for (int i = 0; i < flashes; i++)
		{
			_image.enabled = true;
			yield return new WaitForSeconds(Random.Range(0.5f - randomDiscrepancyMax, 0.5f + randomDiscrepancyMax));

			_image.enabled = false;
			yield return new WaitForSeconds(Random.Range(0.2f - randomDiscrepancyMax, 0.2f + randomDiscrepancyMax));
		}

		text.SetActive(false);

		emp = false;

		cooldown = cooldownTime;
	}
}
