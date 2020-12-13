using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayScore : MonoBehaviour
{
    public TextMeshProUGUI Score;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        score = ScoreManager.Score;
        Score.text = "Your Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
