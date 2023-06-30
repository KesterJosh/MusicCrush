using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   

public class SoundControl : MonoBehaviour
{

    public AudioListener AudioListener;


    [SerializeField] Image soundOnIcon;

    [SerializeField] Image soundOffIcon;

    private bool muted = false;

    [SerializeField] Image SFXOnIcon;

    [SerializeField] Image SFXOffIcon;

    private bool SFXmuted = false;


    void Start(){
        if(!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
        }else
        {
            Load();
        }
        UpdateButtonIcon();
        AudioListener.pause = muted;

        if(!PlayerPrefs.HasKey("mutedSFX"))
        {
            PlayerPrefs.SetInt("mutedSFX", 0);
        }else
        {
            Load();
        }
        UpdateButtonIconSFX();
        // AudioListener.pause = muted;
    }

    public void onButtonPressed(){
        if(muted == false){
            AudioListener.pause = true;
            muted = true;
        }else{
            AudioListener.pause = false;
            muted = false;
        }
        Save();
        UpdateButtonIcon(); 
    }

    private void UpdateButtonIcon(){
        if(muted == false)
        {
            soundOnIcon.enabled = true;
            soundOffIcon.enabled = false;
        }else
        {
            soundOnIcon.enabled = false;
            soundOffIcon.enabled = true;
        }
    }

    private void UpdateButtonIconSFX(){
        if(SFXmuted == false)
        {
            SFXOnIcon.enabled = true;
            SFXOffIcon.enabled = false;
        }else
        {
            SFXOnIcon.enabled = false;
            SFXOffIcon.enabled = true;
        }
    }

    public void onButtonPressedSFX(){
        if(SFXmuted == false){
            // AudioListener.pause = true;
            SFXmuted = true;
        }else{
            // AudioListener.pause = false;
            SFXmuted = false;
        }
        SaveX();
        UpdateButtonIconSFX(); 
    }

    private void Load(){
        muted = PlayerPrefs.GetInt("muted") == 1;
    }

    private void Save(){
        PlayerPrefs.SetInt("muted", muted ? 1 : 0 );
    } 

    private void LoadX(){
        SFXmuted = PlayerPrefs.GetInt("mutedSFX") == 1;
    }

    private void SaveX(){
        PlayerPrefs.SetInt("mutedSFX", muted ? 1 : 0 );
    } 
}
