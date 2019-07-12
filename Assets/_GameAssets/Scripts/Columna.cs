using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Columna : MonoBehaviour 
{
    [SerializeField] int speed = 3;
    int velocidad = 2;
    [SerializeField] float maxUp = 5.0f;
    [SerializeField] float maxDown = -5.0f;
    [SerializeField] float posicionAleatoria;
    bool mover = true;
    float primeraDireccion;
    float arriba = 1;
    float abajo = 0;
    float posicionY;
    float posicionYInicial;

    // Use this for initialization
    void Start ()
    {   
         // POSICION INICIAL TUBERIA
        posicionAleatoria = Random.Range (maxDown, maxUp);
        Vector3 position = new Vector3(transform.position.x, posicionAleatoria, transform.position.z);
        transform.position = position;

        // POSICION INICIAL TUBERIA
        posicionYInicial = transform.position.y;

        // RANGO MOVER TUBERIA
        primeraDireccion = Random.Range (arriba , abajo);
    }

    // Update is called once per frame
    void Update()
    {   
        if (GameConfig.IsPlaying())
        {
            // MOVER COLUMNAS A LA IZQUIERDA
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            // MOVER TUBERIA ARRIBA
            posicionY = transform.position.y;
            if (mover == true ) 
            {
                if (posicionY <= posicionYInicial + 5)
                {
                    transform.Translate(Vector3.up * Time.deltaTime * velocidad);
                }   
                else 
                { 
                    mover = false;
                }
            }
            // MOVER TUBERIA ABAJO
            else if ( mover == false ) 
            {
                if ( posicionY > posicionYInicial - 5)
                {
                    transform.Translate(Vector3.down * Time.deltaTime * velocidad);
                }
                else 
                {
                    mover = true;
                }
            }
            //DESTRUIR COLUMNAS
            if (transform.position.x < -25)
            {
                Destroy(gameObject);
            }
        } 
    }
}