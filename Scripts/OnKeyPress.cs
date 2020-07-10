using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnKeyPress : MonoBehaviour
{
    public GameObject uiObject;
    public GameObject gameObject;
    public GameObject uiObjectPanel;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.Space))
        {
            
            Destroy(uiObject);
            Destroy(gameObject);
            uiObjectPanel.SetActive(false);

            
        }
    }
}

