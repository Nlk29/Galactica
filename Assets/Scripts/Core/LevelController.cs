using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class LevelController : MonoBehaviour 
{
	//[Space(50)]
	[Header("Meteors")]
	[Space]

	//Meteor Generation
	public int meteorCount = 50;

	//[Header("Size of meteorite field")]
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

	[Space]
	
	//[Space(50)]
	[Header("Turrets")]
	[Space]

	/*
	//Turret Generation
	public int turretCount = 5;

	//[Header("Size of meteorite field")]
	[Header("pivot point im middle left")]

	public GameObject Turret;

	[Range(10, 400)]
	public int xRangeTurret;

	[Range(0, 20)]
	public int xClipppingRangeTurret = 5;

	[Range(10, 50)]
	public int yRangeTurret;

	[Range(0, 20)]
	public int turretCrammingSphere = 5;

	public LayerMask turretCrammingMask;

	[Space]

	*/

	//Player movement clamping
	[Header("Player box")]

	public Transform player;

	[Range(10, 60)]
	public int yRangeBox;

	[Range(10, 60)]
	public int leftRangeBox;

	[Range(10, 400)]
	public int rightRangeBox;

	private Vector2 startPoint;

	void Start()
	{
		BuildLevel();
		InitializeBox();
	}

	void Update()
	{
		ClampPlayer();
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
		
		/*
		//Spawns turrets
		for(int j = meteorCount; j > 0; j--)
		{

			Vector2 position = new Vector2(player.position.x + UnityEngine.Random.Range(xClipppingRangeTurret, xRangeTurret),
			UnityEngine.Random.Range(-yRangeTurret, yRangeTurret));

			if(CheckForColliders(position))
			{
				Instantiate(Turret, position, Quaternion.identity);
			} else
			{
				j++;
			}


		}

		*/
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

	void InitializeBox()
	{
		startPoint = transform.position;
	}

	void ClampPlayer()
	{
		/*
		transform.position = new Vector2(startPoint.x + Mathf.Clamp(transform.position.x, leftRangeBox, rightRangeBox),
			startPoint.y + Mathf.Clamp(transform.position.y, -yRangeBox, yRangeBox));
		*/
	}
}
