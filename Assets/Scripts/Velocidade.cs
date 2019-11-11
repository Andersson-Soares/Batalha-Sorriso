using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocidade : MonoBehaviour
{
    [SerializeField]
    private float velocity;

    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(velocity, 0);
    }
}
