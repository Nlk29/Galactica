using UnityEngine;
using System.Collections;

public class ActivateMuzzleflash : MonoBehaviour 
{
	public GameObject muzzleflash;

	public AudioSource sound;

	void Update () 
	{
		if(Input.GetKey(KeyCode.Space))
		{
			muzzleflash.SetActive(true);
			sound.enabled = true;
		} else
		{
			muzzleflash.SetActive(false);
			sound.enabled = false;
		}
	}
}
