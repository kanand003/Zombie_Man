using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthDamageSystem : MonoBehaviour
{
    public GameObject z0,z1,z2,z3,z4,z5,z6,potion;
    public int startingHealth = 100;
    public int currentHealth;
    public SimpleHealthBar healthBar;

    // Update is called once per frame


    public void Start()
    {
        startingHealth = 100;
        currentHealth = startingHealth;
        healthBar.UpdateBar(startingHealth,currentHealth);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (startingHealth <= 0)
        {
            SceneManager.LoadScene("Lose");
        }
        else if (collision.gameObject == potion)
        {
            SceneManager.LoadScene("Win");

        }
       else if (collision.gameObject==z0)
        {
            startingHealth = startingHealth - 10;
            Debug.Log(startingHealth);
        }
        
        else if (collision.gameObject == z1)
        {
            startingHealth = startingHealth - 10;
            Debug.Log(startingHealth);
        }
        else if (collision.gameObject == z2)
        {
            startingHealth = startingHealth - 10;
            Debug.Log(startingHealth);
        }
        else if (collision.gameObject == z3)
        {
            startingHealth = startingHealth - 10;
            Debug.Log(startingHealth);
        }
        else if (collision.gameObject == z4)
        {
            startingHealth = startingHealth - 10;
            Debug.Log(startingHealth);
        }
        else if (collision.gameObject == z5)
        {
            startingHealth = startingHealth - 10;
            Debug.Log(startingHealth);
        }
        else if (collision.gameObject == z6)
        {
            startingHealth = startingHealth - 10;
            Debug.Log(startingHealth);
        }
        healthBar.UpdateBar(100,startingHealth);

    }
   
}
