using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    [Header("All Menu's")]
    public GameObject pauseMenuUI;
    public GameObject EndGameMenuUI;
    public GameObject ObjectiveMenuUI;
    public GameObject GameOverUI;
    public static bool GameISStopped =false;
    private void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(GameISStopped){
                Resume();
                Cursor.lockState=CursorLockMode.Locked;
            }else{
                Pause();
                Cursor.lockState=CursorLockMode.None;
            }
        }else if(Input.GetKeyDown("m")){
            if(GameISStopped){
                removeObjectives();
                Cursor.lockState=CursorLockMode.Locked;
            }else{
                showObjectives();
                Cursor.lockState=CursorLockMode.None;
            }
        }
        
    }
    public void showObjectives(){
        EndGameMenuUI.SetActive(true);
        Time.timeScale=0f;
        GameISStopped =true;
    }
    public void removeObjectives(){
EndGameMenuUI.SetActive(false);
        Time.timeScale=1f;
        Cursor.lockState=CursorLockMode.Locked;
        GameISStopped =false;
    }
    public void Resume(){
        pauseMenuUI.SetActive(false);
        Time.timeScale=1f;
        Cursor.lockState=CursorLockMode.Locked;
        GameISStopped =false;
    }
    public void Restart(){
        SceneManager.LoadScene("ZombieLand");
    }
    public void LoadMenu(){
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitGame(){
        Debug.Log("Quitting Game...");
        Application.Quit();
    }
    void Pause(){
       pauseMenuUI.SetActive(true);
        Time.timeScale=0f;
        GameISStopped =true;
    }
}
