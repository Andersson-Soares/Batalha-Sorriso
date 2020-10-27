using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesControle : MonoBehaviour {

    private int numeroScene;

    private void Awake() {
        if(SceneManager.GetActiveScene().name.StartsWith("Nivel"))
        {
            numeroScene = int.Parse(SceneManager.GetActiveScene().name.Substring(5));
            
        }
    }

	public void irParaScenne(string nomeScenne)
    {
        SceneManager.LoadScene(nomeScenne);
    }

    public int GetNivel(){
        Debug.Log(numeroScene);
        return numeroScene;
    }

}
