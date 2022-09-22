using UnityEngine;
using System.Collections;

public class ChangeSpriteByHealth : MonoBehaviour 
{
	public HealthHandler health;

	public Sprite player;

	public Sprite slightlyDamaged;

	void Update () 
	{
		if(health.HP <= 75)
		{

		}
	}
}
