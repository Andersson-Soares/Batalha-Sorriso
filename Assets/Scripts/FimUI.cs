using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FimUI : MonoBehaviour
{
    public GameObject losePainel;

    void Start()
    {
        losePainel.SetActive (false);
    }
    
    void OnCollisionEnter2D(Collision2D outros)
    {
        if(outros.gameObject.CompareTag("Carie"))
        {
            losePainel.SetActive (true);
        }
    }
}
