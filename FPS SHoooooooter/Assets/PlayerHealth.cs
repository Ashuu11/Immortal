using FPSControllerLPFP;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
    public float fullHealth;
    float currentHealth;
    public bool PlayerDied = false;
    public Canvas playerCanvas;
    public Slider playerHealthSlider;

    FpsControllerLPFP pController;
    // Start is called before the first frame update
    void Awake()
    {
        currentHealth = fullHealth;
        playerHealthSlider.minValue = 0;
        playerHealthSlider.maxValue = fullHealth;
        playerHealthSlider.value = currentHealth;

        pController = GetComponent<FpsControllerLPFP>();
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
    public void AddDamage(float damage)
    {
        currentHealth -= damage;
        playerHealthSlider.value = currentHealth;

        if (currentHealth <= 0)
        {
            PlayerDied = true;
            playerCanvas.enabled = false;
            pController.enabled = false;
            SceneManager.LoadScene("Health Game Over");
        }
    }

}
