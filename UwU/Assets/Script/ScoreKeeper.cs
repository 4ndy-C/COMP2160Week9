using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
public int pointsPerPickup; 
private int currentScore; 

    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0; 
    }

    public void IncreaseScore(){
        currentScore += pointsPerPickup; 
    }

    public int CurrentScore
    {
        get 
        {
            return currentScore; 
        }
    }
}
