using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathSound : MonoBehaviour
{
    
    [SerializeField] private AudioSource deathSoundEffect;


    private void OnTriggerEnter2D(Collider2D coll)
    {
       if (coll.gameObject.tag == "Trap")
            deathSoundEffect.Play();
    }
}

