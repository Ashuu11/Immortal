using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerDamage : MonoBehaviour
{

    public float playerDamageAmount;
    public bool playerInRange = false;
    public DateTime nextDamage;
    public float damageAfterTime;

    public GameObject playerObj;
    // Start is called before the first frame update
    void Awake()
    {
        nextDamage = DateTime.Now;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (playerInRange == true)
        {
            DamagePlayer();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (other.gameObject.GetComponent<PlayerHealth>().PlayerDied == false)
            {
                playerObj = other.gameObject;
                playerInRange = true;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerInRange = false;
        }
    }

    public void DamagePlayer()
    {
        if (nextDamage <= DateTime.Now)
        {
            playerObj.GetComponent<PlayerHealth>().AddDamage(playerDamageAmount);
            nextDamage = DateTime.Now.AddSeconds(System.Convert.ToDouble(damageAfterTime));
        }
    }

}
