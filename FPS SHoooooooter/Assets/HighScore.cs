using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HighScore : GameManager
{
    int highscorer;
    public Text Scoretxt, highscoretxt;

    // Start is called before the first frame update
    void Start()
    {
        
        highscorer = PlayerPrefs.GetInt("firstScore: ", highscorer);
    }

    // Update is called once per frame
    void Update()
    {
        //Scoretxt.text = "Score:" + score.ToString();
        highscoretxt.text = highscorer.ToString();
        if (score > highscorer)
        {
            highscorer = score;
            PlayerPrefs.SetInt("firstScore: ", highscorer);
            PlayerPrefs.Save();
        }
       
    }
}

