using UnityEngine;
using System.Collections;

public class DisplaySetings : MonoBehaviour 
{
	public GameObject settings;

	public void Dsplay()
	{
		settings.SetActive(true);
	}

	public void Hide()
	{
		settings.SetActive(false);
	}
}
