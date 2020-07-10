using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectObject : MonoBehaviour
{
    public AudioSource collectSound;
     private bool hasCollide = false;

    void OnTriggerEnter(Collider other)
    {
        if(hasCollide == false)//   if the player has collided before then do not apply the code below, if not collided before, apply those.
            {
                hasCollide = true;//
                collectSound.Play();
                Scoring.theScore += 115;
                Scoring.hazard += 1;
            }
            
    }

   

}
