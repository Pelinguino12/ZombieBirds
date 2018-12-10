using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour {
    //START PULSADO
    public void Empezar()
    {
        SceneManager.LoadScene(1);
    }
    //EXIT PULSADO
    public void Salir()
    {
        Application.Quit();
    }
}
