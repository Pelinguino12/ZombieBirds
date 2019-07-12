using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AplastadoraInferior : MonoBehaviour {
	float velocidad;
	int speed = 2;
	[SerializeField] GameObject pajaro;
	// Update is called once per frame
	private void Start() 
	{
		velocidad = pajaro.GetComponent<PajaroZombie>().elegirVelocidad;
	}
	void Update () 
	{
		if (GameConfig.IsPlaying())
        {
            transform.Translate (Vector3.left * Time.deltaTime * speed);
			transform.Translate (Vector3.up * Time.deltaTime * velocidad);
		}
	}
	void OnCollisionEnter (Collision aplastadorasuperior)
	{
		
	}
}
