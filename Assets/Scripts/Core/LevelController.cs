using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class LevelController : MonoBehaviour 
{
	//[Space(50)]


	//Meteor Generation
	public int meteorCount = 50;

	[Header("Size of meteorite field")]
	[Header("pivot point im middle left")]

	public GameObject Meteor;

	[Range(10, 400)]
	public int xRange;

	[Range(0, 20)]
	public int xClipppingRange = 5;

	[Range(10, 50)]
	public int yRange;

	[Range(0, 20)]
	public int meteorCrammingSphere = 5;

	public LayerMask meteorCrammingMask;

	//Player movement clamping
	[Header("Player box")]

	public Transform player;

	[Range(10, 60)]
	public int yRangeBox;

	[Range(10, 60)]
	public int leftRangeBox;

	[Range(10, 400)]
	public int rightRangeBox;

	void Start()
	{
		BuildLevel();
	}

	void BuildLevel()
	{
		//Spawns comets
		for(int i = meteorCount; i > 0; i--)
		{

			Vector2 position = new Vector2(player.position.x + UnityEngine.Random.Range(xClipppingRange, xRange),
			UnityEngine.Random.Range(-yRange, yRange));

			if(CheckForColliders(position))
			{
				Instantiate(Meteor, position, Quaternion.identity);
			} else
			{
				i++;
			}


		}
	}

	bool CheckForColliders(Vector2 position)
	{
		bool isCrammed = Physics.CheckSphere(position, meteorCrammingSphere, meteorCrammingMask);

		if(!isCrammed)
		{
			return true;
		} else
		{
			return false;
		}
	}
}
