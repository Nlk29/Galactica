﻿using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using System.Collections;

public class Settings : MonoBehaviour 
{
	[Header("Volume")]
	public AudioMixer audioMixer;

	public Slider volumeSlider;

	[Header("Quality")]

	public Text qualityText;

	void Start()
	{
		//Load volume
		SetVolume(PlayerPrefs.GetFloat("masterVolume"));
		volumeSlider.value = PlayerPrefs.GetFloat("masterVolume");

		//Load quality
		int temp = QualitySettings.GetQualityLevel();
		qualityText.text = temp.ToString();
	}

	public void SetVolume(float volume)
	{
		if(volume > -25)
		{
			audioMixer.SetFloat("Master", volume);
		} else
		{
			audioMixer.SetFloat("Master", -60f);
		}

		PlayerPrefs.SetFloat("masterVolume", volume);
	}

	public void SetQuality(int qualityIndex)
	{
		QualitySettings.SetQualityLevel(qualityIndex);
	}

	public void SetFullscreen(bool isFullscreen)
	{
		Screen.fullScreen = isFullscreen;
	}
}
