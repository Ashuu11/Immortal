using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HighScore2 : GameManager
{
    
    int highscoree;
    public Text Scoretxt, highscoreetxt;

    // Start is called before the first frame update
    void Start()
    {
        highscoree = PlayerPrefs.GetInt("2ndScore: ", highscoree);
    }

    // Update is called once per frame
    void Update()
    {
        //Scoretxt.text = "Score:" + score.ToString();
        highscoreetxt.text = highscoree.ToString();
        if (score > highscoree)
        {
            highscoree = score;
            PlayerPrefs.SetInt("2ndScore: ", highscoree);
            PlayerPrefs.Save();
        }
        
    }
}

