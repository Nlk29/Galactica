using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class EMP : MonoBehaviour 
{
	[HideInInspector]
	public bool emp;
	public bool isUI;

	public GameObject text;

	Image _image = null;

	void Awake()
	{
		_image = GetComponent<Image>();
		_image.enabled = false;
	}

	void Update () 
	{
		if (Input.GetButtonDown("Fire1") && !emp)
		{
			if(isUI)
			{
				StartCoroutine(FlashScreen());
			}
		}
	}

	IEnumerator FlashScreen()
	{
		emp = true;
		text.SetActive(true);

		_image.enabled = true;
		yield return new WaitForSeconds(0.5f);

		_image.enabled = false;
		yield return new WaitForSeconds(0.2f);

		_image.enabled = true;
		yield return new WaitForSeconds(0.5f);

		_image.enabled = false;
		yield return new WaitForSeconds(0.2f);

		_image.enabled = true;
		yield return new WaitForSeconds(0.5f);

		_image.enabled = false;
		yield return new WaitForSeconds(0.2f);

		_image.enabled = true;
		yield return new WaitForSeconds(0.5f);

		_image.enabled = false;
		yield return new WaitForSeconds(0.2f);

		_image.enabled = true;
		yield return new WaitForSeconds(0.5f);

		_image.enabled = false;
		yield return new WaitForSeconds(0.2f);

		emp = false;
		text.SetActive(false);
	}
}
