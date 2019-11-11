using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    [SerializeField]
    private float tamanhoVida;

    public void doDamage(float n)
    {
        tamanhoVida -= n;
        if (tamanhoVida <= 0)
        {
            Destroy(gameObject);
        }
    }
}
