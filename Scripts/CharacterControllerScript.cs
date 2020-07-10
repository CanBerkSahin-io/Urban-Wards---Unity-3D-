using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerScript : MonoBehaviour
{

    //public Interactable focus;
    // Start is called before the first frame update
    public float speed = 10.0F;
    void Start()
    {
        Time.timeScale = 1f;
        Cursor.lockState= CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;

        transform.Translate(straffe, 0, translation);

        if (Input.GetKeyDown("escape"))
            Cursor.lockState= CursorLockMode.None;   // if escape key is pressed, the cursor will be unlocked
            //if right mouse button is pressed
        if (Input.GetMouseButtonDown(1))
        {
            //creating a ray

            //if the ray hits
        
            {
                //check if we hit an interactablel)
                {
                    //add command to include text box and sound effect
                    
                }
            }
        }
    }
    
}


