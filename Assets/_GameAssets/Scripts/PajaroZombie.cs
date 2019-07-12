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

    float maxSpeed = 3;
	float minSpeed= 2;
    public float elegirVelocidad;

    void Awake() {
        //VELOCIDAD DE APLASTADORAS
        elegirVelocidad = Random.Range (minSpeed , maxSpeed);
    }
    
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
        //ESPACIO PARA SALTAR
        if (Input.GetKeyDown("space"))
        {
            //SALTOS PAJARO
            rb.AddForce(transform.up * force);
        }
        //MUERE SI SALE DE PANTALLA
        if (transform.position.y < -8 || transform.position.y > 8)
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
            Invoke("FinalizarPartida", 3.0f);
        }
    }   

    void OnTriggerEnter(Collider detector){
        //SUMAR PUNTOS
        puntos = puntos + 1;
        GameController.StorePuntos(puntos);
        ActualizarPuntuacion();
        //SONIDO PUNTO SUMADO
        sonidoPuntuacion.Play();
     }

    void ActualizarPuntuacion()
    {
        //ESCRIBIR PUNTOS
        puntuacion.text = "Puntuación: " + puntos;
    }

    private void OnCollisionEnter(Collision columna)
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
