using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiparoControle : MonoBehaviour
{
    public GameObject prefab;
    public float interval = 0.5f;

    void Start()
    {
        InvokeRepeating("Shoot", 0, interval);
    }

    private void Shoot()
    {
        if (zombieInFrond())
        {
            GetComponent<Animator>().SetBool("Atirando",true);
            Instantiate(prefab, new Vector3(transform.position.x + 0.739f,transform.position.y - 0.094f), Quaternion.identity);
            
        }else if (!zombieInFrond())
        {
            GetComponent<Animator>().SetBool("Atirando", false);
        }
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