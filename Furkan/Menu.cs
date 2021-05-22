using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField]
    private GameObject mainMenu;

    [SerializeField]
    private GameObject optionsMenu;
   
   public void PlayGame()
   {
       SceneManager.LoadScene("Game1");
   }

    public void Options()
    {
        SceneManager.LoadScene("Ayarlar");

    }
    
    public void back()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
