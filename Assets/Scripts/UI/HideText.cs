using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HideText : MonoBehaviour 
{
	public Text text;

	[Space]

	public Image bg;
	public Image bar;
	public Image exit;
	public Text title;
	
	void Update () 
	{
		if(text.text == "")
		{
			Debug.Log("hid window");

			bg.enabled = false;
			bar.enabled = false;
			exit.enabled = false;
			title.enabled = false;
		}
		else
		{
			Debug.Log("showed window");

			bg.enabled = true;
			bar.enabled = true;
			exit.enabled = true;
			title.enabled = true;
		}
	}
}
