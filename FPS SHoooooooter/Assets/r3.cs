using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class r3 : MonoBehaviour
{
    public void LoadSceneOnClick(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
