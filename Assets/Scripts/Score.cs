using UnityEngine;
using TMPro;
using System;
using UnityEngine.Events;

public class Score : MonoBehaviour
{
    [SerializeField] private float score = 0;
    [SerializeField] private TextMeshProUGUI scoreText;
    public UnityEvent Collect = new();
    public bool isCollected = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider triggeredObject)
    {
        isCollected = true;
        IncrimentScore();
        
    }

    private void IncrimentScore()
    {
        score++;
        scoreText.text = $"Score: {score}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
