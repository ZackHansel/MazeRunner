using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public AudioSource src;
  
    public void OnCollisionEnter(Collision collision)
    {
    if(collision.gameObject.tag=="Player")
        {
            src.Play();
        }
    }
}
