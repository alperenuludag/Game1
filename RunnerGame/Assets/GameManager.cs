using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("UI OBJELER")]
    public Slider rate_slider;
    public GameObject oyundurdurma_paneli;

    [Header("GENEL LEVEL AYARLARI")]
    public float istenilen_rate_düzeyi;
    
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

  public void oyunudurdur(){
        oyundurdurma_paneli.SetActive(true);
        Time.timeScale = 0;
    }
    public void oyundan_cikiliyormu(string key)
    { 
        if(key == "evet")
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            oyundurdurma_paneli.SetActive(false);
            Time.timeScale = 1;
        }


    }

    void Update()
    {
       
    }
}
