using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueLimpador : MonoBehaviour
{
   
    void OnCollisionEnter2D(Collision2D outros)
    {
        if(outros.gameObject.CompareTag("Carie"))
        {
           //transform.position = Vector3.Lerp (transform.position,new Vector3 (5,5,5), Time.deltaTime);
                Destroy(outros.gameObject);
        }

    }
}
