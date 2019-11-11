using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtequeCarie : MonoBehaviour
{
    [SerializeField]
    private float latencia;

    [SerializeField]
    private float dano;

    private float currentTime = 0;
   
    void OnCollisionStay2D(Collision2D con)
    {
        if (con.gameObject.tag == "Limpadores")
        {
            //GetComponent<Animator> ().SetTrigger ("isAttacking");
            if ((currentTime += Time.deltaTime) >= latencia)
            {
                con.gameObject.GetComponent<Life>().doDamage(dano);
                currentTime = 0;
            }
        }
        else if (con.gameObject.name == "Fim")
        {
            print("Fim do game");
            Destroy(gameObject);
        }
    }
}
