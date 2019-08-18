using System.Collections;
using UnityEngine;

public class DontDestr : MonoBehaviour {

	/*void Start () {
        if (PlayerPrefs.GetString("Music") != "no")
        {
            DontDestroyOnLoad(gameObject);
        } else
        {
            Destroy(gameObject);
        }
    }*/



    void Update()
    {
        if (PlayerPrefs.GetString("Music") != "no")
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}