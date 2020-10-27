using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainJogo : MonoBehaviour {
	public Text cremeColetado;

    public Image[] asd;
	public static Personagem personagemSelecionado;

	void Update(){
		cremeColetado.text = "" + CremeColetor.cremeDisponivel;
	}
	/*
	public static void setPersonagemSelecionado(InfoPersonagem p){
		personagemSelecionado = p;
		Debug.Log ("Menu per: " + p.name + "perco: " + p.preco);
	}

	public static InfoPersonagem getPersonagemSelecionado(){
		return personagemSelecionado;
	}*/

}
