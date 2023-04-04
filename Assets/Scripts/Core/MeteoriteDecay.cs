using UnityEngine;
using System.Collections;

public class MeteoriteDecay : MonoBehaviour 
{
	[Range(0, 10)]
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
