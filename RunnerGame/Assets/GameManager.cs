using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Slider rate_slider;
    
    void Start()
    {
        PlayerPrefs.SetFloat("reward", 0f);
        rate_slider.value = PlayerPrefs.GetFloat("reward"); 
        

    }

    public void rate_up(float odul_degeri)
    {
        if(PlayerPrefs.GetFloat("reward") + odul_degeri> 1)
        {
            PlayerPrefs.SetFloat("reward", 1);
        }
        else
        {
            PlayerPrefs.SetFloat("reward", PlayerPrefs.GetFloat("reward") + odul_degeri);
        }
      
        //Debug.Log(PlayerPrefs.GetFloat("reward"));
        //Debug.Log(slider_Value);
        rate_slider.value = PlayerPrefs.GetFloat("reward");
    }
    public void rate_down(float ceza_degeri)
    {
        if(PlayerPrefs.GetFloat("reward") - ceza_degeri < 0)
        {
            PlayerPrefs.SetFloat("reward", 0);
        }
        else
        {
            PlayerPrefs.SetFloat("reward", PlayerPrefs.GetFloat("reward") - ceza_degeri);
        }
        

        rate_slider.value = PlayerPrefs.GetFloat("reward");
    }

  
    void Update()
    {
       
    }
}
