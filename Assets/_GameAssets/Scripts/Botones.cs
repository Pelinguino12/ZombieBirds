using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Botones : MonoBehaviour {
    [SerializeField] Text highscore;
    //START PULSADO
    private void Start() 
    {
        // HACER BOTON RESET EN UN FUTURO-----> PlayerPrefs.DeleteAll();
        NuevoHighscore();
    }
    public void Empezar()
    {
        SceneManager.LoadScene(1);
    }
    //EXIT PULSADO
    public void Salir()
    {
        Application.Quit();
    }
    //ESTABLECER HIGHSCORE
    void NuevoHighscore()
    {
        highscore.text = "Highscore: " + GameController.GetPuntos();
    }
}
