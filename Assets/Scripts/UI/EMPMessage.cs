using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EMPMessage : MonoBehaviour 
{

	public Text text;

	[Range(0.1f, 5f)]
	public float flash = 0.25f;
	
	void Awake()
	{
		StartCoroutine(Flash());
	}

	IEnumerator Flash()
	{
		text.enabled = true;
		yield return new WaitForSeconds(flash);

		text.enabled = false;
		yield return new WaitForSeconds(flash);

		StartCoroutine(Flash());
	}
}
