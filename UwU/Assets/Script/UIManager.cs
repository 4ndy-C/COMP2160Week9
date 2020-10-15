using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class UIManager : MonoBehaviour
{
    public Text score; 
    public ScoreKeeper scoreKeeper; 
    private string currentScore; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentScore = scoreKeeper.CurrentScore.ToString(); 
        score.text = currentScore; 
    }
}
