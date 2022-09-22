using UnityEngine;
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
		audioMixer.SetFloat("Master", volume);

		PlayerPrefs.SetFloat("masterVolume", volume);
	}

	public void SetQuality(int qualityIndex)
	{
		QualitySettings.SetQualityLevel(qualityIndex);
	}
}
