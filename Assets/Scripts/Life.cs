using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    [SerializeField]
    private float tamanhoVida;

    public GameObject EfeitoMorte;

    public void doDamage(float n)
    {
        tamanhoVida -= n;
        if (tamanhoVida <= 0)
        {
            GameObject efeitoMorte = Instantiate(EfeitoMorte, transform.position, transform.rotation);
            GerenciaAudio.instance.SonsFXToca (2);
            Destroy(efeitoMorte, 0.4f);
            Destroy(gameObject);
        }
    }
}
