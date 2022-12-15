using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{

    public TMP_Text skor_text;
    public TMP_Text skorr_text;
    public int skor = 0;
    public GameObject panel;
   
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
       
    }
    public void panelislem()
    {
        panel.SetActive(true);
        skor_text.text = "SKOR: " + skor;
    }

    public void restartbtn()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;

    }
    public void cikis()
    {
        Application.Quit();
    }
    public void skorartir()
    {
        skor++;
        skorr_text.text = "SKOR: " + skor;
    }
}
