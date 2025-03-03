using TMPro;
using UnityEngine;
using System;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreManager : MonoBehaviour
{
    private Score[] Coins;
    [SerializeField] private int score = 0;
    [SerializeField] private TextMeshProUGUI scoreText;
    private void Start()
    {
        Coins = FindObjectsByType<Score>((FindObjectsSortMode)FindObjectsInactive.Include);

        foreach (Score Coins in Coins)
        {
            Coins.Collect.AddListener(IncrimentScore);
        }
    }
    public void IncrimentScore()
    {
        score++;
        scoreText.text = $"Score: {score}";
    }
}
