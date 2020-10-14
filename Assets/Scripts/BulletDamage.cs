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

    void Update()
    {
        if(gameObject.transform.position.x - 0.5f > GameObject.Find("QuadradoBase (42)").transform.position.x)
        {
            Destroy(gameObject);
        }
    }
}
