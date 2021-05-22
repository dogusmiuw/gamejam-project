using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    
   
   public void PlayGame()
   {
       SceneManager.LoadScene("Game");
   }

    public void Options()
    {
        SceneManager.LoadScene("Ayarlar");

    }
    
    public void back()
    {
        SceneManager.LoadScene("Game");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
