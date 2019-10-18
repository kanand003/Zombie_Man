using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDamageSystem : MonoBehaviour
{
    public GameObject zombie;
    public int startingHealth = 100;                            // The amount of health the player starts the game with.
    public static int currentHealth;

    // Update is called once per frame

    void Awake()
    {
        startingHealth = currentHealth; 
    }
    public void Start()
    {
        startingHealth = 100;
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject==zombie)
        {
            startingHealth = startingHealth - 10;
            Debug.Log(startingHealth);
        }
    }
}
