using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HighScore3 : GameManager
{
    int highscoreeee;
    public Text Scoretxt, highscoreeeetxt;

    // Start is called before the first frame update
    void Start()
    {
        highscoreeee = PlayerPrefs.GetInt("3RdScore: ", highscoreeee);
    }

    // Update is called once per frame
    void Update()
    {
        //Scoretxt.text = "Score:" + score.ToString();
        highscoreeeetxt.text = highscoreeee.ToString();
        if (score > highscoreeee)
        {
            highscoreeee = score;
            PlayerPrefs.SetInt("3RdScore: ", highscoreeee);
            PlayerPrefs.Save();
        }
       
    }
}

