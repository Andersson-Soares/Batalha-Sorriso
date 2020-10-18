using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeletorPersonagem : MonoBehaviour {

	public Personagem personagemSelecionado;

	public void Clicado(){

		Debug.Log(CremeColetor.cremeDisponivel);

		Debug.Log(personagemSelecionado.gameObject.name);
		
		if(CremeColetor.cremeDisponivel >= personagemSelecionado.preco){
			MainJogo.personagemSelecionado = personagemSelecionado;
		}
	}

}
