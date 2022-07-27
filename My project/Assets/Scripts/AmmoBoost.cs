using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBoost : MonoBehaviour
{
    [Header("AmmoBoost")]
    public Rifle rifle;
    private int magTogive=20;
    private float radius=2.5f;

    [Header("healthBox sound")]
    public AudioClip AmmoBoostSound;
    public AudioSource audioSource;
    private void Update(){
        if(Vector3.Distance(transform.position,rifle.transform.position)<radius){
            rifle.mag=magTogive;
            audioSource.PlayOneShot(AmmoBoostSound);
            Object.Destroy(gameObject,1.5f);
        }
    }

}
