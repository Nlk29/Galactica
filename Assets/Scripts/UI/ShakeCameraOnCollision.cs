using UnityEngine;
using System.Collections;

public class ShakeCameraOnCollision : MonoBehaviour 
{
    bool wait;

    public float shakingIntensity = 0.6f;
    public int shakingTime = 1;

	public int shakingCount = 10;

    public Transform camera;

    void OnCollisionEnter2D(Collision2D collision)
    {
		Debug.Log("shook camera");

		for(int i = 0; i < shakingCount; i++)
		{
        	camera.transform.position = new Vector2(0, 0);
        	wait = true;
			while (wait)
			{
	
			}
	
			camera.transform.position = new Vector2(shakingIntensity, 0);
			wait = true;
			while (wait) 
			{
				
			}
				
			camera.transform.position = new Vector2(-1 * shakingIntensity, 0);
			wait = true;
			while (wait) 
			{
				
			}
	
			camera.transform.position = new Vector2(0, shakingIntensity);
			wait = true;
			while (wait) 
			{
				
			}
				
			camera.transform.position = new Vector2(0, -1 * shakingIntensity);
			wait = true;
			while (wait) 
			{
			
			}
		}
		   
    }

    IEnumerator waitTimer()
    {
		yield return new WaitForSeconds (shakingTime);
		wait = false;
    }
}
