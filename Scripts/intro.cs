using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intro : MonoBehaviour
{
    public AudioSource collectSound;
    public GameObject UIObjectDelete;

    void OnTriggerEnter(Collider other)
    {
            Destroy(UIObjectDelete);
            collectSound.Play();
            
            
            
    }

   

}

