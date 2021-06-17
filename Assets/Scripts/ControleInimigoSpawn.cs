using UnityEngine;

public class ControleInimigoSpawn : MonoBehaviour
{

    public GameObject[] inimigo;
    public float tempoSpawn;
    public float variacaoTempoSpawn;
    public GameObject[] posicoes;

    private float proximoSpawn;
    private float tempoAtual;
    private float y;
    private float menorTempo;
    private float maiorTempo;

    void Start()
    {
        tempoAtual = 0;
        menorTempo = (tempoSpawn - variacaoTempoSpawn) * 1000;
        maiorTempo = (tempoSpawn + variacaoTempoSpawn) * 1000;
    }

    void Update()
    {
        tempoAtual += Time.deltaTime;
        if (tempoAtual >= proximoSpawn)
        {
            spawnar();
        }
    }

    private void spawnar()
    {
        tempoAtual = 0;
        proximoSpawn = Random.Range(menorTempo, maiorTempo) / 1000f;
        y = (posicoes[Random.Range(0, posicoes.Length)]).transform.position.y;
        GameObject tempPrefab = Instantiate(inimigo[Random.Range(0,inimigo.Length)]) as GameObject;
        tempPrefab.transform.position = new Vector3(transform.position.x, y, tempPrefab.transform.position.z);
    }
}
