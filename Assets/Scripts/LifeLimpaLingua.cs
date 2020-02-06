using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeLimpaLingua : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D outros)
    {
        if(outros.gameObject.CompareTag("Carie"))
        {
                Destroy(outros.gameObject);
        }

    }
}
