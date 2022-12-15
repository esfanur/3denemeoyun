using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puanislem : MonoBehaviour
{
    gamemanager Gamemanager;
    public GameObject say, say2, say3;
    private void Awake()
    {
        Gamemanager = Object.FindObjectOfType<gamemanager>();
    }
    private void Start()
    {
        say.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
        say2.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
        say3.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            other.GetComponent<MeshRenderer>().materials = this.GetComponent<MeshRenderer>().materials;
            Destroy(gameObject);
            Gamemanager.skorartir();
            
        }
    }
    private void Update()
    {
        transform.Rotate(180 * Time.deltaTime, 0f, 0f);
    }
}
