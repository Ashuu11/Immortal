using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play : MonoBehaviour
{
     public void LoadSceneOnClick(int Scene1)
    {
        SceneManager.LoadScene(Scene1);
    }
}
