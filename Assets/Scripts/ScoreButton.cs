using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreButton : MonoBehaviour
{
    public Button scoreButton;
    public int score = 0;
    public Action<int> OnScoreChanged;

    private void Awake()
    {
        scoreButton = GetComponent<Button>();
        scoreButton.onClick.AddListener(PointUp);
    }

    void PointUp() 
    {
        score += 1;
        OnScoreChanged?.Invoke(score);
    }
}
