using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreViewer : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.OnScoreGained += UpdateScore;
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    private void UpdateScore(int score)
    {
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
