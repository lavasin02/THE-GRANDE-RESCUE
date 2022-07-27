using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class inventoryUI1 : MonoBehaviour
{
   public static inventoryUI1 occurence;
    private TextMeshProUGUI diamondText;
    private void Awake(){
        occurence = this;
         diamondText=GetComponent<TextMeshProUGUI>();
    }
    void start(){
       
    }
    public void UpdateDiamondText(playerInventory playerinventory){
        int p=21-playerinventory.NoOfDiamonds;
        diamondText.text=p.ToString();
    }
}
