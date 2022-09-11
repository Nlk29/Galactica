using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class LevelController : MonoBehaviour 
{
	public int highestLevel = 100;
	public int currentLevelNumber;
	private int levelInput;

	public InputField field;

	public SceneController controller;


	public void loadLevel()
	{
		int i = Int32.Parse(field.text);
		levelInput = i;

		if(highestLevel >= levelInput)
		{
			controller.loadLevel(levelInput);
		}
	}

	public void saveThisLevel(int level)
	{

	}
}
