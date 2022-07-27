using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public GameObject mainMenu; 
   public void OnPlayButton(){
    SceneManager.LoadScene("GrandeRescue");
   }
   public void OnQuitButton(){
    Debug.Log("Quitting...");
    Application.Quit();
   }
}
