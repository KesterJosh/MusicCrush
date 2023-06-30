using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settings_control : MonoBehaviour
{

    public GameObject SettingsX;
    
    public void SettingsOn()
    {
        SettingsX.SetActive(true);
    }

    public void SettingsOff()
    {
        SettingsX.SetActive(false);
    }
}
