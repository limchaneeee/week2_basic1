using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public ScoreButton scoreButton;
    public TextMeshProUGUI scoreTxt;

    private void Awake()
    {
        scoreButton.OnScoreChanged += RefreshUI;
    }

    void Start()
    {
        scoreTxt = GetComponent<TextMeshProUGUI>();
    }


    void RefreshUI(int newScore)
    {
        scoreTxt.text = newScore.ToString();
    }
}
