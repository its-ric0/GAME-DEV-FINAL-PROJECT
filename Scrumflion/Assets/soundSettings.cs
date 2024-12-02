using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class soundSettings : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer;
    [SerializeField] Slider volumeSlider;

    private void Start()
    {
        SetMasterVolume();
        
    }
    public void SetMasterVolume()
    {
        SetVolume("Music", volumeSlider.value);
        
    }
    void SetVolume(string groupName, float value)
    {
        float adjustedVolume = Mathf.Log10(value) * 20;
        audioMixer.SetFloat(groupName, adjustedVolume);
    }
}
