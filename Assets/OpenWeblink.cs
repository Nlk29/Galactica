using UnityEngine;
using System.Collections;

public class OpenWeblink : MonoBehaviour 
{
	public void OpenInDefaultBrowser(string weblink)
	{
		Application.OpenURL(weblink);
	}
}
