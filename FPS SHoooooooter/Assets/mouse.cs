using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        unlockmouse();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void unlockmouse()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
