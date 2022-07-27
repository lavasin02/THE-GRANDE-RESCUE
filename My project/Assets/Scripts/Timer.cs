using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour
{
   // bool timeActive=false;
    float currentTime;
    public int StartMinutes;
    public Text currentTimeText;
    public GameObject GameOverggUI;
    private void Start(){
        currentTime=StartMinutes * 60;
    }
    private void Update(){
        currentTime=currentTime-Time.deltaTime;
        if(currentTime<=0){
        Cursor.lockState=CursorLockMode.None;
             GameOverggUI.SetActive(true);
        }
        TimeSpan time =TimeSpan.FromSeconds(currentTime);
        currentTimeText.text=time.Minutes.ToString()+":"+time.Seconds.ToString();
    }

}
