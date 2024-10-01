using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicSFX : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioSource[] audioSource;
    private const string VolumePrefKey = "VolumePref";

    void Start()
    {
        // Load saved volume if it exists, otherwise set default volume to 0.5
        float savedVolume = PlayerPrefs.GetFloat(VolumePrefKey, 0.5f);
        volumeSlider.value = savedVolume;

        foreach (AudioSource a in audioSource)
        {
            a.volume = savedVolume;
        }

        // Add listener to the slider to update volume in real-time
        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    public void SetVolume(float volume)
    {
        // Set the audio source's volume and save the new value to PlayerPrefs
        foreach (AudioSource a in audioSource)
        {
            a.volume = volume;
        }
        PlayerPrefs.SetFloat(VolumePrefKey, volume);
    }
}
