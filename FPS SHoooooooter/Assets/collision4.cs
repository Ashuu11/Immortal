using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class collision4 : GameManager
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     
    private void OnCollisionEnter(Collision collision)

    {
        if (collision.gameObject.tag == "i")
        {
            SceneManager.LoadScene("Demo_01");
        }
    }
}
