using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{

    public int preco;

    public GameObject posicao;

    [SerializeField]
    private float vida;

    public GameObject efeitoMorte;

    public GameObject prefab;

    public float interval;

    private float currentTime = 0;

    private float timerCreme = 0;

    void Update()
    {
        if (gameObject.name.Contains("Tubo"))
        {
            timerCreme += Time.deltaTime;
            if (timerCreme >= interval)
            {
                timerCreme = 0;
                Spawn();
            }
        }
        else if (zombieInFrond())
        {
            currentTime += Time.deltaTime;
            if (currentTime >= interval)
            {
                currentTime = 0;
                GetComponent<Animator>().SetBool("Atirando", true);
                Shoot();
            }
        }
        else if (!zombieInFrond())
        {
            currentTime = 0;
            GetComponent<Animator>().SetBool("Atirando", false);
        }
    }

    public void doDamage(float dano)
    {
        vida -= dano;
        if (vida <= 0)
        {
            GameObject EfeitoMorte = Instantiate(efeitoMorte, transform.position, transform.rotation);
            GerenciaAudio.instance.SonsFXToca(2);
            Destroy(EfeitoMorte, 1f);
            posicao.transform.GetComponent<SessaoLingua>().isVazio = true;
            Destroy(gameObject);
        }
    }

    private void Shoot()
    {
        Instantiate(prefab, new Vector3(transform.position.x + 0.739f, transform.position.y - 0.094f), Quaternion.identity);
    }

    private void Spawn()
    {
        Vector3 aux = new Vector3(transform.position.x + Random.Range(-0.5f, 0.5f), transform.position.y + Random.Range(-0.5f, 0.5f), transform.position.z - 1);
        Instantiate(prefab, aux, Quaternion.identity);
    }

    private bool zombieInFrond()
    {
        Vector2 origen = new Vector2(6.5f, transform.position.y);
        RaycastHit2D[] hits = Physics2D.RaycastAll(origen, -Vector2.right);

        foreach (RaycastHit2D hit in hits)
        {
            if (hit.collider != null && hit.collider.tag == "Carie")
            {
                return true;
            }
        }
        return false;
    }
}
