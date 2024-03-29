using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    [SerializeField] private AudioMixer mixer;
    [SerializeField] private Slider volume_slider;

    const string mixer_value = "MasterVolume";
    void Awake()
    {
        volume_slider.onValueChanged.AddListener(SetVolume);
    }

    public void SetVolume(float volume)
    {
        mixer.SetFloat(mixer_value, Mathf.Log10(volume) * 20);
    }
}
