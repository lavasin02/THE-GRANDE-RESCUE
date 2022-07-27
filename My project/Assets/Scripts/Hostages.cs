using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Hostages : MonoBehaviour
{
    // Start is called before the first frame update
   private void OnTriggerEnter(Collider other)
   {
    playerInventory pi=other.GetComponent<playerInventory>();
    if(pi!=null){
        pi.DiamondCollected();
        gameObject.SetActive(false);
    }
   }
}
