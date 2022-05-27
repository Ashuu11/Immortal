using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HighScore4 : GameManager
{
    int highscoreeeer;
    public Text Scoretxt, highscoreeeertxt;

    // Start is called before the first frame update
    void Start()
    {
        highscoreeeer = PlayerPrefs.GetInt("4RdScore: ", highscoreeeer);
    }

    // Update is called once per frame
    void Update()
    {
        //Scoretxt.text = "Score:" + score.ToString();
        highscoreeeertxt.text = highscoreeeer.ToString();
        if (score > highscoreeeer)
        {
            highscoreeeer = score;
            PlayerPrefs.SetInt("4RdScore: ", highscoreeeer);
            PlayerPrefs.Save();
        }
        
    }
}

