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
		Application.LoadLevel(level.ToString());
	}

	public void endGame()
	{
		Application.LoadLevel("Outro");
	}

	public void gameOver()
	{
		Application.LoadLevel("GameOver");
	}

	public void youWon()
	{
		Application.LoadLevel("YouWon");
	}

	public void mainMenu()
	{
		Application.LoadLevel("Menu");
	}
}
