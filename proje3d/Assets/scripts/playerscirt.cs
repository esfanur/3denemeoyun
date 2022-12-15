using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscirt : MonoBehaviour
{

    Rigidbody rb;
    public float speed;
    hareketyon hr;
    public bool dead;
    gamemanager Gamemanager;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        hr = hareketyon.sol;
        dead = false;
        Gamemanager = Object.FindObjectOfType<gamemanager>();
    }
    private void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
       
        if (!dead)
        { //oyuncu yasýyorsa bu iþlemler gerceklescek
            raycestislem();
            //if (Input.GetKeyDown(KeyCode.Space))
            //{
            //    yonlendirme();

            //    oyundur();

            //}
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                yonlendirme();

                oyundur();
            }
            else
            {
                return;
            }

        }
       






       // mobilde
        


    }
    public void raycestislem()
    {
        //oyuncuu zemýndeyse oyun devam degilse oyun dursun dýyoruz.
        RaycastHit hit;
        if(Physics.Raycast(transform.position,Vector3.down,out hit))
        {
            oyunhar();
        }
        else
        {
            Gamemanager.panelislem();
            oyundur();
            dead = true;
            Time.timeScale = 0;

        }
    }
    public enum hareketyon
    {
        sag,
        sol
    }
    public void yonlendirme()
    {
        //oyunhar();
        if(hr==hareketyon.sag)
        {
            hr = hareketyon.sol;
        }
        else if(hr==hareketyon.sol)
        {
            hr = hareketyon.sag;
        }
    }
    public void oyunhar()
    {
        if(hr==hareketyon.sag)
        {
            rb.AddForce((Vector3.forward).normalized * speed * Time.deltaTime, ForceMode.VelocityChange);

        }
        else if(hr==hareketyon.sol)
        {
            rb.AddForce((Vector3.left).normalized * speed * Time.deltaTime, ForceMode.VelocityChange);
        }
      
    }
    private void oyundur()
    {
        rb.velocity = Vector3.zero;
    }
}
