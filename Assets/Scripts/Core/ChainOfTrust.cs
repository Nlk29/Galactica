using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Globalization;
using System.Threading;
using System.Linq;
using Microsoft.Win32;

public class ChainOfTrust : MonoBehaviour 
{
	protected bool systemOk = true;
	protected bool brickGame = false;

	public SceneController controller;

	public Text status;

	//Only a note
	public string Note = "element 0 always mapps to Russia and elements 1-2 always map to China";

	public string[] badLanguagePack;
	private string errorMessage = "N/A";
	public string errorMessageRussianComputer;
	public string errorMessageAnyComputer;
	public string errorMessageFailedVerification;
	public string errorMessageFailedNetworkConnection;

	/*static RegistryKey BaseFolderPath = Registry.LocalMachine;
	static string SubFolderPath = "SYSTEM\CurrentControlSet\Control\ContentIndex\Language";*/

	void Start () 
	{
		//startup anti-mod/bad player checks

		//Check for banned Languages to ban certain countries from running the game; Right now these are Russia and China
		Debug.Log (CultureInfo.InstalledUICulture);
		string languagePack = CultureInfo.InstalledUICulture.ToString();
		/*if (badLanguagePack.Contains(languagePack)) //Any banned Language Pack
		{
			errorMessage = errorMessageAnyComputer;
			systemOk = false;
		}
		 Needs to be fixed*/

		//Checks for banned regions by using the language pack of the computer.
		if (languagePack == badLanguagePack [0]) //Russia
		{
			errorMessage = errorMessageRussianComputer;
			systemOk = false;
			Debug.LogError("badLanguagePack");
		}

		//Check file integrity of game. Piracy and cheating is not cool!
		if (!Application.genuine && Application.genuineCheckAvailable) 
		{
			errorMessage = errorMessageFailedVerification;
			systemOk = false;
			Debug.LogError("failedFileIntegirtyProtection");
		}

		
		if (Application.internetReachability.ToString() == "NotReachable")
		{
			errorMessage = errorMessageFailedNetworkConnection;
			systemOk = false;
			Debug.LogError("failedNetworkConnection");
		}

		//bypasses ChainOfTrust; uncomment only for testing purposes!
		//systemOk = true;

		//Final summary of checkup
		if (systemOk || Application.isEditor) 
		{
			controller.mainMenu ();
		} else 
		{
			status.text = errorMessage;
			if(brickGame)
			{
				//Break game by f. ex. deleteing Asssembly-CSharp.dll
			}
		}
	}
}

/*
 * Default values:
 * 
 * badLanguagePack:
 * 
 * - ru-RU
 * 
 * errorMessageRussianComputer:
 * - In 2022, The gouverment of the russian federation has decided to legalize software piracy. While this game is open source, stealing commercial software is nothing other that spitting in the face of the developers. So I've decided to block this game on russian systems.
 * 
 * errorMessageFailedVerification:
 * - Cheating and Piracy is not cool! It seem like the game files have been altered to possibly get an unfair advantage. (Or even pirateing the game should it go on sale once) This is a very big red flag and as a consequence, the game will delete itself in 30s.
 * 
 * errorMessageFailedActivation:
 * - It seems like your windows copy isn't activated. To prevent cheating you have to actiavte Wndows. Go on this site for more information: https://support.microsoft.com/en-us/windows/activate-windows-c39005d4-95ee-b91e-b399-2820fda32227 (Galactica and its creators are not affiliated with Microsoft in any ways)
 * 
 * errorMessageFailedNetworkConnection:
 * - This game relies on a connection to backend servers. For managing accounts, remote management and ota updates. So although this game runs on XP, an internet connection is required.
 */
