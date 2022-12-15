using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class son : MonoBehaviour
{
    public GameObject panel;
    gamemanager Gamemanager;
    private void Awake()
    {
        Gamemanager = Object.FindObjectOfType<gamemanager>();
    }
    private void Start()
    {
        panel.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            panel.SetActive(true);
            Gamemanager.panel.SetActive(false);
            Time.timeScale = 0f;
            
        }
    }
}
