using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

    public GameObject m_on, m_off;
    public GameObject pPause;


    // Звук 
    public GameObject musicBG;


    
    void Start()
    {
        if (gameObject.name == "Music")
        {
            if (PlayerPrefs.GetString("Music") == "no")
            {
                m_on.SetActive(false);
                m_off.SetActive(true);
                AudioListener.volume = 0;
            }
            else
            {
                m_on.SetActive(true);
                m_off.SetActive(false);
                AudioListener.volume = 1;
            }
        }
    }

    void OnMouseUpAsButton()
    {
        if (PlayerPrefs.GetString("Music") != "no")
            GameObject.Find("Click Audio").GetComponent<AudioSource>().Play();
        switch (gameObject.name)
        {
            case "Play":
                SceneManager.LoadScene("play");
                break;
            case "Pause":
                if (Time.timeScale == 0)
                {
                    Time.timeScale = 1;
                    pPause.SetActive(false);
                }
                else if (Time.timeScale == 1)
                {
                    Time.timeScale = 0;
                    pPause.SetActive(true);
                }
                break;
            case "Shop":
                Application.OpenURL("http://google.com");
                break;
            case "Reboot":
                SceneManager.LoadScene("play");
                break;
            case "Home":
                SceneManager.LoadScene("main");
                break;
            case "Close":
                SceneManager.LoadScene("main");
                break;
            case "Exit":
                Application.Quit();
                break;
            case "Music":
                if (PlayerPrefs.GetString("Music") != "no")
                {
                    PlayerPrefs.SetString("Music", "no");
                    m_on.SetActive(false);
                    m_off.SetActive(true);
                    AudioListener.volume = 0;
                }
                else
                {
                    PlayerPrefs.SetString("Music", "yes");
                    m_on.SetActive(true);
                    m_off.SetActive(false);
                    AudioListener.volume = 1;
                }
            break;
        }
    }
}
