using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu_manager : MonoBehaviour
{
    private void Start()
    {
        kontrol_et_Ve_Tanimla();
    }
    public void oyuna_Basla()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("SonLevel"));
    }
    public void settings()
    {
        SceneManager.LoadScene(1);
    }
    public void quit()
    {                                            // çýkmak istediðinizden eminsiniz penceresi yapýlacak !!!S
        Application.Quit();
    }
    public void kontrol_et_Ve_Tanimla()
    {
        if (!PlayerPrefs.HasKey("SonLevel"))
        {
            PlayerPrefs.SetInt("SonLevel", 2);
            PlayerPrefs.SetFloat("Menuses", 1);
            PlayerPrefs.SetFloat("oyunses", 1);

        }
    }
}
