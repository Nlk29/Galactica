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
	public string errorMessageChineseComputer;
	public string errorMessageAnyComputer;
	public string errorMessageFailedVerification;

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
		if (languagePack == badLanguagePack [0]) //Russia
		{
			errorMessage = errorMessageRussianComputer;
			systemOk = false;
		}
		if (languagePack == badLanguagePack [1] || languagePack == badLanguagePack[2]) //China
		{
			errorMessage = errorMessageChineseComputer;
			systemOk = false;
		}

		//Check file integrity of game. Piracy and cheating is not cool!
		if (!Application.genuine) 
		{
			errorMessage = errorMessageFailedVerification;
			systemOk = false;
		}

		//bypasses ChainOfTrust; uncomment only for testing purposes!
		//systemOk = true;

		//Final summary of checkup
		if (systemOk) 
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
 * - zh-HK
 * - zh-CH
 * - be-BY
 * 
 * errorMessageRussianComputer:
 * - On your hands is the blood of thousands of ukranians. As a sanction to President Putin's illegal, war-crime-committing actions in ukraine and his outrageous, fake-news based war-propaganda, I've decided to block this game on russian computers. Please use western media to inform yourself about the truth and help collapseing that cardhouse of lies.
 * 
 * errorMessageChineseComputer:
 * - It is sad to see how china's gouverment treats uigurs in their supression camps. As a sanction on this and other outrageous things like threatenning taiwan, I've decided to block this game on chinese computers.
 * 
 * errorMessageAnyComputer
 * - Sorry, Galactica isn't available in your country. I may did this because of some politics that i would describe as "Not Okay!" like f. ex. the violation of UN human rights. If you think that this is a mistake, please get in touch with me.
 * 
 * errorMessageFailedVerification:
 * - Cheating and Piracy is not cool! It seem like the game files have been altered to possibly get an unfair advantage. (Or even pirateing the game should it go on sale once) This is a very big red flag and as a consequence, the game will delete itself in 30s.
 */
