using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CremeColetor : MonoBehaviour {

	public static int cremeDisponivel = 100;

	public float timer;
	private float currentTime = 0;

	void Update()
	{
		currentTime += Time.deltaTime;
		if(currentTime >= timer)
		{
			currentTime = 0;
			Destroy(gameObject);
		}
	}

	void OnMouseDown(){
		cremeDisponivel += 25;
        print(cremeDisponivel);
		GerenciaAudio.instance.SonsFXToca (0);
		Destroy (gameObject);
	}

}
