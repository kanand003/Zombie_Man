using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class disappear : MonoBehaviour
{
    public float time = 7.5f; //Seconds to read the text
    //public GameObject gameObjec;
    public Text T1,T2,T3;
    void Start()
    {
        Destroy(T1, time);
        Destroy(T2, time);
        Destroy(T3, time);
    }


}
