using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class OptionsMenu : MonoBehaviour
{
    public AudioMixer mixAudio;
    public Dropdown resolutionDrop;

    // Start is called before the first frame update

    Resolution[] resolutions;

    void Start()
    {
        resolutions = Screen.resolutions;
        resolutionDrop.ClearOptions();
        List<string> resOptions = new List<string>();

        int currentRes = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            resOptions.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentRes = i;
            }
        }
        resolutionDrop.AddOptions(resOptions);
        resolutionDrop.value = currentRes;
        resolutionDrop.RefreshShownValue();
    }

    public void setRes(int resIndex)
    {
        Resolution res = resolutions[resIndex];
        Screen.SetResolution(res.width, res.height, Screen.fullScreen);
    }
    public void VolumeSetting(float vol)
    {
        mixAudio.SetFloat("Vol", vol);
    }

    public void setTheQuality(int qualityInd)
    {
        Debug.Log(qualityInd);
        QualitySettings.SetQualityLevel(qualityInd);
    }

    public void setFullscreen(bool fullScreen)
    {
        Screen.fullScreen = fullScreen;
    }
    //void Start()
    //{
    //    GameObject.FindGameObjectWithTag("Music").GetComponent<Music>().PlayingTheMusic();
    //}


}
