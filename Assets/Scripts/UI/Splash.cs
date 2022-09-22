using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Splash : MonoBehaviour 
{

	public string[] texts = new string[] 
	{
		"418 - I'm a teapot",
		"I'm not insane! My mother had me tested!",
		"Why you littile?",
		"Behold what I've created!",
		"Now for Windows XP",
		"You're in my spot!",
		"The 'Wow' starts now",
		"Our whole universe was in a hot, dense state",
		"110",
		"Sector 7G",
		"And it all started with the Big Bang",
		"It's Windows 95, It's sucking up my drive..",
		"Sorry Windows Activation failed, try again or buy a new Key",
		"But you know.. It's still Windows",
		"It has this well loved feature that's called activation",
		"An iPod, a phone and an internet communicator",
		"10 PRINT CHR$(205.5+RND(1)); : GOTO 10",
		"10 PRINT ''Hello World'' : GOTO 10",
		"6502",
		"Hello I'm Macintosh",
		"Penny, Penny, Penny",
		"I'm the creeper. Catch me if you can.",
		"Minecraft",
		"Fortnite sucks!",
		"Aquaman sucks!",
		"Howard help! My hand is stuck in the garbage disposer!",
		"Sheldon that's ridiculous!"
	};

	private Text textBox;

	void Start () 
	{
		Debug.Log("set splash");

		textBox = GetComponent<Text>();

		SetSplash();
	}
	
	void Update () 
	{
	
	}

	public void SetSplash()
	{
		textBox.text = texts[Random.Range(1, texts.Length)];
	}
}
