using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private const string SCORE = "score";

    public static int GetPuntos()
    {
        int puntos = 0;
        if (PlayerPrefs.HasKey(SCORE))
        {
            puntos = PlayerPrefs.GetInt(SCORE);
        }
        return puntos;
    }

    public static void StorePuntos(int score)
    {
        PlayerPrefs.SetInt(SCORE, score);
        PlayerPrefs.Save();
    }
    public static int GetHighScore()
    {

    }
}