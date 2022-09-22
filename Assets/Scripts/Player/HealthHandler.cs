using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthHandler : MonoBehaviour
{
	public Text text;
	string HPstring;

	public int HP = 100; //Health points of player

	public bool isDead = false; //For other scripts to check if the player is dead

	public GameObject sprite;

	public SceneController controller;

	void Setup()
	{
		Time.timeScale = 1;
	}

	public void takeDamage(int amount) //this function is responsible for taking damage. It decreases HP by specified amount and checks if player can be still alive.
	{
		Debug.Log("took " + amount + " points of damage");

		HP -= amount; 

		if(HP <= 0)
		{
			Die();
		}

		HPstring = HP.ToString() + "%";
		text.text = HPstring;
	}

	public void Die() //Lets the player die and notifies other scripts via isDead var
	{
		Debug.Log("killed player");

		isDead = true;

		Destroy(sprite);
		Time.timeScale = 0;

		controller.gameOver();

		//stop timer
	}
}
