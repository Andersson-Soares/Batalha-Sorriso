using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TempoFase : MonoBehaviour
{

    Image BarraQuanTime;
    public float maxTime = 60f;
    float timeLeft;
    public GameObject winPainel;
    
    
    void Start()
    {
        winPainel.SetActive (false);
        BarraQuanTime = GetComponent<Image> ();
        timeLeft = maxTime;

    }

    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            BarraQuanTime.fillAmount = timeLeft / maxTime;
        }
        else{
            winPainel.SetActive (true);
            Time.timeScale = 0;
        }
    }
}
