using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dramatic : MonoBehaviour
{ public AudioSource saw;
        
    void Start()
    {
        saw = GameObject.FindObjectOfType<AudioSource>();
    }

    void Update()
    {
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            saw.Play();
            Debug.Log("Nurrrr");
        }
    }
}
