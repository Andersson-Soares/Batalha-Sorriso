using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 2;
    [SerializeField]
    private int dano = 1;

    private Rigidbody2D body;

    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.x - 0.5f > GameObject.Find("QuadradoBase (42)").transform.position.x)
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(velocidade, 0);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Carie")
        {
            col.GetComponent<Carie>().doDamage(dano);
            GerenciaAudio.instance.SonsFXToca(1);
            Destroy(gameObject);
        }
    }
}
