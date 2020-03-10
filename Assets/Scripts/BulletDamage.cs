using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    [SerializeField]
    private float dano;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Carie")
        {
            col.GetComponent<Life>().doDamage(dano);
            GerenciaAudio.instance.SonsFXToca (1);
            Destroy(gameObject);
        }
    }
}
