using UnityEngine;
using System.Collections;

public class MeteoriteDecay : MonoBehaviour 
{
	public int decayTime = 1;

	void OnCollisionEnter2D(Collision2D collision)
	{
		StartCoroutine(waitTimer());
	}

	IEnumerator waitTimer()
	{
		yield return new WaitForSeconds(decayTime);

		Destroy(gameObject);
	}
}
