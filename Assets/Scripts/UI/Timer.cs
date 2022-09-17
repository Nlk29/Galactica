using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour 
{
	public bool dieAt0Seconds = true;
	public bool timerActive = true;

	float currentTime;
	public int startMinutes;

	public Text currentTimeText;

	public HealthHandler health;

	void Start () 
	{
		currentTime = startMinutes * 60;
	}


	void Update()
	{
		if (timerActive)
		{
			currentTime -= Time.deltaTime;
		}

		TimeSpan time = TimeSpan.FromSeconds(currentTime);
		currentTimeText.text = time.Minutes.ToString() + ":" + time.Seconds.ToString();

		if(currentTime <= 0 && dieAt0Seconds)
		{
			health.Die();
		}
	}

	public void startTimer()
	{
		timerActive = true;
	}

	public void stopTimer()
	{
		timerActive = false;
	}
}
