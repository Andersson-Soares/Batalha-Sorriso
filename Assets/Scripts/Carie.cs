using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carie : MonoBehaviour
{
    [SerializeField]
    private float vida;

    public GameObject efeitoMorte;

    [SerializeField]
    private float latencia;

    [SerializeField]
    private float dano;

    private float currentTime = 0;

    [SerializeField]
    private float velocity;

    private Rigidbody2D body;

    void Start() 
    {
        body = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        body.velocity = new Vector2(velocity, 0);
    }

    public void doDamage(float dano)
    {
        vida -= dano;
        if (vida <= 0)
        {
            GameObject objMorte = Instantiate(efeitoMorte, transform.position, transform.rotation);
            GerenciaAudio.instance.SonsFXToca (2);
            Destroy(objMorte, 0.4f);
            Destroy(gameObject);
        }
    }

    void onCollisionEnter2D(Collision2D other)
    {
        Debug.Log(other.gameObject.tag);
        if(other.gameObject.tag == "Limpadores")
        {
            currentTime += Time.deltaTime;
            if(currentTime >= latencia)
            {
                currentTime = 0;
                Debug.Log("estou batendo no personagem");
                other.gameObject.GetComponent<Personagem>().doDamage(dano);
            }
        }
        else if(other.gameObject.name == "Fim")
        {
            print("Fim do Game");
            Destroy(gameObject);
        }
    }
}
