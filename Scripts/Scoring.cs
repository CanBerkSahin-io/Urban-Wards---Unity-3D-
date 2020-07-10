using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scoring : MonoBehaviour
{
    public GameObject scoreText;
    public static int theScore;
    public GameObject hazardText;
    public static int hazard;
    public GameObject hazardTextEndLevel;
    public GameObject scoreTextEndLevel;
    
    void Start()
    {
        hazard = 0;
        
    }
     
    void Update()
    {
            
            scoreText.GetComponent<Text>().text = "SCORE: " + theScore;

            hazardText.GetComponent<Text>().text = "HAZARDS FOUND: " + hazard + " / 4 ";

            hazardTextEndLevel.GetComponent<Text>().text = "HAZARDS FOUND: " + hazard + " / 4 ";
            
            scoreTextEndLevel.GetComponent<Text>().text = "SCORE: " + theScore;

    }

}
