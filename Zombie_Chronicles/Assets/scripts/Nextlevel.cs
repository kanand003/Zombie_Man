using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Nextlevel : MonoBehaviour
{


    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "Potion")
        {
            SceneManager.LoadScene(4);
        }
    }
}