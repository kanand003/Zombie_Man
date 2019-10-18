using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth2 : MonoBehaviour
{
    public int startingHealth = 100;                            // The amount of health the player starts the game with.
    public static int currentHealth;

    PlayerMovement playerMovement;                              // Reference to the player's movement.
    EnemyDamage enemyDamage;                  
    bool isDead;                                                // Whether the player is dead.
    bool damaged;

    void Awake()
    {        
        playerMovement = GetComponent<PlayerMovement>();
        enemyDamage = GetComponent<EnemyDamage>();
        currentHealth = startingHealth;// Set the initial health of the player.
    }
    // Update is called once per frame
    void Update()
    {
        if (damaged)
        {
            // ... set the colour of the damageImage to the flash colour.
            currentHealth = currentHealth - 10;
        }
        // Otherwise...
        else
        {
            // ... transition the colour back to clear.
         
        }

        // Reset the damaged flag.
        damaged = false;
    }
    public void TakeDamage(int amount)
    {
        // Set the damaged flag so the screen will flash.
        damaged = true;
        // Reduce the current health by the damage amount.
        currentHealth -= amount;
        if (currentHealth <= 0 && !isDead)
        {
            // ... it should die.
            Death();
        }
    }


    void Death()
    {
        // Set the death flag so this function won't be called again.
        isDead = true;

        // Turn off the movement and shooting scripts.
        playerMovement.enabled = false;

    }
}
