using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeletorPersonagem : MonoBehaviour {

	public Personagem personagemSelecionado;

	public void Clicado(){
		if(CremeColetor.cremeDisponivel >= personagemSelecionado.preco){
			MainJogo.personagemSelecionado = personagemSelecionado;
		}
	}

}
