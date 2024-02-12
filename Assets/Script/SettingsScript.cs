using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SettingsScript : MonoBehaviour
{
    [SerializeField] private Slider Sound;
    [SerializeField] private Slider Music;
    [SerializeField] private Toggle Mute;
    [SerializeField] private Toggle AutoNextDialog;
    private bool isStarted = false;

    private void Awake()
    {
        Sound.value = PlayerPrefs.GetFloat("Sound");
        Music.value = PlayerPrefs.GetFloat("Music");
        Mute.isOn = IntToBool(PlayerPrefs.GetInt("Mute"));
        AutoNextDialog.isOn = IntToBool(PlayerPrefs.GetInt("AutoNextDialog"));
        isStarted = true;
    }

    public void ValueChanged()
    {
        if (!isStarted) return;

        PlayerPrefs.SetFloat("Sound", Sound.value);
        PlayerPrefs.SetFloat("Music", Music.value);
        PlayerPrefs.SetInt("Mute", BoolToInt(Mute.isOn));
        PlayerPrefs.SetInt("AutoNextDialog", BoolToInt(AutoNextDialog.isOn));

    }

    private int BoolToInt(bool var)
    {
       if(var) return 1;
       else return 0;
    }

    private bool IntToBool(int var)
    {
        if (var == 1) return true;
        else return false;
    }

}
