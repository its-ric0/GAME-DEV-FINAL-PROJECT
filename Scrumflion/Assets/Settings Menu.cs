using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;


public class SettingsMenu : MonoBehaviour
{
   
    public TMPro.TMP_Dropdown resolutionDropdown;
    public TMPro.TMP_Dropdown qualityDropdown;
    public TMPro.TMP_Dropdown vsyncDropdown;
   
    

    public void Start()
    {
        

        
        vsyncDropdown.ClearOptions();
        List<string> vsyncOptions = new List<string> { "Off", "On" };
        vsyncDropdown.AddOptions(vsyncOptions);
        vsyncDropdown.value = QualitySettings.vSyncCount;
        vsyncDropdown.RefreshShownValue();
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            BackToMainMenu();
        }
    }
   
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }
    
    public void SetVsync(int vsyncIndex)
    {
        QualitySettings.vSyncCount = vsyncIndex;
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
