using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Botones : MonoBehaviour {
    [SerializeField] Text highscore;
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
    //ESTABLECER HIGHSCORE
    void NuevoHighscore()
    {
        highscore.text = "Highscore: " + GameController.GetPuntos();
    }
}
