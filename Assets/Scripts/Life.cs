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
            //se nesse gameObject tem o componente infoPersonagem (que só existe nos personagens)
            if(GetComponent<InfoPersonagem>() != null){
                //entao pego o quadrado em que ele está e digo que ele está vazio antes de destruir este gameObject
                GetComponent<InfoPersonagem>().quadradoCampoBatalha.transform.GetComponent<SessaoLingua>().isVazio = true;
            }
            Destroy(gameObject);
        }
    }
}
