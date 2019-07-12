using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AplastadoraSuperior : MonoBehaviour {

	// VELOCIDAD AL BAJAR
	float velocidad;
	float speed = 2;
	// RECOGEMOS EL oBJETO PAJARO PARA COGER SU SCRIPT
	[SerializeField] GameObject pajaro;

	void Start() {
		velocidad = pajaro.GetComponent<PajaroZombie>().elegirVelocidad;
	}

	// Update is called once per frame
	void Update () 
	{
		if (GameConfig.IsPlaying())
        {
            transform.Translate (Vector3.left * Time.deltaTime * speed);
			transform.Translate (Vector3.down * Time.deltaTime * velocidad);
		}
	}
}
