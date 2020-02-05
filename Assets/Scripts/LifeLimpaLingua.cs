using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeLimpaLingua : MonoBehaviour
{
    
    void OnCollisionEnter2D(Collision2D outros)
    {
        if(outros.gameObject.CompareTag("Carie"))
        {
            transform.Translate (new Vector3(0.5f,0,0));

            Destroy(outros.gameObject);
        }

    }
}
