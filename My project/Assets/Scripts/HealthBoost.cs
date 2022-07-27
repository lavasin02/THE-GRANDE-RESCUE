using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBoost : MonoBehaviour
{
    [Header("HealthBoost")]
    public PlayerScript player;
    private float healthTogive=1200f;
    private float radius=2.5f;

    [Header("healthBox sound")]
    public AudioClip HealthBoostSound;
    public AudioSource audioSource;
    private void Update(){
        if(Vector3.Distance(transform.position,player.transform.position)<radius){
            player.presentHealth=healthTogive;
            audioSource.PlayOneShot(HealthBoostSound);
            Object.Destroy(gameObject,1.5f);
        }
    }

}
