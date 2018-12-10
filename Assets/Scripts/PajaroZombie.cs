using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PajaroZombie : MonoBehaviour {

    [SerializeField] int puntos = 0;
    [SerializeField] int force = 100;
    public Rigidbody rb;
    [SerializeField] Text puntuacion;
    [SerializeField] ParticleSystem explosion;
    [SerializeField] AudioSource sonidoExplosion;
    [SerializeField] AudioSource sonidoPuntuacion;
    
    // Use this for initialization
    void Start () {
        //EMPEZAR
        GameConfig.ArrancaJuego();
        //CREAR RIGIDBODY DE PAJARO
        rb = GetComponent<Rigidbody>();
        //PUNTOS A 0
        ActualizarPuntuacion();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown("space"))
        {
            //SALTOS PAJARO
            rb.AddForce(transform.up * force);
        }
    }   

    void OnTriggerEnter(Collider detector){
        //SUMAR PUNTOS
        puntos = puntos + 1;
        ActualizarPuntuacion();
        //SONIDO PUNTO SUMADO
        sonidoPuntuacion.Play();
     }

    void ActualizarPuntuacion()
    {
        //ESCRIBIR PUNTOS
        puntuacion.text = "Puntuación: " + puntos;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // PARAR JUEGO
        GameConfig.PararJuego();
        //SINIDO PAJARO MUERTO
        sonidoExplosion.Play();
        // PARTICULAS EXPLOSION
        Instantiate(explosion, transform.position, Quaternion.identity);
        // DESTRUIR PAJARO
        gameObject.SetActive(false);
        // FINALIZAR PARTIDA
        Invoke("FinalizarPartida",3.0f);
    }
    void FinalizarPartida()
    {
        // REINICIAR
        SceneManager.LoadScene(0);
    }
}
