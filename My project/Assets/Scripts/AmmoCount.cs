using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AmmoCount : MonoBehaviour
{
    public Text ammunationText;
    public Text magText;
    public static AmmoCount occurence;
    private void Awake(){
        occurence = this;
    }
    public void UpdateAmmoText(int presentAmmo){
       ammunationText.text="Ammo." + presentAmmo;
    }
    public void UpdateMagText(int mag){
     magText.text="Magazines." + mag;
    }
}
