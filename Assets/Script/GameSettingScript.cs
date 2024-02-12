using Fungus;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettingScript : MonoBehaviour
{

   
    bool AutoNextDialog; // Автоматичне перелистування діалогів

    private void Awake()
    {
        AutoNextDialog = IntToBool(PlayerPrefs.GetInt("AutoNextDialog"));

        
    }

    private bool IntToBool(int var)
    {
        if (var == 1) return true;
        else return false;
    }

}
