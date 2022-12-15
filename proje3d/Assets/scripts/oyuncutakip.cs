using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyuncutakip : MonoBehaviour
{
    public Transform oyuncu;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        transform.position = oyuncu.position;
    }
}
