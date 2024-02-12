using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagerScript : MonoBehaviour
{
    
    public void OpenSettingsLayout()
    {
        WindowsManager.Layout.OpenLayout("Settings");
    }

    public void OpenMainMenuLayout()
    {
        WindowsManager.Layout.OpenLayout("Main");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");

    }

    private bool IntToBool(int var)
    {
        if(var == 1) return true;
        else return false;
    }


}
