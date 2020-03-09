using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueLimpador : MonoBehaviour
{
    public float velocity;

    void OnCollisionEnter2D(Collision2D outros)
    {
        if(outros.gameObject.CompareTag("Carie"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(velocity, 0);
            Destroy(outros.gameObject);

            Destroy(gameObject, 12f);
        }
    }
}
