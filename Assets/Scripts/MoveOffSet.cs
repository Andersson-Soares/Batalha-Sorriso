using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOffSet : MonoBehaviour {

	public Material currentMaterial;
	public float speed;
	private float offSet;

	// Update is called once per frame
	void Update () {
		offSet += speed * Time.deltaTime;
		currentMaterial.SetTextureOffset ("_MainTex", new Vector2 (offSet, 0));
	}
}
