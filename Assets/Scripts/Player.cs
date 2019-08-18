using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public static bool lose = false;


    // Взрыв
    public GameObject explosion;
    public GameObject explosionPlayer;

    // Панель проигрыша
    public GameObject pLost;


    void Awake()
    {
        lose = false;
        Time.timeScale = 1;
    }




    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Asteroid")
        {
            lose = true;
            Instantiate(explosion, GetComponent<Rigidbody2D>().position, Quaternion.identity);

            pLost.SetActive(true);

            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        if (PlayerPrefs.GetString("Music") == "no")
        {
            pLost.GetComponent<AudioSource>().mute = true;
        }

        if (other.gameObject.tag == "Player")
        {
            Instantiate(explosion, GetComponent<Rigidbody2D>().position, Quaternion.identity);

            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }

}
