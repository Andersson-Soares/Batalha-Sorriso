using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CremeColetor : MonoBehaviour {

	public static int cremeDisponivel = 100;

	void OnMouseDown(){
		cremeDisponivel += 25;
        print(cremeDisponivel);
		GerenciaAudio.instance.SonsFXToca (0);
		Destroy (gameObject);
	}
}
