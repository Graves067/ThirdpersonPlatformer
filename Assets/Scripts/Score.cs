using UnityEngine;
using TMPro;
using System;
using UnityEngine.Events;

public class Score : MonoBehaviour
{

    public UnityEvent Collect = new();
    public bool isCollect = false;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider triggeredObject)
    {
            isCollect = true;
            Collect.Invoke();
            Destroy(gameObject);
    }

}
