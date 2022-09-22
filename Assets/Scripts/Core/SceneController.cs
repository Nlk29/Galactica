using UnityEngine;
using System.Collections;
//using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

	public void startGame()
	{
		Application.LoadLevel("0");
	}

	public void loadLevel(int level)
	{
		Debug.Log("loaded level " + level);

		Application.LoadLevel(level.ToString());
	}

	public void endGame()
	{
		Debug.Log("loaded outro");

		Application.LoadLevel("Outro");
	}

	public void gameOver()
	{
		Debug.Log("loaded gameover");

		Application.LoadLevel("GameOver");
	}

	public void youWon()
	{
		Debug.Log("loaded YouWon");

		Application.LoadLevel("YouWon");
	}

	public void mainMenu()
	{
		Debug.Log("loaded menu");

		Application.LoadLevel("Menu");
	}

	public void tutorial()
	{
		Debug.Log("loaded tutorial");

		Application.LoadLevel("1");
	}

	public void roguelike()
	{
		Debug.Log("loaded roguelike");

		Application.LoadLevel("Roguelike");
	}
}
