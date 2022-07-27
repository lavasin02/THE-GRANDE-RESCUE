using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

public class playerInventory : MonoBehaviour
{
    //Header[("GAme over")]
    public GameObject GameOverUI;
    //public static playerInventory occurence;
    private TextMeshProUGUI diamondText;
    private void Awake(){
     //occurence = this;
         //diamondText=GetComponent<TextMeshProUGUI>();
    }
    public int NoOfDiamonds{get ;private set;}
    public UnityEvent<playerInventory> OnDiamondCollected;
    public void DiamondCollected(){
        NoOfDiamonds++;
        if(NoOfDiamonds==21){
             Cursor.lockState=CursorLockMode.None;
             GameOverUI.SetActive(true);
        }
        OnDiamondCollected.Invoke(this);
    }
   /* public void UpdateDiamondText(){
        diamondText.text=NoOfDiamonds+" ";
    }*/
}
