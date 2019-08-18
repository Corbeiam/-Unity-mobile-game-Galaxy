using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CtrGame : MonoBehaviour {

    public Text pointsText;
    public Text pointsHiText;

    public float points = 0;

    public Text pointsMaxText;

    void Start ()
    {
        float hiscore = PlayerPrefs.GetFloat("hiscore");
        pointsMaxText.text = "" + hiscore;
    }
	
	
	void Update ()
    {
        pointsText.text = "" + points;
    }

    void FixedUpdate()
    {
        if (Player.lose == false)
        {
            points = points + 1;
        }
        else
        {
            float hiscore = PlayerPrefs.GetFloat("hiscore");
            if (points > hiscore)
            {
                PlayerPrefs.SetFloat("hiscore", points);
            }
            pointsHiText.text = "MAX " + hiscore;
        }
    }

}
