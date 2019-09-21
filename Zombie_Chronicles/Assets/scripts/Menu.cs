using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
   public void newgame()
     {
        SceneManager.LoadScene("loading");
     }


   public void instructions()
     {
        SceneManager.LoadScene("instructions");
     }


   public void back()
     {
        SceneManager.LoadScene("Menu");
     }


   public void quit()
     {
        Application.Quit();
     }

}
