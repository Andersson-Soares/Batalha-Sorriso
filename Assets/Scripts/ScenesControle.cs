using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesControle : MonoBehaviour {

	public void irParaScenne(string nomeScenne)
    {
        SceneManager.LoadScene(nomeScenne);
    }
}
