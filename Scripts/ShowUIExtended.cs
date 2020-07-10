using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShowUIExtended : MonoBehaviour
{

    public GameObject uiObject;
    public GameObject uiObjectPanel;
    public GameObject UIObjectHide;
    public GameObject UIObjectHide2;
    public GameObject UIObjectHide3;
    public GameObject UIObjectHide4;
    public GameObject UIObjectHide5;

    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(false);
        UIObjectHide.SetActive(false);
        
    }

    void OnTriggerEnter (Collider player)
    {
        if (player.gameObject.tag == "Player")
            {
                uiObject.SetActive(true);
                uiObjectPanel.SetActive(true);
                UIObjectHide.SetActive(false);   // hiding all other text ui upon colliding with this specific object. stops overlapping text.
                UIObjectHide2.SetActive(false);
                UIObjectHide3.SetActive(false);
                UIObjectHide4.SetActive(false);
                UIObjectHide5.SetActive(false);
                StartCoroutine("WaitForSec");
            }

    }
        
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(40);
        Destroy(uiObject);
        Destroy(gameObject);
    }

}