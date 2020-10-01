using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CremeSpawn : MonoBehaviour
{

    public GameObject prefab;
    public int tempoSpawn;

    void Start()
    {
        InvokeRepeating("Spawn", tempoSpawn, tempoSpawn);

    }

    public void Spawn()
    {
        Vector3 aux = new Vector3(transform.position.x + Random.Range(-0.5f,0.5f), transform.position.y + Random.Range(-0.5f, 0.5f), transform.position.z - 1);
        Instantiate(prefab, aux, Quaternion.identity);

    }
}
