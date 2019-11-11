using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SessaoLingua : MonoBehaviour {

	private bool isVazio;

	void Start(){
		isVazio = true;
	}

	void OnMouseUpAsButton(){
		if (MainJogo.personagemSelecionado != null && isVazio) {
			Instantiate (MainJogo.personagemSelecionado.gameObject, transform.position, Quaternion.identity);
			CremeColetor.cremeDisponivel -= MainJogo.personagemSelecionado.preco;
			MainJogo.personagemSelecionado = null;
			isVazio = false;
		}
	}
}
